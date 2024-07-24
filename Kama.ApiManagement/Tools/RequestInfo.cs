using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System.ComponentModel;

namespace Kama.ApiManagement.Tools;

public class RequestInfo : Core.IRequestInfo
{

    private readonly IHttpContextAccessor _httpContextAccessor;
    public RequestInfo(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;

        if (_httpContextAccessor.HttpContext?.Request != null && _httpContextAccessor.HttpContext.Request.Headers.ContainsKey("AuthorizationClaims"))
            AuthorizationClaims = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(_httpContextAccessor.HttpContext.Request.Headers["AuthorizationClaims"]);
    }
    public Dictionary<string, string> AuthorizationClaims { get; private set; }


    public byte? Application => null;

    public string Password => string.Empty;

    // heder
    public Guid? ApplicationId => GetValueFromHeader<Guid?>("ApplicationID");

    public Guid? ClientId => GetValueFromHeader<Guid?>("ClientID");

    public string RemoteIP => GetIPAddress(Claims.RemoteIP);

    public string AppURL => GetValueFromHeader<string>(Claims.AppURL);

    public string Authorization => GetValueFromHeader<string>(Claims.Authorization);

    public string Token => Authorization?.Replace("Bearer ", "");

    public string UserAgent => GetValueFromHeader<string>(Claims.UserAgent);


    // claim

    public Guid? UserId => GetValueFromToken<Guid?>("UserID");

    public string UserName => GetValueFromToken<string>("UserName");

    public Guid? DepartmentId => GetValueFromToken<Guid?>("DepartmentID");


    public Guid? ProvinceId => GetValueFromToken<Guid?>("ProvinceID");

    public Guid? PositionId => GetValueFromToken<Guid?>("PositionID");

    public byte? UserType => GetValueFromToken<byte?>("UserType");

    //public LicencePositionType PositionType1 { get => GetValueFromHeader<LicencePositionType>("PositionType");  } 

    public byte? PositionType => GetValueFromToken<byte?>("PositionType");

    public byte? DepartmentType => GetValueFromToken<byte?>("DepartmentType");

    public byte? PositionSubType => GetValueFromToken<byte?>(Claims.PositionSubType);

    public string SsoTicket => GetValueFromToken<string>(Claims.SsoTicket);

    public string NationalCode => GetValueFromToken<string>(Claims.NationalCode);

    public Guid? MasterPasswordID => GetValueFromToken<Guid?>(Claims.MasterPasswordID);

    private T GetValueFromToken<T>(string key)
    {
        string v = "";
        AuthorizationClaims?.TryGetValue(key, out v);
        return CastValue<T>(v);
    }

    private string GetIPAddress(string key)
    {
        if ((bool)(_httpContextAccessor.HttpContext.Request?.Headers.ContainsKey(key)))
            return _httpContextAccessor.HttpContext.Request?.Headers[key];
        return _httpContextAccessor.HttpContext.Request?.HttpContext.Connection.RemoteIpAddress.ToString();
    }
    private T GetValueFromHeader<T>(string key)
    {
        if ((bool)(_httpContextAccessor.HttpContext.Request?.Headers.ContainsKey(key)))
            return CastValue<T>(_httpContextAccessor.HttpContext.Request?.Headers[key]);
        else
            return GetValueFromToken<T>(key);
    }

    private static T CastValue<T>(string value)
    {
        if (value is T variable) return variable;

        try
        {
            if (Nullable.GetUnderlyingType(typeof(T)) != null)
            {
                return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(value);
            }

            return (T)Convert.ChangeType(value, typeof(T));
        }
        catch (Exception)
        {
            return default(T);
        }
    }
}
