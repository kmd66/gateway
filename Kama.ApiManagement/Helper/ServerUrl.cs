using Kama.ApiManagement.Core;
using Kama.ApiManagement.Core.Model;
using Kama.ApiManagement.Core.Service;
using Kama.AppCore.IOC;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Options;

namespace Kama.ApiManagement.Helper
{
    public class ApiHubServerUrl : IApiHubServerUrl
    {
        public ApiHubServerUrl(IOptions<AppSettings> appSettings,
            IHubContext<ApiHub> hub)
        {
            _serverType = appSettings.Value.ServerType;
            _hub = hub;
        }
        public void SetHostName(string serverName)
        {
            _serverName = serverName;
            //var hub = AppCore.IOC.IContainer.Instance.GetService<IHubContext<ApiHub>>();
            //var appSettings = AppCore.IOC.IContainer.Instance.GetService<IOptions<AppSettings>>();
            //_serverType = appSettings.Value.ServerType;
            //_hub = hub;
        }
        public void SetHostNameForApiClient(string serverName)
        {
            _serverType = ServerType.صف_بندی;
            _serverName = serverName;
        }

        private string _serverName;
        private ServerType _serverType;
        private List<ApiServerDetail> servers;
        private readonly IHubContext<ApiHub> _hub;

        public async Task<Result<string>> Get()
        {
            if (string.IsNullOrEmpty(_serverName))
                return Result<string>.Failure(code: 404, message: "Server Name Null");

            servers = IApiHub.Servers.Where(x => x.Name == _serverName).ToList();

            if (servers.Count == 0)
                return Result<string>.Failure(code: 404, message: "Server Count 0");

            if (servers.Count == 1)
                return Result<string>.Successful(data: servers.First().Url);

            if (_serverType == ServerType.آولین_سرور)
                return await GetFirstServerUrl();
            else
                return await GetIndexServerUrl();
        }
        private async Task<Result<string>> GetFirstServerUrl()
        {
            IApiHub.FirstServer = IApiHub.FirstServer.Where(x => !x.Expired).ToList();

            int i = 0;
            var id = Guid.NewGuid();
            IApiHub.FirstServer.Add(new ApiFirstServer(id));

            var list = IApiHub.Servers.Where(x => x.Name == _serverName).OrderBy(x => Guid.NewGuid()).Select(x => x.ConnectionId).ToList();
            if (list.Count > 0)
               await _hub.Clients.Clients(list).SendAsync("PingGroupServers", id);

            while (true)
            {
                if (i > 19)
                    break;

                var first = IApiHub.FirstServer.FirstOrDefault(x => x.Id == id && x.ConnectionId != null);
                if (first == null)
                {
                    await Task.Delay(100);
                    i++;
                }
                else
                {
                    RemoveFirstServer(id);
                    var server = IApiHub.Servers.FirstOrDefault(x => x.ConnectionId == first.ConnectionId);
                    if(server != null)
                        return Result<string>.Successful(data: server.Url);
                    else
                        return Result<string>.Failure(code: 404, message: "Not fond server");

                }
            }
            RemoveFirstServer(id);
            return Result<string>.Failure(code: 404, message: "Not responsive");
        }
        private void RemoveFirstServer(Guid id)
        {
            var first = IApiHub.FirstServer.FirstOrDefault(x => x.Id == id);
            if (first != null)
                IApiHub.FirstServer.Remove(first);

        }
        private async Task<Result<string>> GetIndexServerUrl()
        {
            var serverIndex = IApiHub.ServerIndex.FirstOrDefault(x=>x.Name == _serverName);
            if(serverIndex == null)
            {
                IApiHub.ServerIndex.Add(new ApiServerIndex { Name = _serverName , Index = 1});
                return Result<string>.Successful(data: servers[0].Url);
            }

            string url = "";

            serverIndex.Index++;

            if (serverIndex.Index +1 > servers.Count)
            {
                serverIndex.Index = 0;
                url = servers[serverIndex.Index].Url;
            }
            else
            {

                url = servers[serverIndex.Index].Url;
            }

            return Result<string>.Successful(data: url);
        }

        public static IApiHubServerUrl Instancea(string serverName)
        {
            throw new NotImplementedException();
        }
    }
}
