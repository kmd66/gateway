namespace Kama.ApiManagement.Core.Model;
public class Sso : Model
{
    public SsoEnum Type { get; set; }
    public string Url { get; set; }
    public string Key { get; set; }
    public string Hash { get; set; }
    public string Token { get; set; }
    public string AppName { get; set; }
    public string AppAbbreviation { get; set; }
    public string UserID { get; set; }
    public string UserHash { get; set; }
    public string CallBack { get; set; }
    public bool SmsLogin { get; set; }
    public bool GetType { get; set; }
    public List<Guid> AppIDs { get; set; }
    public Guid? ClientID { get; set; }
    public string ConnectionHubId { get; set; }
}