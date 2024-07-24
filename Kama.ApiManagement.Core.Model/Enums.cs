namespace Kama.ApiManagement.Core.Model;

public enum ServerType : byte
{
    Unknown = 0,
    صف_بندی = 1,
    آولین_سرور = 2,
}

public enum LoginType : byte
{
    Unknown = 0,
    نام_کاربری_و_رمز_عبور = 1,
    تلفن_همراه_و_رمز_عبور = 2,
    تلفن_همراه_و_کد_امنیتی = 3,
    ایمیل_و_رمز_عبور = 4,
    ایمیل_و_کد_امنیتی = 5,
    نام_کاربری_و_رمز_عبور_و_کد_امنیتی = 6,
    Sso = 7,
    IndividualLogin = 8,
    QrLogin = 9,
}
public enum OperatingSystemType : byte
{
    unknown = 0,
    windows = 1,
    android = 2,
    ios = 3,
    linux = 4,
    mac = 5,
    blackberry_os = 6,
    سایر = 7
    //سایر = 5
}

public enum BrowserType : byte
{
    unknown = 0,
    firefox = 1,
    chrome = 2,
    opera = 3,
    internet_explorer = 4,
    سایر = 5
}

public enum DeviceType : byte
{
    unknown = 0,
    mobile = 1,
    desktop = 2,
    smartphone = 3,
    tablet = 4,
    iPhone = 5,
    سایر = 6
}
public enum SsoEnum : Byte
{
    Login = 1,
    Logout = 2,
    ClosePopUp = 3,
    ShiftSsoLogin = 4,
    ReloadPage = 5,
}
public enum EnableState : Byte
{
    Unknown = 0,
    غیر_فعال = 1,
    فعال = 2,
}
public enum ClientType : Byte
{
    Unknown = 0,
    JavaScript = 1,
    Native = 2,
}