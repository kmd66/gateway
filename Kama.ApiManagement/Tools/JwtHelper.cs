using Kama.AppCore.IOC;
using Kama.ApiManagement.Core.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Kama.ApiManagement.Tools;

public class JwtHelper : IJwtHelper
{
    public JwtHelper()
    {
        _configuration = IContainer.Instance.GetService<IConfiguration>();
        _objectSerializer = IContainer.Instance.GetService<IObjectSerializer>();
    }
    private readonly IConfiguration _configuration;
    private readonly IObjectSerializer _objectSerializer;

    public TokenObject GetToken(List<Claim> claims, DateTime issuedDate, DateTime expireDate)
    {
        var token = Code(claims, expireDate);

        var refreshToken = claims.FirstOrDefault(x => x.Type == "RefreshTokenID");
        var clientId = claims.FirstOrDefault(x => x.Type == "ClientID");

        var tokenObject = new TokenObject
        {
            expires = expireDate.ToString(),
            issued = issuedDate.ToString(),
            access_token = token,
            client_id = clientId.Value,
            token_type = "bearer",
            refresh_token = refreshToken.Value,
            username = "master"
        };

        return tokenObject;
    }
    public string Code(List<Claim> claims, DateTime expires)
    {
        var jwtSecret = new SymmetricSecurityKey(Encoding.Default.GetBytes(_configuration["Jwt:Secret"]));
        var ewtKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(_configuration["Jwt:EwtKey"]));

        claims.Add(new Claim(type: "ExpireDate", value: expires.ToString()));
        //var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_APISettings.SecretKey));
        var signingCredentials = new SigningCredentials(jwtSecret, SecurityAlgorithms.HmacSha256);
        var encryptionCredentials = new EncryptingCredentials(ewtKey, JwtConstants.DirectKeyUseAlg, SecurityAlgorithms.Aes256CbcHmacSha512);
        var tokenOptions = new JwtSecurityTokenHandler().CreateJwtSecurityToken(new SecurityTokenDescriptor()
        {
            Audience = "-",
            Issuer = "_",
            Subject = new ClaimsIdentity(claims),
            Expires = expires,
            EncryptingCredentials = encryptionCredentials,
            SigningCredentials = signingCredentials
        });
        return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
    }
    public dynamic Decode(string token)
    {
        var jwtSecret = new SymmetricSecurityKey(Encoding.Default.GetBytes(_configuration["Jwt:Secret"]));
        var ewtKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(_configuration["Jwt:EwtKey"]));

        JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

        tokenHandler.ValidateToken(token, new TokenValidationParameters
        {
            ValidIssuer = "-",
            ValidAudience = "-",
            ValidateIssuerSigningKey = false,
            ValidateLifetime = false,
            RequireExpirationTime = false,
            ValidateIssuer = false,
            ValidateAudience = false,
            IssuerSigningKey = jwtSecret,
            TokenDecryptionKey = ewtKey,
            ClockSkew = TimeSpan.Zero
        }, out SecurityToken validatedToken);
        var jwtToken = (JwtSecurityToken)validatedToken;

        return validatedToken;
    }
}