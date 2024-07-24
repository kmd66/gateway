namespace Kama.ApiManagement.Core.Model;

public class SsoCache
{
    public Guid ID { get; set; }
    public Guid? MasterPassword { get; set; }
    public string Key { get; set; }
    public string SsoTicket { get; set; }
    public string Hash { get; set; }
    public string UserName { get; set; }
    public string UserHash { get; set; }
    public DateTime Date { get; set; }
    public DateTime ExpireDate { get; set; }
}