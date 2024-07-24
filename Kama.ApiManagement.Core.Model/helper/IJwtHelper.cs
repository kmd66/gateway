using System.Security.Claims;

namespace Kama.ApiManagement.Core.Service;

public interface IJwtHelper
{
    Model.TokenObject GetToken(List<Claim> claims, DateTime issuedDate, DateTime expireDate);
    string Code(List<Claim> claims, DateTime expires);
    dynamic Decode(string token);
}
