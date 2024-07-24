namespace Kama.ApiManagement.Core.Model;

public class LimitationRequest
{
    public bool Enabled { get; set; }

    public int Daily { get; set; }

    public int Minutely { get; set; }

    public int Hourly { get; set; }

    public List<string> IgnoreIp { get; set; }

    public List<ExceptionRequest> Exceptions { get; set; }

}
