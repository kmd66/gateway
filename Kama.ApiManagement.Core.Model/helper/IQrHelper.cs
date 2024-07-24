using Kama.ApiManagement.Core.Model;
using System.Security.Claims;

namespace Kama.ApiManagement.Core.Service;

public interface IQrHelper
{
    Qr SetObjectCache();

    Qr EditObjectCache(string userName, Qr model);

    Qr CheckObjectCache(string key);

    bool DeleteObjectCache(string key);
}
