namespace Kama.ApiManagement.Core.Model;

public abstract class FileModel : Model
{
    public override string ToString() => FileName;

    public string FileName { get; set; }

    public string Comment { get; set; }

    public byte[] Data { get; set; }

    public string Base64 { get; set; }

}