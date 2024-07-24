using Kama.Library.Helper;
using Microsoft.Extensions.DependencyInjection;

namespace Kama.ApiManagement.Infrastructure.DAL;

public class Startup
{
	public static Startup Instance => new Startup();

    public void ConfigureServices(IServiceCollection services)
    {
        ServiceFactory.ConfigureServices(services,
            interfaceNames: new string[] { "IDataSource" },
            assemblyNames: new string[] { "Infrastructure.DAL" }
            );
    }
}
