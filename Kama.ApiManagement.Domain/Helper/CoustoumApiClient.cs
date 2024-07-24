using Kama.ApiManagement.Core.DataSource;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net;

namespace Kama.ApiManagement.Domain.Helper;

public abstract class CoustoumApiClient
{
    public CoustoumApiClient(Microsoft.Extensions.Configuration.IConfiguration configuration,
        AppCore.IObjectSerializer objectSerializer,
        IHttpContextAccessor httpContextAccessor)
    {
        _configuration = configuration;
        _objectSerializer = objectSerializer;
        _httpContextAccessor = httpContextAccessor;
    }
    protected readonly IHttpContextAccessor _httpContextAccessor;
    protected readonly Microsoft.Extensions.Configuration.IConfiguration _configuration;
    protected readonly AppCore.IObjectSerializer _objectSerializer;

    public abstract string Host { get; }

    public virtual IDictionary<string, string> GetDefaultHeaders()
    {
        var headers = new Dictionary<string, string>();

        ///AppSettings.json info *** this info must seted in appsetting.json file
        var applicationId = _httpContextAccessor.HttpContext?.Request.Headers["ApplicationID"];
        if (!string.IsNullOrWhiteSpace(applicationId))
            headers.Add(Claims.ApplicationId, applicationId);

        var ClientID = _httpContextAccessor.HttpContext?.Request.Headers["ClientID"];
        if (!string.IsNullOrWhiteSpace(ClientID))
            headers.Add(Claims.ClientId, ClientID);

        var ApiKey = _configuration["AppSettings:ApiKey"];
        var ApiSecret = _configuration["AppSettings:ApiSecret"];
        if (!string.IsNullOrWhiteSpace(ApiKey) && !string.IsNullOrWhiteSpace(ApiSecret))
        {
            var hederApiKey = _httpContextAccessor.HttpContext?.Request.Headers[ApiKey];
            if (string.IsNullOrWhiteSpace(hederApiKey))
                headers.Add(ApiKey, ApiSecret);
        }

        var authorizationClaims = _httpContextAccessor.HttpContext?.Request.Headers["AuthorizationClaims"];
        if (!string.IsNullOrWhiteSpace(authorizationClaims))
            headers.Add("AuthorizationClaims", authorizationClaims);

        var OrganizationHostHeaders = _configuration["AppSettings:OrganizationHostHeaders"];
        if (OrganizationHostHeaders != null)
        {
            var items = OrganizationHostHeaders.Split(',')
                              .Select(e => { var segments = e.Split(':'); return new Tuple<string, string>(segments[0], segments[1]); });

            foreach (var item in items)
                headers.Add(item.Item1, item.Item2);
        }


        if (_httpContextAccessor.HttpContext != null)
        {
            string UserName = _httpContextAccessor.HttpContext.Request.Headers[Claims.UserName];
            if (!string.IsNullOrWhiteSpace(UserName))
                headers.Add(Claims.UserName, UserName);

            string NationalCode = _httpContextAccessor.HttpContext.Request.Headers[Claims.NationalCode];
            if (!string.IsNullOrWhiteSpace(NationalCode))
                headers.Add(Claims.NationalCode, NationalCode);

            string DepartmentId = _httpContextAccessor.HttpContext.Request.Headers[Claims.DepartmentId];
            if (!string.IsNullOrWhiteSpace(DepartmentId))
                headers.Add(Claims.DepartmentId, DepartmentId);

            string PositionId = _httpContextAccessor.HttpContext.Request.Headers[Claims.PositionId];
            if (!string.IsNullOrWhiteSpace(PositionId))
                headers.Add(Claims.PositionId, PositionId);

            string ProvinceId = _httpContextAccessor.HttpContext.Request.Headers[Claims.ProvinceId];
            if (!string.IsNullOrWhiteSpace(ProvinceId))
                headers.Add(Claims.ProvinceId, ProvinceId);

            string DepartmentType = _httpContextAccessor.HttpContext.Request.Headers[Claims.DepartmentType];
            if (!string.IsNullOrWhiteSpace(DepartmentType) && DepartmentType != "0")
                headers.Add(Claims.DepartmentType, DepartmentType);

            string UserType = _httpContextAccessor.HttpContext.Request.Headers[Claims.UserType];
            if (!string.IsNullOrWhiteSpace(UserType) && UserType != "0")
                headers.Add(Claims.UserType, UserType);

            string PositionType = _httpContextAccessor.HttpContext.Request.Headers[Claims.PositionType];
            if (!string.IsNullOrWhiteSpace(PositionType) && PositionType != "0")
                headers.Add(Claims.PositionType, PositionType);

            string PositionSubType = _httpContextAccessor.HttpContext.Request.Headers[Claims.PositionSubType];
            if (!string.IsNullOrWhiteSpace(PositionSubType) && PositionType != "0")
                headers.Add(Claims.PositionSubType, PositionSubType);

            string SsoTicket = _httpContextAccessor.HttpContext.Request.Headers[Claims.SsoTicket];
            if (!string.IsNullOrWhiteSpace(SsoTicket))
                headers.Add(Claims.SsoTicket, SsoTicket);

            string Authorization = _httpContextAccessor.HttpContext.Request.Headers[Claims.Authorization];
            if (!string.IsNullOrWhiteSpace(Authorization))
            {
                headers.Add(Claims.Authorization, Authorization);
                headers.Add(Claims.Token, Authorization?.Replace("Bearer ", ""));
            }

            string Password = _httpContextAccessor.HttpContext.Request.Headers[Claims.Password];
            if (!string.IsNullOrWhiteSpace(Password))
                headers.Add(Claims.Password, Password);

            string UserAgent = _httpContextAccessor.HttpContext.Request.Headers[Claims.UserAgent];
            if (!string.IsNullOrWhiteSpace(UserAgent))
                headers.Add(Claims.UserAgent, UserAgent);

            string MasterPasswordID = _httpContextAccessor.HttpContext.Request.Headers[Claims.MasterPasswordID];
            if (!string.IsNullOrWhiteSpace(MasterPasswordID))
                headers.Add(Claims.MasterPasswordID, MasterPasswordID);

            string RemoteIP = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress + ":" + _httpContextAccessor.HttpContext.Connection.RemotePort;
            if (!string.IsNullOrWhiteSpace(RemoteIP))
                headers.Add(Claims.RemoteIP, RemoteIP);

            string AppUrl = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}:{_httpContextAccessor.HttpContext.Request.Host.Port ?? 80}";
            if (!string.IsNullOrWhiteSpace(AppUrl))
                headers.Add(Claims.AppURL, AppUrl);
        }

        return headers;
    }

    protected string ClearRouteParameterType(string url)
    {
        url = url.TrimEnd('/') + "/";
        const string A = "/{", B = "}/";
        int i = 0;
        do
        {
            i = url.IndexOf(A, i);
            var j = i >= 0 ? url.IndexOf(B, i) : -1;
            if (i >= 0 && j > i)
            {
                var segment = url.Substring(i + 2, j - i - 2);
                var paramName = segment.Split(':').First();
                url = url.Replace(segment, paramName);
                i = i + 1;
            }
            else
                i = url.Length;
        }
        while (i < url.Length);

        return url.TrimEnd('/');
    }

    protected string SetRouteParamterValue(string url, IDictionary<string, string> parameters)
    {
        url = ClearRouteParameterType(url);

        foreach (var item in parameters)
            url = url.Replace("{" + item.Key + "}", item.Value);

        return url;
    }

    protected void SetHeaders(System.Net.Http.HttpClient client, IDictionary<string, string> headers)
    {
        if (headers == null || !headers.Any())
            return;

        foreach (var item in headers)
        {
            if (!string.IsNullOrWhiteSpace(item.Key))
                client.DefaultRequestHeaders.Add(item.Key, item.Value);
        }
    }

    protected async Task<TResult> Post<TResult>(Func<bool, HttpStatusCode, string, TResult> createResult, string path, IDictionary<string, string> headers = null, object data = null, int? timeOut = null)
    {
        HttpResponseMessage response = null;
        try
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Host);

                client.DefaultRequestHeaders.Clear();
                SetHeaders(client, GetDefaultHeaders());
                SetHeaders(client, headers);

                using (var request = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Post, path))
                {
                    request.Content = new StringContent(_objectSerializer.Serialize(data ?? ""));
                    request.Content.Headers.Clear();
                    request.Content.Headers.Add("Content-Type", "application/json");
                    try
                    {
                        if (timeOut.HasValue && timeOut != 0)
                            client.Timeout = new TimeSpan(0, timeOut.Value, 0);
                        response = await client.SendAsync(request);
                        var responseContent = await response.Content.ReadAsStringAsync();
                        response.Dispose();
                        //TResult result = default(TResult);
                        if (response.IsSuccessStatusCode)
                            return _objectSerializer.Deserialize<TResult>(responseContent);
                        else
                            return createResult(false, response?.StatusCode ?? HttpStatusCode.NoContent, responseContent);
                    }
                    catch (Exception e)
                    {
                        response = new HttpResponseMessage(statusCode: System.Net.HttpStatusCode.InternalServerError);
                        // Logger?.Error(e.Message + "\n" + e.InnerException?.Message);
                        return createResult(false, response?.StatusCode ?? HttpStatusCode.NoContent, e.Message);
                    }
                }
            }
        }
        catch (Exception e)
        {
            // Logger?.Error(e.Message + "\n" + e.InnerException?.Message);
            //return Result<TResult>.Failure(code: (int)response.StatusCode, message: e.Message).Data;

            return createResult(false, response?.StatusCode ?? HttpStatusCode.NoContent, e.Message);
        }
    }

    protected async Task<TResult> Get<TResult>(Func<bool, HttpStatusCode, string, TResult> createResult, string path, IDictionary<string, string> headers = null, int? timeOut = null)
    {
        HttpResponseMessage response = null;

        try
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Host);

                client.DefaultRequestHeaders.Clear();
                SetHeaders(client, GetDefaultHeaders());
                SetHeaders(client, headers);

                if (timeOut.HasValue && timeOut != 0)
                    client.Timeout = new TimeSpan(0, timeOut.Value, 0);
                response = await client.GetAsync(path);
                var responseContent = await response.Content.ReadAsStringAsync();
                response.Dispose();
                if (response.IsSuccessStatusCode)
                    return _objectSerializer.Deserialize<TResult>(responseContent);
                else
                    return createResult(false, response?.StatusCode ?? HttpStatusCode.NoContent, responseContent);
            }
        }
        catch (Exception e)
        {
            // Logger?.Error(e.Message + "\n" + e.InnerException?.Message);

            return createResult(false, response?.StatusCode ?? HttpStatusCode.NoContent, e.Message);
        }
    }

    public Task<Result> SendAsync(bool httpPost, string uri, IDictionary<string, string> routeParameterValues = null, IDictionary<string, string> headers = null, object body = null, int? timeOut = null)
    {
        uri = SetRouteParamterValue(uri, routeParameterValues);

        return httpPost ? Post(createResult: (success, status, message) => Result.Set(success: success, code: (int)status, message: message), path: uri, headers: headers, data: body, timeOut: timeOut)
                        : Get(createResult: (success, status, message) => Result.Set(success: success, code: (int)status, message: message), path: uri, timeOut: timeOut);
    }

    public Task<Result<TResult>> SendAsync<TResult>(bool httpPost, string uri, IDictionary<string, string> routeParameterValues = null, IDictionary<string, string> headers = null, object body = null, int? timeOut = null)
    {
        uri = SetRouteParamterValue(uri, routeParameterValues);

        return httpPost ? Post(createResult: (success, status, message) => Result<TResult>.Set(success: success, code: (int)status, message: message), path: uri, headers: headers, data: body, timeOut: timeOut)
                        : Get(createResult: (success, status, message) => Result<TResult>.Set(success: success, code: (int)status, message: message), path: uri, timeOut: timeOut);
    }

}
