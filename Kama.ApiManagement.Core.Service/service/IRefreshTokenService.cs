using Kama.AppCore;
using Kama.ApiManagement.Core.Model;

namespace Kama.ApiManagement.Core.Service;
public interface IRefreshTokenService : IService
{
    Task<Result<RefreshToken>> AddAsync(RefreshToken model);

    Task<Result<RefreshToken>> UpdateExpireDateAsync(@RefreshToken model);

}
