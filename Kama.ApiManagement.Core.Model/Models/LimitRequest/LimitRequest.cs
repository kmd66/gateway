namespace Kama.ApiManagement.Core.Model;

public class LimitRequest
{
    public int Daily { get; set; }

    public int Minutely { get; set; }

    public int Hourly { get; set; }

}
