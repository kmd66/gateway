using Kama.ApiManagement.Core.Service;

namespace Kama.ApiManagement;

[Route("api/[controller]")]
public class IssuedTokenController : BaseApiController
{
    public IssuedTokenController(IIssuedTokenService service)
    {
        _service = service;
    }

    private readonly IIssuedTokenService _service;

    [AllowAnonymous]
    [HttpPost, Route("Logout")]
    public Task<AppCore.Result> Logout([FromBody] IssuedTokenListVM model)
        => _service.LogoutAsync(model);

    [HttpPost, Route("LogoutByRefreshTokenID")]
    public Task<AppCore.Result> LogoutByRefreshTokenID([FromBody] IssuedTokenListVM model)
        => _service.LogoutByRefreshTokenIDAsync(model);

    [HttpPost, Route("ActiveTokenByUser")]
    public Task<AppCore.Result<IEnumerable<ActiveToken>>> ActiveTokenByUser([FromBody] ActiveToken model)
        => _service.ActiveTokenByUserAsync(model);

    [HttpPost, Route("ValidateToken")]
    public Task<AppCore.Result<Dictionary<string, string>>> ValidateToken()
        => _service.ValidateTokenAsync();

}
