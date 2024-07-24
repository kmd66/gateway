using Kama.ApiManagement.Core.Model;
using Kama.AppCore;

namespace Kama.ApiManagement.Core.DataSource
{
    public interface ISsoCacheDataSource : IDataSource
    {
        Task<Result<SsoCache>> AddAsync(SsoCache model);
        Task<Result<SsoCache>> GetAsync(string key);
        Task<Result> DeleteAsync(string key);
    }
}
