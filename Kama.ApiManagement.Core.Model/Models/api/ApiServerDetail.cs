namespace Kama.ApiManagement.Core.Model;

public class ApiServerDetail
{
    public string ConnectionId { get; set; }

    public string Name { get; set; }

    public string Url { get; set; }

    public string ReconnectingUrl { get; set; }

    public Guid ApplicationID { get; set; }

}