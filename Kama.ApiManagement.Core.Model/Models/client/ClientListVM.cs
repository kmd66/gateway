namespace Kama.ApiManagement.Core.Model;

public class ClientListVM
{
	public Guid ApplicationID { get; set; }
	public String Name { get; set; }
	public String UserID { get; set; }
	public String UserHash { get; set; }
	public String CallBack { get; set; }
	public SsoEnum Type { get; set; }
	public String Key { get; set; }
	public String Abbreviation { get; set; }
	public EnableState Enabled { get; set; }
	public ClientType TypeClient { get; set; }
	public String ConnectionHubId { get; set; }
	public Guid ID { get; set; }
	public DateTime CreationDate { get; set; }
	public Int32 Order { get; set; }
	public String Hash { get; set; }
}