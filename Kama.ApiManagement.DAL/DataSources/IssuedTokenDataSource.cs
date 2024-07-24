using Kama.Library.Helper.Security;

namespace Kama.ApiManagement.Infrastructure.DAL.DataSources;


public class IssuedTokenDataSource : DataSource, IIssuedTokenDataSource
{
    public IssuedTokenDataSource()
         : base()
    {
    }

    public async Task<Result<IssuedToken>> AddIssuedTokenAsync(IssuedToken model)
    {
        try
        {
            var result = (await atu.AddIssuedTokenAsync(
                _id: model.ID,
                _userID: model.UserID,
                _expireDate: model.ExpireDate,
                _issuedDate: model.IssuedDate,
                _clientID: model.ClientID,
                _refreshTokenID: model.RefreshTokenID,
                _token: model.Token
                )).ToActionResult();

            if (result.Success)
                return Result<IssuedToken>.Successful(data: model);

            return Result<IssuedToken>.Failure(message: result.Message);
        }
        catch (Exception e)
        {
            throw;
        }
    }
    public async Task<Result<IssuedToken>> GetIssuedTokenByTokenAsync(string token)
    {
        try
        {
            var result = (await atu.GetIssuedTokenByTokenAsync(
                _token: token.HashText()
                )).ToActionResult<IssuedToken>();

            return result;
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public async Task<AppCore.Result> LogoutAsync(IssuedTokenListVM model)
    {
        try
        {
            var result = await atu.LogoutAsync(
                _token: model.Token.HashText(),
                _undoOnlyApp: model.UndoOnlyApp
            );

            return result.ToActionResult();
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public async Task<AppCore.Result> LogoutByRefreshTokenIDAsync(IssuedTokenListVM model)
    {
        try
        {
            var result = await atu.LogoutByRefreshTokenIDAsync(
                _refreshTokenID: model.RefreshTokenID,
                _userID: _requestInfo.UserId,
                _undoOnlyApp: model.UndoOnlyApp
            );

            return result.ToActionResult();
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public async Task<AppCore.Result<IEnumerable<ActiveTokenItems>>> ActiveTokenByUserAsync()
    {
        try
        {
            var result = await atu.ActiveTokenAsync(
                _userID: _requestInfo.UserId
            );

            return result.ToListActionResult<ActiveTokenItems>();
        }
        catch (Exception e)
        {
            throw;
        }
    }
}