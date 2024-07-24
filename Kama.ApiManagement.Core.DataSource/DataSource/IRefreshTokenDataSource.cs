using Kama.ApiManagement.Core.Model;

namespace Kama.ApiManagement.Core.DataSource
{
    public interface IRefreshTokenDataSource : IDataSource
    {
        Task<AppCore.Result<RefreshToken>> AddAsync(RefreshToken model);

        Task<AppCore.Result<RefreshToken>> UpdateExpireDateAsync(RefreshToken model);

        Task<AppCore.Result<RefreshToken>> GetAsync(Guid id);

    }
}
