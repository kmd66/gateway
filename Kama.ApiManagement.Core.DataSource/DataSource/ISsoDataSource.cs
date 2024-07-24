using Kama.ApiManagement.Core.Model;
using Kama.AppCore;

namespace Kama.ApiManagement.Core.DataSource
{
    public interface ISsoDataSource : IDataSource
    {
        Task<Result<Sso>> CheckUserAsync(SsoVM model);
        Task<Result<IEnumerable<Sso>>> ListApplicationAsync(SsoVM model);
        Task<Result<Sso>> CheckSmsLoginAsync(SsoVM model);
        Task<Result> EditListAppAsync(Sso model);
    }
}
