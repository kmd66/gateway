namespace Kama.ApiManagement.Core.Model;

public class TokenSwitchMode
{
    public Organization.Core.Model.User User { get; set; }
    public string SsoTicket { get; set; }
    public string NationalCode { get; set; }
    public Guid? MasterPasswordID { get; set; }
}