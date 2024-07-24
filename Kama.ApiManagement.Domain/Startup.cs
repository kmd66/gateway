
using Microsoft.Extensions.DependencyInjection;

namespace Kama.ApiManagement.Domain;

public class Startup
{

    public static Startup Instance => new Startup();

    public void ConfigureServices(IServiceCollection services)
    {

        ServiceFactory.ConfigureServices(services,
            interfaceNames: new string[] { "ICoustoumApiClient", "IService" },
            assemblyNames: new string[] { "Service", "Domain", "ApiClient" }
            );
    }

}
