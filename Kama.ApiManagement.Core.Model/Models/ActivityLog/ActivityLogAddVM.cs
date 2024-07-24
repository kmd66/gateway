namespace Kama.ApiManagement.Core.Model;

public class ActivityLogAddVM : Model
{
    public Guid ActionID { get; set; }

    public Guid? PositionID { get; set; }

    public Guid? UserID { get; set; }

    public string UserIP { get; set; }

    public Guid? ObjectID { get; set; }

    public ResponseStatus Success { get; set; }

    public int Duration { get; set; }

    public string OSVersion { get; set; }

    public BrowserType Browser { get; set; }

    public string BrowserVersion { get; set; }

    public DeviceType DeviceType { get; set; }

    public string UserName { get; set; }

    public CallType CallType { get; set; }

    public Guid? ClientID { get; set; }

    public string ControllerName { get; set; }

    public string ControllerTitle { get; set; }

    public string ActionName { get; set; }

    public string ActionTitle { get; set; }

    public Guid? ApplicationID { get; set; }

    public OperatingSystemType OS { get; set; }

    public object Object { get; set; }

    public DateTime CreationDate { get; set; }




    public Guid ControllerID { get; set; }
}
public class ActivityLogAddRedis
{
    public ActivityLogAddRedis()
    {
    }
    public ActivityLogAddRedis(ActivityLogAddVM activityLogAddVM)
    {
        ID = activityLogAddVM.ID;
        UserIP = activityLogAddVM.UserIP;
        ControllerID = activityLogAddVM.ControllerID;
        ActionID = activityLogAddVM.ActionID;
        ApplicationID = activityLogAddVM.ApplicationID;
        CreationDate = activityLogAddVM.CreationDate;
    }
    public Guid ID { get; set; }

    public string UserIP { get; set; }

    public Guid ControllerID { get; set; }

    public Guid ActionID { get; set; }

    public Guid? ApplicationID { get; set; }

    public DateTime CreationDate { get; set; }

    public int Count { get; set; }

}
