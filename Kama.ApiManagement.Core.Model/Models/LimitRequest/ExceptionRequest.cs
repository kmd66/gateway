namespace Kama.ApiManagement.Core.Model;

public class ExceptionRequest
{
    public int Daily { get; set; }

    public int Minutely { get; set; }

    public int Hourly { get; set; }

    public string Action { get; set; }

}
