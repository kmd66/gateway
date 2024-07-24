using Kama.AppCore.IOC;

namespace Kama.ApiManagement.Infrastructure.DAL;

public abstract class DataSource
{
    public DataSource()
    {
        var configuration = IContainer.Instance.GetService<Microsoft.Extensions.Configuration.IConfiguration>();
        var connectionString = configuration.GetConnectionString("ConnectionString");
        var connectionStringLog = configuration.GetConnectionString("ConnectionStringLog");
        _objSerializer = IContainer.Instance.GetService<IObjectSerializer>(); 
        _requestInfo = IContainer.Instance.GetService<Core.IRequestInfo>();

        atu = new ATU(connectionString);
        org = new ORG(connectionString);

        alg = new ALG(connectionStringLog);

    }

    protected readonly IObjectSerializer _objSerializer;
    protected readonly Core.IRequestInfo _requestInfo;
    protected readonly ATU atu;
    protected readonly ORG org;

    protected readonly ALG alg;

}
