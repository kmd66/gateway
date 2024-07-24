using Kama.ApiManagement.Core.Model;

namespace Kama.ApiManagement.Core.DataSource
{
    public interface IIssuedTokenDataSource : IDataSource
    {
        Task<AppCore.Result<IssuedToken>> AddIssuedTokenAsync(Model.IssuedToken model);
        Task<AppCore.Result<IssuedToken>> GetIssuedTokenByTokenAsync(string token);

        Task<AppCore.Result> LogoutAsync(Model.IssuedTokenListVM model);
        Task<AppCore.Result> LogoutByRefreshTokenIDAsync(Model.IssuedTokenListVM model);
        Task<AppCore.Result<IEnumerable<Model.ActiveTokenItems>>> ActiveTokenByUserAsync();
    }
}
