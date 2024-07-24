namespace Kama.ApiManagement.Core.Model;

public class ApiFirstServer
{
    public ApiFirstServer(Guid id)
    {
        Id = id;
        Date = DateTime.Now;
    }

    public Guid Id { get; private set; }

    public string ConnectionId { get; set; }

    public DateTime Date { get; private set; }

    public bool Expired => Date < DateTime.Now.AddSeconds(-2);

}