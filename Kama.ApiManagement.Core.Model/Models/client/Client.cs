namespace Kama.ApiManagement.Core.Model;

public class Client
{
	public Guid ApplicationID { get; set; }
	public String ApplicationName { get; set; }
	public String ApplicationCode { get; set; }
	public Boolean ApplicationEnabled { get; set; }
	public String Name { get; set; }
	public String Abbreviation { get; set; }
	public String Secret { get; set; }
	public ClientType Type { get; set; }
	public Boolean Enabled { get; set; }
	public Boolean SsoState { get; set; }
	public Int32 RefreshTokenLifeTime { get; set; }
	public String AllowedOrigin { get; set; }
	public String Url { get; set; }
	public String UserID { get; set; }
	public String UserHash { get; set; }
	public String CallBack { get; set; }
	public Guid ID { get; set; }
	public DateTime CreationDate { get; set; }
	public Int32 Order { get; set; }
	public String Hash { get; set; }
}