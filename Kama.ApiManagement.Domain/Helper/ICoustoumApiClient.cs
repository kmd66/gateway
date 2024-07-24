using Kama.ApiManagement.Core.DataSource;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net;

namespace Kama.ApiManagement.Domain.Helper;

public interface ICoustoumApiClient
{
    string Host { get; }

    IDictionary<string, string> GetDefaultHeaders();

    Task<Result> SendAsync(bool httpPost, string uri, IDictionary<string, string> routeParameterValues = null, IDictionary<string, string> headers = null, object body = null, int? timeOut = null);

    Task<Result<TResult>> SendAsync<TResult>(bool httpPost, string uri, IDictionary<string, string> routeParameterValues = null, IDictionary<string, string> headers = null, object body = null, int? timeOut = null);

}
