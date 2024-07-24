namespace Kama.ApiManagement.Infrastructure.DAL.DataSources;


public class RefreshTokenDataSource : DataSource, IRefreshTokenDataSource
{
    public RefreshTokenDataSource()
         : base()
    {
    }

    public async Task<Result<RefreshToken>> AddAsync(RefreshToken model)
    {
        try
        {
            var result = (await atu.AddRefreshTokenAsync(
                _id: model.ID,
                _userID: model.UserID,
                _expireDate: model.ExpireDate,
                _issuedDate: model.IssuedDate,
                _protectedTicket: model.ProtectedTicket,
                _ssoTicket: model.SsoTicket,
                _os: (byte)model.OS,
                _oSVersion: model.OSVersion,
                _browser: (byte)model.Browser,
                _browserVersion: model.BrowserVersion,
                _deviceType: (byte)model.DeviceType
                )).ToActionResult();

            if (result.Success)
                return Result<RefreshToken>.Successful(data: model);

            return Result<RefreshToken>.Failure(message: result.Message);
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public async Task<Result<RefreshToken>> UpdateExpireDateAsync(RefreshToken model)
    {
        try
        {
            var result = (await atu.UpdateRefreshTokensExpireDateAsync(
                _id:model.ID,
                _expireDate:model.ExpireDate,
                _ssoTicket:model.SsoTicket
                )).ToActionResult<RefreshToken>();

            return result;
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public async Task<AppCore.Result<RefreshToken>> GetAsync(Guid id)
    {
        try
        {
            var result = (await atu.GetRefreshTokenAsync(
                _id: id
                )).ToActionResult<RefreshToken>();

            return result;
        }
        catch (Exception e)
        {
            throw;
        }
    }
}