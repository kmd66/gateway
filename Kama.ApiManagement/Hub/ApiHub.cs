using Kama.ApiManagement.Core.Service;
using Microsoft.AspNetCore.SignalR;

namespace Kama.ApiManagement;

public class ApiHub :  Hub, Core.Service.IApiHub
{
    //public static List<ApiServerDetail> Servers = new List<ApiServerDetail>();
    //public static List<ApiFirstServer> FirstServer = new List<ApiFirstServer>();
    //public static List<ApiServerIndex> ServerIndex = new List<ApiServerIndex>();

    public override Task OnConnectedAsync()
    {

        return base.OnConnectedAsync();
    }
    public override Task OnDisconnectedAsync(Exception exception)
    {
        var model = IApiHub.Servers.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
        if (model != null)
        {
            IApiHub.Servers.Remove(model);
            Helper.ApiRequest.ReConnect(model);
            //Clients.Client(Context.ConnectionId).SendAsync("ReConnect",true);
        }

        return base.OnDisconnectedAsync(exception);
    }

    public void AddService(ApiServerDetail model)
    {
        if (model != null && !string.IsNullOrEmpty(model.Url) && !string.IsNullOrEmpty(model.Name))
        {
            IApiHub.Servers = IApiHub.Servers.Where(x => x.Url != model.Url).ToList();
            model.ConnectionId = Context.ConnectionId;
            IApiHub.Servers.Add(model);
        }
    }

    public async Task GetFirstServer(Guid id)
    {
        var model = IApiHub.FirstServer.FirstOrDefault(x => x.Id == id && x.ConnectionId == null);
        if (model != null)
            model.ConnectionId = Context.ConnectionId;
    }

}
