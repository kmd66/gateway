namespace Kama.ApiManagement.Core.Model;

public class RefreshTokenVM
{
    public Guid ID { get; set; }
    
    public Guid ClientId { get; set; }

    public string ClientSecret { get; set; }

    public string GrantType { get; set; }

}