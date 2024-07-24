using Kama.AppCore.IOC;
using Kama.ApiManagement.Core.DataSource;
using Kama.ApiManagement.Core.Service;
using Kama.Library.Helper.Security;
using System.Security.Claims;

namespace Kama.ApiManagement.Domain.Services;

public class SsoCacheService : Service, ISsoCacheService
{
    public SsoCacheService(
       ISsoCacheDataSource dataSource
        )
    {
        _dataSource = dataSource;
    }

    private readonly ISsoCacheDataSource _dataSource;


    public Task<Result<SsoCache>> AddAsync(Guid ClientID, string connectionHubId, string userName, string ssoTicket, string hash)
    {
        var cacheKey = ClientID.ToString() + connectionHubId;
        var cacheKeyMd5 = Kama.Library.Helper.Security.Extensions.HashMd5(cacheKey);

        var ssoCach = new SsoCache { SsoTicket = ssoTicket, UserName = userName, Hash = hash, Key = cacheKeyMd5 };
        return _dataSource.AddAsync(ssoCach);
    }

    public async Task<Result<SsoCache>> CheckAsync(string SecurityStamp, string clientId)
    {
        if (string.IsNullOrEmpty(SecurityStamp))
            return Result<SsoCache>.Failure(message: "SecurityStamp null");

        var list = Base64Decode(SecurityStamp);
        SsoCache cache;

        var cacheKey = clientId + list[0];
        var cacheKeyMd5 = Kama.Library.Helper.Security.Extensions.HashMd5(cacheKey);

        var get = await _dataSource.GetAsync(cacheKeyMd5);
        if (!get.Success)
            return Result<SsoCache>.Failure(message: get.Message);

        cache = get.Data;
        if (cache == null || cache.Hash != list[1])
            return Result<SsoCache>.Failure(message: "obj null");

        return Result<SsoCache>.Successful(data: cache);
    }

    public async Task<Result> DeleteAsync(string SecurityStamp, string clientId)
    {
        if (!string.IsNullOrEmpty(SecurityStamp))
        {

            var list = Base64Decode(SecurityStamp);
            var cacheKey = clientId + list[0];
            var cacheKeyMd5 = Kama.Library.Helper.Security.Extensions.HashMd5(cacheKey);
            await _dataSource.DeleteAsync(cacheKeyMd5);

        }
        return Result.Successful();
    }

    private static string[] Base64Decode(string base64EncodedData)
    {
        var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        var base64EncodedString = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        var rx = new System.Text.RegularExpressions.Regex("::");
        return rx.Split(base64EncodedString);
    }
}