using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Kama.ApiManagement.ApiClient.Interface;

namespace Kama.ApiManagement.ApiClient
{
	public interface IApiManagementApiClient: Kama.Library.Helper.ApiClient.IApiClient
	{
	}

	public class ApiManagementApiClient : Kama.Library.Helper.ApiClient.ApiClient, IApiManagementApiClient
	{
		public ApiManagementApiClient(Microsoft.Extensions.Configuration.IConfiguration configuration,
			AppCore.IObjectSerializer objectSerializer,
			IHttpContextAccessor httpContextAccessor)
			: base(configuration, objectSerializer, httpContextAccessor)
		{
		
		}

		public override string Host
			=> _configuration["AppSettings:ApiManagementHost"];

	}

}

namespace Kama.ApiManagement.ApiClient.Interface
{
	public interface IService
	{
	}

	public interface IIssuedTokenService: IService
	{
		Task <Kama.AppCore.Result> Logout(Kama.ApiManagement.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
		Task <Kama.AppCore.Result> LogoutByRefreshTokenID(Kama.ApiManagement.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
		Task <Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.ApiManagement.Core.Model.ActiveToken>>> ActiveTokenByUser(Kama.ApiManagement.Core.Model.ActiveToken model, IDictionary<string, string> headers = null, int? timeOut = null);
		Task <Kama.AppCore.Result<System.Collections.Generic.Dictionary<System.String,System.String>>> ValidateToken(IDictionary<string, string> headers = null, int? timeOut = null);
	}

	public interface IQrService: IService
	{
		Task <Kama.AppCore.Result<Kama.ApiManagement.Core.Model.Qr>> SetCode(IDictionary<string, string> headers = null, int? timeOut = null);
		Task <Kama.AppCore.Result<Kama.ApiManagement.Core.Model.Qr>> CheckCode(Kama.ApiManagement.Core.Model.Qr model, IDictionary<string, string> headers = null, int? timeOut = null);
		Task <Kama.AppCore.Result<Kama.ApiManagement.Core.Model.Qr>> EditCode(Kama.ApiManagement.Core.Model.Qr model, IDictionary<string, string> headers = null, int? timeOut = null);
	}

	public interface IQueueService: IService
	{
		Task <Kama.AppCore.Result> PushMessage(Kama.ApiManagement.Core.Model.Sso model, IDictionary<string, string> headers = null, int? timeOut = null);
	}

	public interface ISsoService: IService
	{
		Task <Kama.AppCore.Result> CheckAuthorizationForSso(Kama.ApiManagement.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
		Task <Kama.AppCore.Result<Kama.ApiManagement.Core.Model.Client>> GetLoginUrl(Kama.ApiManagement.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null);
		Task <Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.ApiManagement.Core.Model.Sso>>> ListApplication(Kama.ApiManagement.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null);
		Task <Kama.AppCore.Result<Kama.ApiManagement.Core.Model.Sso>> CheckSmsLogin(Kama.ApiManagement.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null);
	}

	public interface ITokenService: IService
	{
		Task <Kama.AppCore.Result<System.String>> Get(Kama.ApiManagement.Core.Model.Token model, IDictionary<string, string> headers = null, int? timeOut = null);
		Task <Kama.AppCore.Result<System.String>> Refresh(Kama.ApiManagement.Core.Model.RefreshTokenVM model, IDictionary<string, string> headers = null, int? timeOut = null);
	}

}
namespace Kama.ApiManagement.ApiClient
{
	abstract class Service
	{
	}

	partial class IssuedTokenService : Interface.IIssuedTokenService
	{
		public IssuedTokenService(IApiManagementApiClient client)
		{
			_client = client;
		}

		readonly IApiManagementApiClient _client;

		public Task <Kama.AppCore.Result>  Logout(Kama.ApiManagement.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/IssuedToken/Logout";
			return _client.SendAsync(true, url, routeParamValues, headers , model, timeOut);
		}

		public Task <Kama.AppCore.Result>  LogoutByRefreshTokenID(Kama.ApiManagement.Core.Model.IssuedTokenListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/IssuedToken/LogoutByRefreshTokenID";
			return _client.SendAsync(true, url, routeParamValues, headers , model, timeOut);
		}

		public Task <Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.ApiManagement.Core.Model.ActiveToken>>>  ActiveTokenByUser(Kama.ApiManagement.Core.Model.ActiveToken model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/IssuedToken/ActiveTokenByUser";
			return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.ApiManagement.Core.Model.ActiveToken>>(true, url, routeParamValues, headers , model, timeOut);
		}

		public Task <Kama.AppCore.Result<System.Collections.Generic.Dictionary<System.String,System.String>>>  ValidateToken(IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{};
			const string url = "api/IssuedToken/ValidateToken";
			return _client.SendAsync<System.Collections.Generic.Dictionary<System.String,System.String>>(true, url, routeParamValues, headers , timeOut);
		}

	}

	partial class QrService : Interface.IQrService
	{
		public QrService(IApiManagementApiClient client)
		{
			_client = client;
		}

		readonly IApiManagementApiClient _client;

		public Task <Kama.AppCore.Result<Kama.ApiManagement.Core.Model.Qr>>  SetCode(IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{};
			const string url = "api/Qr/SetCode";
			return _client.SendAsync<iManagement.Core.Model.Qr>(true, url, routeParamValues, headers , timeOut);
		}

		public Task <Kama.AppCore.Result<Kama.ApiManagement.Core.Model.Qr>>  CheckCode(Kama.ApiManagement.Core.Model.Qr model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/Qr/CheckCode";
			return _client.SendAsync<iManagement.Core.Model.Qr>(true, url, routeParamValues, headers , model, timeOut);
		}

		public Task <Kama.AppCore.Result<Kama.ApiManagement.Core.Model.Qr>>  EditCode(Kama.ApiManagement.Core.Model.Qr model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/Qr/EditCode";
			return _client.SendAsync<iManagement.Core.Model.Qr>(true, url, routeParamValues, headers , model, timeOut);
		}

	}

	partial class QueueService : Interface.IQueueService
	{
		public QueueService(IApiManagementApiClient client)
		{
			_client = client;
		}

		readonly IApiManagementApiClient _client;

		public Task <Kama.AppCore.Result>  PushMessage(Kama.ApiManagement.Core.Model.Sso model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/Queue/PushMessage";
			return _client.SendAsync(true, url, routeParamValues, headers , model, timeOut);
		}

	}

	partial class SsoService : Interface.ISsoService
	{
		public SsoService(IApiManagementApiClient client)
		{
			_client = client;
		}

		readonly IApiManagementApiClient _client;

		public Task <Kama.AppCore.Result>  CheckAuthorizationForSso(Kama.ApiManagement.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/Sso/CheckAuthorizationForSso";
			return _client.SendAsync(true, url, routeParamValues, headers , model, timeOut);
		}

		public Task <Kama.AppCore.Result<Kama.ApiManagement.Core.Model.Client>>  GetLoginUrl(Kama.ApiManagement.Core.Model.ClientListVM model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/Sso/GetLoginUrl";
			return _client.SendAsync<iManagement.Core.Model.Client>(true, url, routeParamValues, headers , model, timeOut);
		}

		public Task <Kama.AppCore.Result<System.Collections.Generic.IEnumerable<Kama.ApiManagement.Core.Model.Sso>>>  ListApplication(Kama.ApiManagement.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/Sso/ListApplication";
			return _client.SendAsync<System.Collections.Generic.IEnumerable<Kama.ApiManagement.Core.Model.Sso>>(true, url, routeParamValues, headers , model, timeOut);
		}

		public Task <Kama.AppCore.Result<Kama.ApiManagement.Core.Model.Sso>>  CheckSmsLogin(Kama.ApiManagement.Core.Model.SsoVM model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/Sso/CheckSmsLogin";
			return _client.SendAsync<iManagement.Core.Model.Sso>(true, url, routeParamValues, headers , model, timeOut);
		}

	}

	partial class TokenService : Interface.ITokenService
	{
		public TokenService(IApiManagementApiClient client)
		{
			_client = client;
		}

		readonly IApiManagementApiClient _client;

		public Task <Kama.AppCore.Result<System.String>>  Get(Kama.ApiManagement.Core.Model.Token model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/Token/Get";
			return _client.SendAsync<System.String>(true, url, routeParamValues, headers , model, timeOut);
		}

		public Task <Kama.AppCore.Result<System.String>>  Refresh(Kama.ApiManagement.Core.Model.RefreshTokenVM model, IDictionary<string, string> headers = null, int? timeOut = null)
		{
			var routeParamValues = new Dictionary<string, string>{{"model", model == null ? null : model.ToString()}};
			const string url = "api/Token/Refresh";
			return _client.SendAsync<System.String>(true, url, routeParamValues, headers , model, timeOut);
		}

	}

}
