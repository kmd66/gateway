namespace Kama.ApiManagement.Core.Model;

public class SsoVM : ListVM
{
    public SsoEnum Type { get; set; }
    public string UserID { get; set; }
    public string UserHash { get; set; }
    public string CallBack { get; set; }
    public string Key { get; set; }
    public Guid? ApplicationID { get; set; }
    public Guid? ClientID { get; set; }
    public string ConnectionHubId { get; set; }
}