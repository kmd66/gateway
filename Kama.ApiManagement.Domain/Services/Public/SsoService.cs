using Kama.AppCore.IOC;
using Kama.ApiManagement.Core.DataSource;
using Kama.ApiManagement.Core.Service;
using Kama.Library.Helper.Security;
using System.Security.Claims;

namespace Kama.ApiManagement.Domain.Services;

public class SsoService : Service, ISsoService
{
    public SsoService(
       ISsoDataSource dataSource
        )
    {
        _dataSource = dataSource;
    }

    private readonly ISsoDataSource _dataSource;

    public async Task<Result<IEnumerable<Sso>>> ListApplicationAsync(SsoVM model)
    {
        var result = await _dataSource.ListApplicationAsync(model);
        if (!result.Success)
            return Result<IEnumerable<Sso>>.Failure(message: result.Message);

        foreach (var item in result.Data.ToList())
        {
            item.Url = Base64Encode(item.ClientID + "::" + item.CallBack + "::" + item.UserID);
            item.UserHash = null;
        }
        return result;
    }

    public Task<Result<Sso>> CheckSmsLoginAsync(SsoVM model)
    => _dataSource.CheckSmsLoginAsync(model);

    public Task<Result> EditListAppAsync(Sso model)
    => _dataSource.EditListAppAsync(model);

    private static string Base64Encode(string plainText)
    {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        return System.Convert.ToBase64String(plainTextBytes);
    }
}