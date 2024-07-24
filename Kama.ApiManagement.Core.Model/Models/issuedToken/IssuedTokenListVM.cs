namespace Kama.ApiManagement.Core.Model;

public class IssuedTokenListVM : ListVM
{
    public Guid? UserID { get; set; }

    public Guid? ClientID { get; set; }

    public Guid? RefreshTokenID { get; set; }

    public DateTime IssuedDate { get; set; }

    public DateTime ExpireDate { get; set; }

    public string Token { get; set; }

    public bool UndoOnlyApp { get; set; }
}