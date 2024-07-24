namespace Kama.ApiManagement.Core.Model;

public class AppSettings
{
    public DeploymentMode DeploymentMode { get; set; }

    public Guid ApplicationID { get; set; }

    public string OrganizationHost { get; set; }

    public double AccessTokenExpireTimeSpan { get; set; }

    public double CacheMinute { get; set; }

    public string ApiKey { get; set; }

    public string ApiSecret { get; set; }

    public ServerType ServerType { get; set; }

}
