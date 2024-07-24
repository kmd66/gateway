namespace Kama.ApiManagement.Core.Model;

public class Model
{
    public Guid ID { get; set; }

    public bool IsNew() => ID == Guid.Empty;

    public DateTime CreationDate { get; set; }

    public int Order { get; set; }

    public string Hash { get; set; }
}