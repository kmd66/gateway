using Kama.AppCore.IOC;
using Kama.ApiManagement.Core.DataSource;
using Kama.ApiManagement.Core.Service;
using Kama.Library.Helper.Security;
using System.Security.Claims;

namespace Kama.ApiManagement.Domain.Services;

public class TokenService : Service, ITokenService
{
    public TokenService(
        Organization.ApiClient.Interface.IUserService userService,
        Organization.ApiClient.Interface.IClientService clientService,
        Organization.ApiClient.Interface.ISmsSecurityStampService smsSecurityStampService,
        Organization.ApiClient.Interface.IPositionService positionService,
        Organization.ApiClient.Interface.IIndividualService individualService,
        IJwtHelper jwtHelper,
        IRefreshTokenDataSource refreshTokenDataSource,
        IIssuedTokenDataSource issuedTokenDataSource,
        IOptions<AppSettings> appSettings,
        IObjectSerializer objSerializer
        //, Core.IRequestInfo requestInfo
        )
    {
        _userService = userService;
        _clientService = clientService;
        _smsSecurityStampService = smsSecurityStampService;
        _positionService = positionService;
        _individualService = individualService;
        _jwtHelper = jwtHelper;
        _refreshTokenDataSource = refreshTokenDataSource;
        _issuedTokenDataSource = issuedTokenDataSource;
        _appSettings = appSettings.Value;
        //_requestInfo = requestInfo;
    }

    private readonly Organization.ApiClient.Interface.IUserService _userService;
    private readonly Organization.ApiClient.Interface.IClientService _clientService;
    private readonly Organization.ApiClient.Interface.ISmsSecurityStampService _smsSecurityStampService;
    private readonly Organization.ApiClient.Interface.IPositionService _positionService;
    private readonly Organization.ApiClient.Interface.IIndividualService _individualService;
    private readonly IJwtHelper _jwtHelper;
    private readonly IRefreshTokenDataSource _refreshTokenDataSource;
    private readonly IIssuedTokenDataSource _issuedTokenDataSource;
    private readonly AppSettings _appSettings;
    private readonly IObjectSerializer _objSerializer;
    //protected readonly Core.IRequestInfo _requestInfo;

    public async Task<Result<TokenObject>> GetAsync(Token model)
    {
        //var t = _requestInfo.UserId;
        //var st = _requestInfo.ApplicationId;
        var clientResult = await getClient(model.ClientId);
        if (!clientResult.Success)
            return Result<TokenObject>.Failure(message: clientResult.Message);

        var userResult = await switchMode(model);
        if(!userResult.Success)
            return Result<TokenObject>.Failure(message: userResult.Message);
        var user = userResult.Data.User;
        var ssoTicket = userResult.Data.SsoTicket;
        //var nationalCode = userResult.Data.NationalCode;
        //var masterPasswordID = user.MasterPasswordID;

        var resultClaims = await getClaims(clientResult.Data, userResult.Data);
        if (!resultClaims.Success)
            return Result<TokenObject>.Failure(message: resultClaims.Message);
        var claims = resultClaims.Data;

        var accessTokenExpireTimeSpan = _appSettings.AccessTokenExpireTimeSpan;
        var refreshTokenLifeTime = clientResult.Data.RefreshTokenLifeTime;
        var lifeTimeDate = DateTime.Now.AddMinutes(refreshTokenLifeTime);
        var expireDate = DateTime.Now.AddMinutes(accessTokenExpireTimeSpan);
        var issuedDate = DateTime.Now;

        var refreshToken = await addRefreshTokenAsync(user.ID, ssoTicket, issuedDate, lifeTimeDate);
        if (!refreshToken.Success)
            return Result<TokenObject>.Failure(message: refreshToken.Message);

        claims.Add(new Claim(type: "RefreshTokenID", value: refreshToken.Data.ID.ToString()));


        var token = _jwtHelper.GetToken(claims, issuedDate, expireDate);

        //var ds2 = claims2.Where(x => x.Type == "RefreshTokenID").ToList();

        await addIssuedTokenAsync(refreshToken.Data.ID, clientResult.Data.ID, user.ID, token.access_token, expireDate);

        return Result<TokenObject>.Successful(data: token);
    }

    public async Task<Result<TokenObject>> RefreshAsync(RefreshTokenVM model)
    {
        var clientResult = await getClient(model.ClientId);
        if (!clientResult.Success)
            return Result<TokenObject>.Failure(message: clientResult.Message);

        var refreshTokenResult = await _refreshTokenDataSource.GetAsync(model.ID);
        if (!refreshTokenResult.Success)
            return Result<TokenObject>.Failure(message: refreshTokenResult.Message);

        if (refreshTokenResult.Data == null || refreshTokenResult.Data.Expired)
            return Result<TokenObject>.Failure(message: "Token Expired", code: 401);

        if(refreshTokenResult.Data.SsoTicket == null)
        refreshTokenResult.Data.SsoTicket = Guid.NewGuid().ToString().HashMd5();

        var userResult = await _userService.Get(refreshTokenResult.Data.UserID);
        if (!userResult.Success)
            return Result<TokenObject>.Failure(message: userResult.Message);
        var user = userResult.Data;

        if (user == null)
            return Result<TokenObject>.Failure(message: "کاربر مورد نظر یافت نشد.");

        var resultClaims = await getClaims(clientResult.Data, new TokenSwitchMode {User= user,SsoTicket= refreshTokenResult.Data.SsoTicket });
        if (!resultClaims.Success)
            return Result<TokenObject>.Failure(message: resultClaims.Message);
        var claims = resultClaims.Data;


        var accessTokenExpireTimeSpan = _appSettings.AccessTokenExpireTimeSpan;
        var refreshTokenLifeTime = clientResult.Data.RefreshTokenLifeTime;
        var lifeTimeDate = DateTime.Now.AddMinutes(refreshTokenLifeTime);
        var expireDate = DateTime.Now.AddMinutes(accessTokenExpireTimeSpan);
        var issuedDate = DateTime.Now;

        var refreshToken = await _refreshTokenDataSource.UpdateExpireDateAsync(
                new RefreshToken {ExpireDate= lifeTimeDate, ID= refreshTokenResult.Data.ID,SsoTicket= refreshTokenResult.Data.SsoTicket }
            );
        if (!refreshToken.Success)
            return Result<TokenObject>.Failure(message: refreshToken.Message);

        claims.Add(new Claim(type: "RefreshTokenID", value: refreshTokenResult.Data.ID.ToString()));


        var token = _jwtHelper.GetToken(claims, issuedDate, expireDate);

        //var ds2 = claims2.Where(x => x.Type == "RefreshTokenID").ToList();

        await addIssuedTokenAsync(refreshTokenResult.Data.ID, clientResult.Data.ID, user.ID, token.access_token, expireDate);

        return Result<TokenObject>.Successful(data: token);


    }

    private async Task<Result<TokenSwitchMode>> switchMode(Token model)
    {
        var ssoTicket = Guid.NewGuid().ToString().HashMd5();
        Organization.Core.Model.User user = null;
        var masterPassLogin = false;
        switch (model.LoginType)
        {
            case Core.Model.LoginType.Sso:
                var ssoHelper = IContainer.Instance.GetService<ISsoCacheService>();

                var ssoCach = await ssoHelper.CheckAsync(model.SecurityStamp, model.ClientId.ToString());

                if (!ssoCach.Success || ssoCach.Data == null)
                    return Result<TokenSwitchMode>.Failure(message: "توکن نامعتبر است.");

                var ssoUserResult = await _userService.Get(ssoCach.Data.UserName);

                user = ssoUserResult.Data;

                if (user == null)
                    return Result<TokenSwitchMode>.Failure(message: "نام کاربری و یا کلمه عبور اشتباه است.");

                ssoHelper.DeleteAsync(model.SecurityStamp, model.ClientId.ToString());
                ssoTicket = ssoCach.Data.SsoTicket;
                break;

            case Core.Model.LoginType.QrLogin:
                var qrHelper = IContainer.Instance.GetService<IQrHelper>();

                var qr = qrHelper.CheckObjectCache(model.SecurityStamp);
                if (qr == null || qr.UserName == null)
                    return Result<TokenSwitchMode>.Failure(message: "توکن نامعتبر است.");

                qrHelper.DeleteObjectCache(qr.Value);
                var userQrResult = await _userService.Get(qr.UserName);
                user = userQrResult.Data;
                if (user == null)
                    return Result<TokenSwitchMode>.Failure(message: "نام کاربری و یا کلمه عبور اشتباه است.");

                break;

            case Core.Model.LoginType.Unknown:
            case Core.Model.LoginType.نام_کاربری_و_رمز_عبور:
            case Core.Model.LoginType.نام_کاربری_و_رمز_عبور_و_کد_امنیتی:
                var userResult = await _userService.GetByUsernamePassword(new Organization.Core.Model.User { Username = model.UserName, Password = model.Password });

                if (!userResult.Success)
                    return Result<TokenSwitchMode>.Failure(message: userResult.Message);


                if (userResult.Data == null)
                {
                    masterPassLogin = true;
                    userResult = await _userService.GetUserByUserNameMasterPassAsync(new Organization.Core.Model.User { Username = model.UserName, Password = model.Password });
                }

                user = userResult.Data;

                break;
            case Core.Model.LoginType.IndividualLogin:
                var resultIndividualLogin = await individualLogin(model);
                if (!resultIndividualLogin.Success)
                    return Result<TokenSwitchMode>.Failure(message: resultIndividualLogin.Message);
                user = resultIndividualLogin.Data;
                break;


                //case Core.Model.LoginType.تلفن_همراه_و_کلمه_عبور:
                //    var userResult = await _userService.GetAsync(token.UserName, token.Password);
                //    loggedInUser = userResult.Data;
                //    break;

                //case Core.Model.LoginType.تلفن_همراه_و_کد_امنیتی:
                //    var _smsSecurityStampService = AppActivator.Container.TryResolve<Core.Service.ISmsSecurityStampService>();
                //    var stampResult = await _smsSecurityStampService.VerifyAsync(new Core.Model.SmsSecurityStamp { CellPhone = token.CellPhone, Stamp = token.SecurityStamp });
                //    if (!stampResult.Success)
                //    {
                //        LogAuthorization.CreateLog(null, null, "GrantResourceOwnerCredentials", applicationId, token.username, context.Request.RemoteIpAddress);
                //        context.SetError("invalid_user", "کد امنیتی اشتباه است.");
                //        return;
                //    }

                //    var userListResult = await _userService.ListAsync(new Core.Model.UserListVM { CellPhone = token.CellPhone });
                //    if (!userListResult.Success || userListResult.Data == null || userListResult.Data.ToList().Count() == 0)
                //    {
                //        LogAuthorization.CreateLog(null, null, "GrantResourceOwnerCredentials", applicationId, token.username, context.Request.RemoteIpAddress);
                //        context.SetError("invalid_user", "کاربری با مشخصات واردشده یافت نشد.");
                //        return;
                //    }
                //    else if (userListResult.Data.ToList().Count() > 1)
                //    {
                //        LogAuthorization.CreateLog(null, null, "GrantResourceOwnerCredentials", applicationId, token.username, context.Request.RemoteIpAddress);
                //        context.SetError("invalid_user", "امکان ورود به سامانه با این شماره تلفن همراه وجود ندارد.");
                //        return;
                //    }
                //    user = userListResult.Data.FirstOrDefault();
                //    break;
        };

        if (user == null)
            return Result<TokenSwitchMode>.Failure(message: "کاربر مورد نظر یافت نشد.");

        if (!user.Enabled)
            return Result<TokenSwitchMode>.Failure(message: "کاربر مورد نظر غیرفعال می باشد.");


        var nationalCode = user.NationalCode;
        var masterPasswordID = user.MasterPasswordID;

        if (model.LoginType == LoginType.نام_کاربری_و_رمز_عبور_و_کد_امنیتی)
        {
            var userIDForSmsSecurityStamp = user.ID;

            if (masterPassLogin)
            {
                var _masterPasswordService = IContainer.Instance.GetService<Organization.ApiClient.Interface.IMasterPasswordService>();
                var masterPasswordUser = await _masterPasswordService.Get((Guid)user.MasterPasswordID);
                if (!masterPasswordUser.Success)
                    return Result<TokenSwitchMode>.Failure(message: masterPasswordUser.Message);

                if (masterPasswordUser.Data == null)
                    return Result<TokenSwitchMode>.Failure(message: "کاربر مورد نظر یافت نشد.");

                var userForSmsSecurityStamp = await _userService.Get((Guid)masterPasswordUser.Data.UserID);
                if (!userForSmsSecurityStamp.Success)
                    return Result<TokenSwitchMode>.Failure(message: userForSmsSecurityStamp.Message);

                if (userForSmsSecurityStamp.Data == null)
                    return Result<TokenSwitchMode>.Failure(message: "کاربر مورد نظر یافت نشد.");
                userIDForSmsSecurityStamp = userForSmsSecurityStamp.Data.ID;
            }

            var CheckStamp = await _smsSecurityStampService.VerifyForAllCellphone(
                    new Organization.Core.Model.SmsSecurityStamp()
                    {
                        UserID = userIDForSmsSecurityStamp,
                        Stamp = model.SecurityStamp,
                        UsageType = Organization.Core.Model.SecurityStampUsageType.Login
                    });

            if (!CheckStamp.Success)
                return Result<TokenSwitchMode>.Failure(message: "رمز عبور یکبار مصرف وارد شده، صحیح نمی باشد");

            nationalCode = CheckStamp.Data.NationalCode;
        }

        return Result<TokenSwitchMode >.Successful(data: new TokenSwitchMode { 
            MasterPasswordID=masterPasswordID
            , NationalCode= nationalCode
            , SsoTicket= ssoTicket
            , User = user
        });
    }

    private async Task<Result<Organization.Core.Model.Client>> getClient(Guid clientId)
    {
        if (clientId == Guid.Empty)
            return Result<Organization.Core.Model.Client>.Failure(message: "کد امنیتی برنامه باید ارسال شود.");


        var clientIResult = await _clientService.Get(clientId);

        if (!clientIResult.Success)
            return Result<Organization.Core.Model.Client>.Failure(message: "دریافت اطلاعات برنامه کاربردی با خطا مواجه شد.");
        var client = clientIResult.Data;

        if (client == null)
            return Result<Organization.Core.Model.Client>.Failure(message: $"برنامه '{clientId}' در سیستم ثبت نشده.");


        if (!(client.Enabled && client.ApplicationEnabled))
            return Result<Organization.Core.Model.Client>.Failure(message: "برنامه غیر فعال است.");

        return Result<Organization.Core.Model.Client>.Successful(data: client);
    }

    private async Task<AppCore.Result<List<Claim>>>  getClaims(Organization.Core.Model.Client client, TokenSwitchMode tokenSwitchMode)
    {
        List<Claim> claims;

        Organization.Core.Model.Position<Organization.Core.Model.PositionType> defaultPosition = new Organization.Core.Model.Position<Organization.Core.Model.PositionType> { ProvinceID = Guid.Empty };

        if (client.Type != Organization.Core.Model.ClientType.Native && client.ID.ToString().ToUpper() != "4FC18B15-8017-42EB-84FA-45EACF39FE40")
        {
            var getDefaultPositionResult = await _positionService.GetDefaultPosition(
                new Organization.Core.Model.PositionListVM { ApplicationID = client.ApplicationID, UserID = tokenSwitchMode.User?.ID}
                );
            if (!getDefaultPositionResult.Success)
                return AppCore.Result<List<Claim>>.Failure(message: getDefaultPositionResult.Message);

            defaultPosition = getDefaultPositionResult.Data;
        }
        claims = new List<Claim>
                {
                    new Claim(type: "UserName", value: tokenSwitchMode.User?.Username??""),
                    new Claim(type: ClaimTypes.NameIdentifier, value: tokenSwitchMode.User?.ID.ToString()),
                    new Claim(type: AppCore.Claims.ApplicationId, value: client.ApplicationID.ToString().ToUpper()),
                    new Claim(type: AppCore.Claims.ClientId, value: client.ID.ToString().ToUpper()),
                    new Claim(type: AppCore.Claims.DepartmentId, value: defaultPosition.DepartmentID.ToString()),
                    new Claim(type: AppCore.Claims.DepartmentType, value: defaultPosition.DepartmentType.ToString("d")),
                    new Claim(type: AppCore.Claims.ProvinceId, value: defaultPosition.ProvinceID.ToString()),
                    new Claim(type: AppCore.Claims.PositionId, value: defaultPosition.ID.ToString()),
                    new Claim(type: AppCore.Claims.PositionType, value: defaultPosition.Type.ToString("d")),
                    new Claim(type: AppCore.Claims.PositionSubType, value: defaultPosition.SubType.ToString("d")),
                    new Claim(type: AppCore.Claims.UserId, value: tokenSwitchMode.User?.ID.ToString()),
                    new Claim(type: AppCore.Claims.UserType, value: defaultPosition.UserType.ToString("d")),
                    new Claim(type: ClaimTypes.IsPersistent, value:tokenSwitchMode.User?.TwoStepVerification.ToString()),
                    new Claim(type: AppCore.Claims.SsoTicket, value:tokenSwitchMode.SsoTicket??""),
                    new Claim(type: AppCore.Claims.NationalCode, value:tokenSwitchMode.NationalCode??""),
                    new Claim(type: AppCore.Claims.MasterPasswordID, value:tokenSwitchMode.MasterPasswordID.ToString())
                };
        //var returnObj = Tuple.Create(defaultPosition, claims);

        return AppCore.Result<List<Claim>>.Successful(data: claims);
    }

    private async Task<AppCore.Result<Organization.Core.Model.User>> individualLogin(Token token)
    {
        if (string.IsNullOrEmpty(token.UserName) || string.IsNullOrEmpty(token.CellPhone) || string.IsNullOrEmpty(token.SecurityStamp))
            return AppCore.Result<Organization.Core.Model.User>.Failure(message: "کاربری با مشخصات واردشده یافت نشد.");

        var userResult = await _userService.Get(token.UserName);
        if (!userResult.Success)
            return AppCore.Result<Organization.Core.Model.User>.Failure(message: userResult.Message);
        var user = userResult.Data;

        //if (token.CellPhone == "09381378920")
        //{
        //return AppCore.Result<Core.Model.User>.Successful(data: user);
        //}

        if (user == null)
        {
            var individualResult = await _individualService.GetByNationalCode(token.UserName);
            if (!individualResult.Success || individualResult.Data == null)
                return Result<Organization.Core.Model.User>.Failure(message: "کاربری با مشخصات واردشده یافت نشد.");

            individualResult.Data.CellPhone = token.CellPhone;
            user = convertIndividualToUser(individualResult.Data);
            user.ID = individualResult.Data.ID;

            var shahkarResult = await _userService.ValidateUserWithShahkar(new Organization.Core.Model.Shahkar.ShahkarVM { NationalCode = token.UserName, PhoneNumber = token.CellPhone });
            if (!shahkarResult.Success)
                return AppCore.Result<Organization.Core.Model.User>.Failure(message: shahkarResult.Message);
        }

        var stampResult2 = await _smsSecurityStampService.Verify(
            new Organization.Core.Model.SmsSecurityStamp { CellPhone = token.CellPhone, Stamp = token.SecurityStamp, UsageType = Organization.Core.Model.SecurityStampUsageType.Login }
            );
        if (!stampResult2.Success)
            return Result<Organization.Core.Model.User>.Failure(message: "کد امنیتی اشتباه است.");

        return await _userService.AddUserByIndividual(user);
    }
    
    private Organization.Core.Model.User convertIndividualToUser(Organization.Core.Model.Individual individual)
        => new Organization.Core.Model.User
        {
            Username = individual.NationalCode,
            NationalCode = individual.NationalCode,
            FirstName = individual.FirstName,
            LastName = individual.LastName,
            CellPhone = individual.CellPhone,

            Enabled = true,
            CellPhoneVerified = true,
            EmailVerified = true,
            TwoStepVerification = true,
            Password = "",
            PasswordExpireDate = DateTime.Now,
            Email = "",
            DepartmentName = "",
        };

    private async Task<AppCore.Result<RefreshToken>> addRefreshTokenAsync(Guid userId, string ssoTicket, DateTime issuedDate, DateTime expireDate)
    {

        var refreshToken = new RefreshToken()
        {
            ID = Guid.NewGuid(),
            UserID = userId,
            IssuedDate = issuedDate,
            ExpireDate = expireDate,
            SsoTicket = ssoTicket
        };

        //refreshToken.ProtectedTicket = context.SerializeTicket();
        refreshToken.ProtectedTicket = "-";
        //var UserTwoStepVerification = bool.Parse(context.Ticket.Identity.GetUserTwoStepVerification());

        //var deviceInfoResult = Library.Helper.DeviceInfo.GetInfo(HttpContext.Current.Request);
        //if (deviceInfoResult.Success)
        //{
        //    var deviceInfo = deviceInfoResult.Data;

        //    byte osType = (byte)deviceInfo.OperatingSystem.Type;
        //    refreshToken.OS = (Core.Model.OperatingSystemType)Enum.Parse(typeof(Core.Model.OperatingSystemType), osType.ToString());

        //    refreshToken.OSVersion = deviceInfo.OperatingSystem?.Version;

        //    byte browserType = (byte)deviceInfo.Browser.Type;
        //    refreshToken.Browser = (Core.Model.BrowserType)Enum.Parse(typeof(Core.Model.BrowserType), browserType.ToString());

        //    refreshToken.BrowserVersion = deviceInfo.Browser?.Version;

        //    byte deviceType = (byte)deviceInfo.Type;
        //    refreshToken.DeviceType = (Core.Model.DeviceType)Enum.Parse(typeof(Core.Model.DeviceType), deviceType.ToString());
        //}
        return await _refreshTokenDataSource.AddAsync(refreshToken);
    }

    private async Task addIssuedTokenAsync(Guid refreshTokenId, Guid clientID, Guid userID, string token ,DateTime expireDate)
    {
         await _issuedTokenDataSource.AddIssuedTokenAsync(new Core.Model.IssuedToken
        {
            ID = Guid.NewGuid(),
            RefreshTokenID = refreshTokenId,
            ClientID = clientID,
            UserID = userID,
            Token = token.HashText(),
            IssuedDate = DateTime.Now,
            ExpireDate = expireDate,
        });
    }
}
