namespace Kama.ApiManagement.Core.Model;
public class ExcludedActionListVM : ListVM
{
    public Guid? ApplicationID { get; set; }

    public string ControllerName { get; set; }

    public string ActionName { get; set; }

}


