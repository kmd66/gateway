using Kama.ApiManagement.Core.Service;
using Microsoft.Extensions.Configuration;

namespace Kama.ApiManagement;

[Route("api/[controller]")]
public class TokenController : BaseApiController
{
    public TokenController(
        ITokenService service,
        IConfiguration configuration,
        IJwtHelper jwtHelper
        )
    {
        _service = service;
        _configuration = configuration;
        _jwtHelper = jwtHelper;
    }

    private readonly ITokenService _service;
    private readonly IConfiguration _configuration;
    private readonly IJwtHelper _jwtHelper;
    //private readonly AuthOrgAPI.IUserAPI _userAPI;

    [AllowAnonymous, HttpPost, Route("Get")]
    public async Task<Result<string>> Get([FromBody] Token model)
    {
        var token = await _service.GetAsync(model);
        if (!token.Success)
           return Result<string>.Failure(message: token.Message);

        return Result<string>.Successful(data: Newtonsoft.Json.JsonConvert.SerializeObject(token.Data));
    }

    [AllowAnonymous, HttpPost, Route("Refresh")]
    public async Task<Result<string>> Refresh([FromBody] RefreshTokenVM model)
    {
        var token = await _service.RefreshAsync(model);
        if (!token.Success)
            return Result<string>.Failure(message: token.Message,code: token.Code);

        return Result<string>.Successful(data: Newtonsoft.Json.JsonConvert.SerializeObject(token.Data));
    }

    //[HttpPost, Route("login")]
    //public async Task<Result<dynamic>> Login()
    //{
    //    //var td = await _userAPI.Get("master");
    //    var identity = HttpContext.User.Identity as ClaimsIdentity;
    //    if (identity != null)
    //    {
    //        IEnumerable<Claim> claims = identity.Claims;

    //    }
    //    var t = await login();
    //    return Result<dynamic>.Successful(data: t);

    //}
    //private async Task<IActionResult> login()
    //{
    //    var authClaims = new List<Claim>
    //            {
    //                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
    //                new Claim("Expires", DateTime.Now.ToString()),
    //                new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString())
    //            };


    //    var accessTokenExpireTimeSpan = int.Parse(_configuration["AppSettings:AccessTokenExpireTimeSpan"]);
    //    var token = _jwtHelper.Code(authClaims, DateTime.Now.AddSeconds(accessTokenExpireTimeSpan));
    //    var jwtSecurityToken = new JwtSecurityTokenHandler().ReadToken(token);
    //    var f = (_jwtHelper.Decode(token) as JwtSecurityToken).Claims;
    //    DateTime enteredDate = DateTime.Parse(f.First(x=>x.Type == "Expires").Value);

    //    return Ok(_jwtHelper.GetToken(authClaims, DateTime.Now, DateTime.Now));
    //}

}

