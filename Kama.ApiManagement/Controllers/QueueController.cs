using Kama.ApiManagement.Core.Service;
using Kama.AppCore.IOC;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace Kama.ApiManagement;

[Route("api/[controller]")]
public class QueueController : BaseApiController
{
    private static int ssoLogoutCacheInMinutes = 100;
    private static string _hostName;
    private static string _userName;
    private static string _password; 
    private static int _port = 5672;

    ConnectionFactory factory;

    public QueueController()
    {
        if (string.IsNullOrEmpty(_hostName))
        {
            var _configuration = IContainer.Instance.GetService<IConfiguration>();
            _hostName = _configuration["RabbitMQ:Host"];
            _userName = _configuration["RabbitMQ:UserName"];
            _password = _configuration["RabbitMQ:Password"];
        }
        factory = new ConnectionFactory()
        {
            HostName = _hostName,
            UserName = _userName,
            Password = _password,
            VirtualHost = "/",
            Port = _port,
        };
    }

    [AllowAnonymous]
    [HttpPost, Route("PushMessage")]
    public async Task<AppCore.Result> PushMessage(Sso model)
    {
        //model.ClientID = null;
        if (model.ClientID == Guid.Empty || model.ClientID == null)
            _PublishMessage(model);
        else
            _ConsumerMessage(model);

        return AppCore.Result.Successful();
    }

    private void _PublishMessage(Sso model)
    {
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.ExchangeDeclare("pubsub", "fanout");
            var body = System.Text.Encoding.UTF8.GetBytes(_jsonObject(model));
            channel.BasicPublish("pubsub", string.Empty, null, body);
        }
    }

    private void _ConsumerMessage(Sso model)
    {
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.ExchangeDeclare(model.ClientID.ToString().ToUpper(), "fanout");
            var body = System.Text.Encoding.UTF8.GetBytes(_jsonObject(model));
            channel.BasicPublish(model.ClientID.ToString().ToUpper(), string.Empty, null, body);
        }
    }
    private void _ConsumerMessage2(Sso model)
    {
        var json = _jsonObject(model);
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.QueueDeclare(
                queue: model.ClientID.ToString().ToUpper(),
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null
                );
            var body = System.Text.Encoding.UTF8.GetBytes(json);

            channel.BasicPublish(
                exchange: "",
                routingKey: model.ClientID.ToString().ToUpper(),
                basicProperties: null,
                body: body
                );
        }
    }
    private string _jsonObject(Sso model)
    {
        if (model.Type == SsoEnum.Logout)
        {
            var obj = new { Type = model.Type, Key = model.Key, ssoLogoutCacheInMinutes = ssoLogoutCacheInMinutes };
            return JsonConvert.SerializeObject(obj);
        }
        return JsonConvert.SerializeObject(model);
    }
}
