using Kama.AppCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kama.ApiManagement.Core;

public interface IApiHubServerUrl 
{
    void SetHostName(string serverName);
    void SetHostNameForApiClient(string serverName);
    Task<Result<string>> Get();
}
