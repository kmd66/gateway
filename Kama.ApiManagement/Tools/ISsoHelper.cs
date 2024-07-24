//using Kama.ApiManagement.Core.Service;
//using Kama.AppCore.IOC;
//using Microsoft.Extensions.Caching.Memory;
//using Microsoft.Extensions.Options;

//namespace Kama.ApiManagement.Tools;

//public class SsoHelper : ISsoHelper
//{
//    private double cacheMinute = 0;

//    public SsoHelper()
//    {
//        if (cacheMinute == 0)
//            cacheMinute = IContainer.Instance.GetService<IOptions<AppSettings>>().Value.CacheMinute;
//    }

//    public void SetObjectCache(Guid ClientID, string connectionHubId, string userName, string ssoTicket, string hash)
//    {

//        var cacheKey = ClientID.ToString() + connectionHubId;
//        var cacheKeyMd5 = Library.Helper.Encryption.AesHelper.Md5(cacheKey);

//        var ssoCach = new SsoCach { Key = ssoTicket, UserName = userName, Hash = hash };

//        var memoryCache = IContainer.Instance.GetService<IMemoryCache>();
//        memoryCache.Set(cacheKeyMd5, ssoCach, DateTime.Now.AddSeconds(cacheMinute));
//    }

//    public SsoCach CheckObjectCache(string SecurityStamp, Guid clientId)
//    {
//        try
//        {
//            if (string.IsNullOrEmpty(SecurityStamp))
//                return null;


//            var list = Library.Helper.Crypto.Base64.Decode(SecurityStamp);

//            var cacheKey = clientId.ToString() + list[0];
//            var cacheKeyMd5 = Library.Helper.Encryption.AesHelper.Md5(cacheKey);

//            var memoryCache = IContainer.Instance.GetService<IMemoryCache>();
//            SsoCach cache = memoryCache.Get<SsoCach>(cacheKeyMd5);
//            if (cache == null || cache.Hash != list[1])
//                return null;

//            return cache;
//        }
//        catch
//        {
//            return null;
//        }
//    }

//    public bool DeleteObjectCache(string SecurityStamp, Guid clientId)
//    {
//        try
//        {
//            if (string.IsNullOrEmpty(SecurityStamp))
//                return false;

//            var list = Library.Helper.Crypto.Base64.Decode(SecurityStamp);
//            var cacheKey = clientId.ToString() + list[0];
//            var cacheKeyMd5 = Kama.Library.Helper.Encryption.AesHelper.Md5(cacheKey);
//            var memoryCache = IContainer.Instance.GetService<IMemoryCache>();
//            memoryCache.Remove(cacheKeyMd5);
//            return true;
//        }
//        catch
//        {
//            return false;
//        }
//    }
//}
