namespace Kama.ApiManagement.Core.Model;

public class Token
{
    public Guid ClientId { get; set; }

    public string ClientSecret { get; set; }

    public string GrantType { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public LoginType LoginType { get; set; }

    public string CellPhone { get; set; }

    public string Email { get; set; }

    public string SecurityStamp { get; set; }
}