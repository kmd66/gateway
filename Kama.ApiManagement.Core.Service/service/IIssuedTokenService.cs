using Kama.AppCore;
using Kama.ApiManagement.Core.Model;

namespace Kama.ApiManagement.Core.Service;
public interface IIssuedTokenService : IService
{
    Task<AppCore.Result<IssuedToken>> GetIssuedTokenByTokenAsync(string token);

    Task<Result> LogoutAsync(IssuedTokenListVM model);

    Task<Result> LogoutByRefreshTokenIDAsync(IssuedTokenListVM model);

    Task<Result<IEnumerable<ActiveToken>>> ActiveTokenByUserAsync(ActiveToken model);

    Task<AppCore.Result<Dictionary<string, string>>> ValidateTokenAsync();
}
