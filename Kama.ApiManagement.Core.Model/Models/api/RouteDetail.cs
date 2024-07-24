using System.Runtime.InteropServices;

namespace Kama.ApiManagement.Core.Model;

public class RouteDetail
{
    public RouteDetail(dynamic d)
    {
        dynamic r = d.RouteValues;
        ActionPath = d.Path;

        ServerName = r["servername"];
        Url = "";

        for (int i = 1; i < 10; i++)
        {
            var part = r[$"r{i}"];
            if (!string.IsNullOrEmpty(part?.Replace(" ", "")))
                Url += $"{part}/";
            else
                break;
        }

        //ApiVersion = r["apiversion"];
        //if (!string.IsNullOrEmpty(ApiVersion))
        //    Url += $"{ApiVersion}/";

        //ControllerName = r["controllername"];
        //if (!string.IsNullOrEmpty(ControllerName))
        //    Url += $"{ControllerName}/";

        //ActionName = r["actionname"];
        //if (!string.IsNullOrEmpty(ActionName))
        //    Url += $"{ActionName}/";

        //Id = r["id"];
        //if (!string.IsNullOrEmpty(Id?.Replace(" ", "")))
        //{
        //    Url += $"{Id}/";
        //}
    }
    public RouteDetail(string d)
    {
        var r = d.Split('/');

        if (r.Length < 1)
            return;

        ActionPath = d;

        ServerName = r[0];
        Url = "";

        for (int i = 1; i < r.Length; i++)
        {
            var part = r[i];
            if (!string.IsNullOrEmpty(part?.Replace(" ", "")))
                Url += $"{part}/";
            else
                break;
        }

        //ApiVersion = r["apiversion"];
        //if (!string.IsNullOrEmpty(ApiVersion))
        //    Url += $"{ApiVersion}/";

        //ControllerName = r["controllername"];
        //if (!string.IsNullOrEmpty(ControllerName))
        //    Url += $"{ControllerName}/";

        //ActionName = r["actionname"];
        //if (!string.IsNullOrEmpty(ActionName))
        //    Url += $"{ActionName}/";

        //Id = r["id"];
        //if (!string.IsNullOrEmpty(Id?.Replace(" ", "")))
        //{
        //    Url += $"{Id}/";
        //}
    }

    public RouteDetail()
    {
    }

    public string ActionPath { get; set; }

    public string ServerName { get; set; }

    public string Api { get; set; }

    public string ApiVersion { get; set; }

    public string ControllerName { get; set; }

    public string ActionName { get; set; }

    public string Id { get; set; }

    public string Url { get; set; }

}