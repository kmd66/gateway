using Kama.ApiManagement.Core.Model;
using Kama.AppCore;

namespace Kama.ApiManagement.Core.Service;

public interface ISsoService : IService
{
    Task<Result<IEnumerable<Sso>>> ListApplicationAsync(SsoVM model);
    Task<Result<Sso>> CheckSmsLoginAsync(SsoVM model);
    Task<Result> EditListAppAsync(Sso model);
}