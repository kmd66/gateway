namespace Kama.ApiManagement.Core.Model;

public class ActiveToken
{
    public string SsoTicket { get; set; }

    public List<ActiveTokenItems> Items { get; set; }
}
public class ActiveTokenItems : Model
{
    public string SsoTicket { get; set; }

    public int Total { get; set; }

    public Guid UserID { get; set; }

    public DateTime IssuedDate { get; set; }

    public DateTime ExpireDate { get; set; }

    public bool Expired => DateTime.Now > ExpireDate;

    public Int16 OS { get; set; }

    public string OSVersion { get; set; }

    public Int16 Browser { get; set; }

    public string BrowserVersion { get; set; }

    public Int16 DeviceType { get; set; }

    public Guid ApplicationID { get; set; }
    public string ApplicationName { get; set; }
}