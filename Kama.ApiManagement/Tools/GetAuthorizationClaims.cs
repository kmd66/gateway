using Kama.ApiManagement.Core.Service;
using Kama.AppCore.IOC;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;

namespace Kama.ApiManagement.Tools;

public class GetAuthorizationClaims
{

    private static string ApiKey;
    private static string ApiSecret;

    public static void SetProperty(Microsoft.Extensions.Configuration.IConfiguration configuration)
    {
        ApiKey = configuration["AppSettings:ApiKey"];
        ApiSecret = configuration["AppSettings:ApiSecret"];
    }

    private readonly RequestDelegate _next;

    public GetAuthorizationClaims(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        if (context.Request.Headers.ContainsKey("AuthorizationClaims"))
        {
            if (!context.Request.Headers.ContainsKey(ApiKey) || context.Request.Headers[ApiKey] != ApiSecret)
                context.Request.Headers.Remove("AuthorizationClaims");
        }
        string authHeader = context.Request.Headers["Authorization"];
        if (authHeader != null && !context.Request.Headers.ContainsKey("AuthorizationClaims"))
        {
            try
            {
                authHeader = authHeader.Replace("Bearer ", "");
                var _issuedTokenService = IContainer.Instance.GetService<IIssuedTokenService>();
                var issuedToken = await _issuedTokenService.GetIssuedTokenByTokenAsync(authHeader);
                if (issuedToken.Success && issuedToken.Data != null)
                {
                    var claims = getClaims(context, authHeader);
                    if (claims != null)
                        addHeaders(context, claims);
                }
            }
            catch(Exception ex) 
            {
            }
        }


        if (_next != null)
            await _next.Invoke(context);
    }

    private List<System.Security.Claims.Claim> getClaims(HttpContext context, string authHeader)
    {
        List<System.Security.Claims.Claim> claims;
        var _jwtHelper = IContainer.Instance.GetService<IJwtHelper>();
        var jsonToken = _jwtHelper.Decode(authHeader) as JwtSecurityToken;
        claims = jsonToken.Claims.ToList();

        var expireDate = DateTime.Parse(claims.First(x => x.Type == "ExpireDate").Value);
        if (expireDate < DateTime.Now)
            return null;

        return claims;
    }

    private void addHeaders(HttpContext context, List<System.Security.Claims.Claim> claims)
    {
        Dictionary<string, string> d = new Dictionary<string, string>();
        foreach (var claim in claims)
            d.Add(claim.Type.ToString(), claim.Value.ToString());
        context.Request.Headers.Add("AuthorizationClaims", Newtonsoft.Json.JsonConvert.SerializeObject(d));
    }
}