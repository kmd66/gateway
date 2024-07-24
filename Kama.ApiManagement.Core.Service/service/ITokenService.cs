using Kama.ApiManagement.Core.Model;

namespace Kama.ApiManagement.Core.Service;
public interface ITokenService : IService
{
    Task<AppCore.Result<TokenObject>> GetAsync(Token model);
    Task<AppCore.Result<TokenObject>> RefreshAsync(RefreshTokenVM model);

}
