
namespace Kama.ApiManagement.Infrastructure.DAL.DataSources;


class SsoDataSource : DataSource, Core.DataSource.ISsoDataSource
{
    public SsoDataSource()
        : base()
    {
    }
    public async Task<Result<Sso>> CheckUserAsync(SsoVM model)
    {
        try
        {
            var result = (await org.GetSsoUserAsync(
                _callBackUrl: model.CallBack,
                _userHash: model.UserHash,
                _userID: model.UserID
             )).ToActionResult<Sso>();

            return AppCore.Result<Sso>.Successful(data: result.Data);
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public async Task<Result<IEnumerable<Sso>>> ListApplicationAsync(SsoVM model)
    {
        try
        {
            var result = (await org.GetSsoApplicationAsync(
                _userID: _requestInfo.UserId,
                _pageIndex: model.PageIndex,
                _pageSize: model.PageSize
             )).ToListActionResult<Sso>();


            return result;
        }
        catch (Exception e)
        {
            throw;
        }

    }

    public async Task<Result<Sso>> CheckSmsLoginAsync(SsoVM model)
    {
        try
        {
            var result = (await org.CheckSmsLoginAsync(
                _applicationID: model.ApplicationID,
                _client: _requestInfo.ClientId,
                _userID: model.UserID
             )).ToActionResult<Sso>();

            return result;
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public async Task<Result> EditListAppAsync(Sso model)
    {
        try
        {
            var result = (await org.EditListAppAsync(
                _applicationIDS: _objSerializer.Serialize(model.AppIDs),
                _smsLogin: model.SmsLogin
             )).ToActionResult();

            return result;
        }
        catch (Exception e)
        {
            throw;
        }
    }
}