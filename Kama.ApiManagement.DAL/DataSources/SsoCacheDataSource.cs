
namespace Kama.ApiManagement.Infrastructure.DAL.DataSources;


class SsoCacheDataSource : DataSource, Core.DataSource.ISsoCacheDataSource
{
    public SsoCacheDataSource()
        : base()
    {
    }

    public async Task<Result<SsoCache>> AddAsync(SsoCache model)
    {
        try
        {
            var result = (await org.AddSsoCacheAsync(
                _id: Guid.NewGuid(),
                _masterPassword: _requestInfo.MasterPasswordID,
                _key: model.Key,
                _hash: model.Hash,
                _ssoTicket: model.SsoTicket,
                _userName: model.UserName
             )).ToActionResult<SsoCache>();

            return result;
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public async Task<Result<SsoCache>> GetAsync(string key)
    {
        try
        {
            var result = (await org.GetSsoCacheAsync(
                _key: key
             )).ToActionResult<SsoCache>();

            return result;
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public async Task<Result> DeleteAsync(string key)
    {
        try
        {
            var result = (await org.DeleteSsoCacheAsync(
                _key: key
             )).ToActionResult();

            return result;
        }
        catch (Exception e)
        {
            throw;
        }
    }
}