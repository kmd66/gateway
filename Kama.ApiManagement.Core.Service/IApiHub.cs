using Kama.ApiManagement.Core.Model;

namespace Kama.ApiManagement.Core.Service;

public interface IApiHub
{
    public static List<ApiServerDetail> Servers = new List<ApiServerDetail>();
    public static List<ApiFirstServer> FirstServer = new List<ApiFirstServer>();
    public static List<ApiServerIndex> ServerIndex = new List<ApiServerIndex>();
}
