using Kama.ApiManagement.Core.DataSource;
using Kama.AppCore;

namespace Kama.ApiManagement.Domain.Services;

public class IssuedTokenService : Service, IIssuedTokenService
{
    public IssuedTokenService(IIssuedTokenDataSource dataSource, Core.IRequestInfo requestInfo)
    {
        _dataSource = dataSource;
        _requestInfo = requestInfo;
    }
    private readonly IIssuedTokenDataSource _dataSource;
    private readonly Core.IRequestInfo _requestInfo;

    public Task<Result<IssuedToken>> GetIssuedTokenByTokenAsync(string token)
        => _dataSource.GetIssuedTokenByTokenAsync(token);

    public Task<Result> LogoutAsync(IssuedTokenListVM model)
        => _dataSource.LogoutAsync(model);

    public Task<Result> LogoutByRefreshTokenIDAsync(IssuedTokenListVM model)
        => _dataSource.LogoutByRefreshTokenIDAsync(model);

    public async Task<Result<IEnumerable<ActiveToken>>> ActiveTokenByUserAsync(ActiveToken model)
    {
        var result = await _dataSource.ActiveTokenByUserAsync();
        if (!result.Success)
            return Result<IEnumerable<ActiveToken>>.Failure(message: result.Message);
        if (result.Data.ToList().Count == 0)
            return Result<IEnumerable<ActiveToken>>.Failure(message: "Count = 0");

        foreach (var item in result.Data.ToList())
            item.ApplicationName = ApplicationHelper.GetApplicationEnum(item.ApplicationID).ToString().Replace("_", " ");

        var results = result.Data.GroupBy(
            p => p.SsoTicket,
            (key, g) => new ActiveToken { SsoTicket = key, Items = g.ToList() });
        return Result<IEnumerable<ActiveToken>>.Successful(data: results);
    }

    public Task<Result<Dictionary<string, string>>> ValidateTokenAsync()
        => _requestInfo.AuthorizationClaims != null ? 
        Result<Dictionary<string, string>>.SuccessfulAsync(data: _requestInfo.AuthorizationClaims)
        :Result<Dictionary<string, string>>.FailureAsync(message:"");

}
