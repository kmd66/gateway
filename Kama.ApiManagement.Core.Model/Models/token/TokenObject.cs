namespace Kama.ApiManagement.Core.Model;

public class TokenObject
{
   public string expires { get; set; }
   public string issued { get; set; }
   public string access_token { get; set; }
   public string client_id { get; set; }
   public string token_type { get; set; }
   public string refresh_token { get; set; }
    public string username { get; set; }
}