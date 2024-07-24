namespace Kama.ApiManagement.Core.Model;
public class ExcludedAction
{
    public Guid ApplicationID { get; set; }
    public string ApplicationName { get; set; }
    public string ActionName { get; set; }
    public string ControllerName { get; set; }
}
