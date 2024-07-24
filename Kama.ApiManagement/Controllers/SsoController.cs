using Kama.ApiManagement.Core.Service;

namespace Kama.ApiManagement;

[Kama.ApiManagement.Attributes.Authorize]
[Route("api/[controller]")]
public class SsoController : BaseApiController
{
    public SsoController(
        Core.IRequestInfo requestInfo
        , Organization.ApiClient.Interface.IClientService clientService
        , ISsoCacheService ssoCacheService
        , ISsoService service
    )
    {
        _requestInfo = requestInfo;
        _clientService = clientService;
        _ssoCacheService = ssoCacheService;
        _service = service;
    }
    protected readonly Core.IRequestInfo _requestInfo;
    private readonly Organization.ApiClient.Interface.IClientService _clientService;
    private readonly ISsoCacheService _ssoCacheService;
    private readonly ISsoService _service;

    [AllowAnonymous, HttpPost, Route("CheckAuthorizationForSso")]
    public async Task<AppCore.Result> CheckAuthorizationForSso(ClientListVM model)
    {

        if (_requestInfo.UserName == null)
            return AppCore.Result.Failure(message: "توکن نامعتبر است", code: 401);
        if (string.IsNullOrEmpty(model.ConnectionHubId))
            return AppCore.Result.Failure(message: "توکن نامعتبر است");

        if (model.ConnectionHubId == "main")
            return AppCore.Result.Successful();

        if (model.ID == Guid.Empty)
            return AppCore.Result.Failure(message: "توکن نامعتبر است");

        var apiModel = new Organization.Core.Model.ClientListVM
        {
            CallBack = model.CallBack,
            UserHash = model.UserHash,
            UserID = model.UserID
        };
        var result = await _clientService.CheckUserBySso(apiModel);
        if (!result.Success)
            return AppCore.Result.Failure(message: result.Message);

        var add = await _ssoCacheService.AddAsync(model.ID, model.ConnectionHubId, _requestInfo.UserName, _requestInfo.SsoTicket, result.Data.UserHash);
        if (!add.Success)
            return AppCore.Result.Failure(message: add.Message);

        return AppCore.Result.Successful();

    }

    [AllowAnonymous, HttpPost, Route("GetLoginUrl")]
    public async Task<AppCore.Result<Client>> GetLoginUrl(ClientListVM model)
    {
        if (string.IsNullOrEmpty(model.ConnectionHubId))
            return AppCore.Result<Client>.Failure(message: "توکن نامعتبر است");

        if (model.ConnectionHubId != "main")
            model.ConnectionHubId = Guid.NewGuid().ToString();

        var result = await CheckAuthorizationForSso(model);
        if (!result.Success)
            return AppCore.Result<Client>.Failure(message: result.Message);

        return AppCore.Result<Client>.Successful(data: new Client { Url = $"?key={model.ConnectionHubId}" });
    }


    [HttpPost, Route("ListApplication")]
    public Task<AppCore.Result<IEnumerable<Sso>>> ListApplication(SsoVM model)
            => _service.ListApplicationAsync(model);

    [AllowAnonymous, HttpPost, Route("CheckSmsLogin")]
    public Task<AppCore.Result<Sso>> CheckSmsLogin(SsoVM model)
        => _service.CheckSmsLoginAsync(model);


    //[AllowAnonymous, HttpPost, Route("EditListApp")]
    //public Task<AppCore.Result> EditListApp(Sso model)
    //    => _service.EditListAppAsync(model);


    //[AllowAnonymous, HttpPost, Route("EditListApp")]
    //public async Task<AppCore.Result<User>> GetUser(Sso model)
    //{
        //if (model.Key == null || model.Hash == null)
        //    return AppCore.Result<User>.Failure(message: "اطلاعات را کامل وارد کنید");

        //var array = SsoDirection.Base64Decode(model.Key);
        //var base64Encode = SsoDirection.Base64Encode($"{array[0]}::{array[1]}::{array[2]}::{array[3]}::{model.Hash}");

        //if (!SsoDirection.CheckObjectCache(base64Encode))
        //    return AppCore.Result<User>.Failure(message: "توکن نامعتبر است.");

        //var list = SsoDirection.Base64Decode(base64Encode);

        //var ssoUserResult = await _userService.GetUserByUserNamePasswordAsync(list[3], null);

        //SsoDirection.deleteObjectCache(model.Key);

        //if (ssoUserResult.Success && ssoUserResult.Data == null)
        //    return AppCore.Result<User>.Failure(message: "کاربر یافت نشد");

        //return ssoUserResult;

    //    return AppCore.Result<User>.Failure(message: "اطلاعات را کامل وارد کنید");
    //}

}
