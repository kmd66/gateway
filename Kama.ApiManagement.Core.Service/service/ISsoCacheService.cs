using Kama.ApiManagement.Core.Model;
using Kama.AppCore;

namespace Kama.ApiManagement.Core.Service;
public interface ISsoCacheService : IService
{
    Task<Result<SsoCache>> AddAsync(Guid ClientID, string connectionHubId, string userName, string ssoTicket, string hash);
    Task<Result<SsoCache>> CheckAsync(string SecurityStamp, string clientId);
    Task<Result> DeleteAsync(string SecurityStamp, string clientId);

}
