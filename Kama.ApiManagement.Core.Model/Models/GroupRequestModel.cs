namespace Kama.ApiManagement.Core.Model;

public class GroupRequest
{
    public List<GroupRequestModel> Models { get; set; }
}
public class GroupRequestModel
{
    public string Url { get; set; }
    public dynamic Model { get; set; }
}