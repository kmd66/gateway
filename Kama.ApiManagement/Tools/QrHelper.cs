using Kama.AppCore.IOC;
using Kama.ApiManagement.Core.Service;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;


namespace Kama.ApiManagement.Tools;

public class QrHelper : IQrHelper
{
    private double qrCacheMinute = 0;

    public QrHelper()
    {
        if (qrCacheMinute == 0)
            qrCacheMinute = IContainer.Instance.GetService<IOptions<AppSettings>>().Value.CacheMinute;
    }

    public Qr SetObjectCache()
    {

        var qr = new Qr
        {
            Value = Guid.NewGuid().ToString().Replace("-", ""),
            Key = Guid.NewGuid().ToString().Replace("-", ""),
            Hash = Guid.NewGuid().ToString().Replace("-", "")
        };

        var memoryCache = IContainer.Instance.GetService<IMemoryCache>();
        memoryCache.Set(qr.Key, qr, DateTime.Now.AddMinutes(qrCacheMinute));

        return qr;
    }

    public Qr EditObjectCache(string userName, Qr model)
    {
        try
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(model.Key) || string.IsNullOrEmpty(model.Value))
                return null;

            Qr qr = CheckObjectCache(model.Key);
            if (qr == null || qr.UserName != null || qr.Value != model.Value)
                return null;

            var memoryCache = IContainer.Instance.GetService<IMemoryCache>();
            memoryCache.Remove(qr.Value);

            qr.UserName = userName;

            memoryCache.Set(qr.Key, qr, DateTime.Now.AddMinutes(1));

            return qr;
        }
        catch
        {
            return null;
        }
    }

    public Qr CheckObjectCache(string key)
    {
        try
        {
            if (string.IsNullOrEmpty(key))
                return null;

            var memoryCache = IContainer.Instance.GetService<IMemoryCache>();
            var cache = memoryCache.Get<Qr>("key");
            if (cache == null)
                return null;

            return cache;
        }
        catch
        {
            return null;
        }
    }

    public bool DeleteObjectCache(string key)
    {
        try
        {
            if (string.IsNullOrEmpty(key))
                return false;

            var memoryCache = IContainer.Instance.GetService<IMemoryCache>();
            memoryCache.Remove(key);

            return true;
        }
        catch
        {

            return false;
        }
    }

}