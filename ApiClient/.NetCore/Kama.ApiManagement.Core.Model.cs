using System;
using System.Collections.Generic;

namespace Kama.ApiManagement.Core.Model
{
	public class Action
	{
		public System.Guid ControllerID { get; set; }

		public System.Guid ApplicationID { get; set; }

		public System.String ApplicationName { get; set; }

		public System.String Name { get; set; }

		public System.String ControllerName { get; set; }

		public System.String ControllerTitle { get; set; }

		public System.String Title { get; set; }

		public System.Int32 Total { get; set; }

		public System.Guid ID { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Int32 Order { get; set; }

		public System.String Hash { get; set; }

	}
	public class ActionListVM
	{
		public System.Guid ControllerID { get; set; }

		public System.Guid? ApplicationID { get; set; }

		public System.String ControllerName { get; set; }

		public System.String ControllerTitle { get; set; }

		public System.String Name { get; set; }

		public System.String Title { get; set; }

		public System.Int32 PageSize { get; set; }

		public System.Int32 PageIndex { get; set; }

		public List<Kama.ApiManagement.Core.Model.SortExp> SortExp { get; set; }

		public System.Boolean GetTotalCount { get; set; }

	}
	public class ActiveToken
	{
		public System.String SsoTicket { get; set; }

		public List<Kama.ApiManagement.Core.Model.ActiveTokenItems> Items { get; set; }

	}
	public class ActiveTokenItems
	{
		public System.String SsoTicket { get; set; }

		public System.Int32 Total { get; set; }

		public System.Guid UserID { get; set; }

		public System.DateTime IssuedDate { get; set; }

		public System.DateTime ExpireDate { get; set; }

		public System.Boolean Expired { get; set; }

		public System.Int16 OS { get; set; }

		public System.String OSVersion { get; set; }

		public System.Int16 Browser { get; set; }

		public System.String BrowserVersion { get; set; }

		public System.Int16 DeviceType { get; set; }

		public System.Guid ApplicationID { get; set; }

		public System.String ApplicationName { get; set; }

		public System.Guid ID { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Int32 Order { get; set; }

		public System.String Hash { get; set; }

	}
	public class ActivityLogAddRedis
	{
		public System.Guid ID { get; set; }

		public System.String UserIP { get; set; }

		public System.Guid ControllerID { get; set; }

		public System.Guid ActionID { get; set; }

		public System.Guid? ApplicationID { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Int32 Count { get; set; }

	}
	public class ActivityLogAddVM
	{
		public System.Guid ActionID { get; set; }

		public System.Guid? PositionID { get; set; }

		public System.Guid? UserID { get; set; }

		public System.String UserIP { get; set; }

		public System.Guid? ObjectID { get; set; }

		public Kama.AppCore.ResponseStatus Success { get; set; }

		public System.Int32 Duration { get; set; }

		public System.String OSVersion { get; set; }

		public Kama.ApiManagement.Core.Model.BrowserType Browser { get; set; }

		public System.String BrowserVersion { get; set; }

		public Kama.ApiManagement.Core.Model.DeviceType DeviceType { get; set; }

		public System.String UserName { get; set; }

		public Kama.AppCore.CallType CallType { get; set; }

		public System.Guid? ClientID { get; set; }

		public System.String ControllerName { get; set; }

		public System.String ControllerTitle { get; set; }

		public System.String ActionName { get; set; }

		public System.String ActionTitle { get; set; }

		public System.Guid? ApplicationID { get; set; }

		public Kama.ApiManagement.Core.Model.OperatingSystemType OS { get; set; }

		public System.Object Object { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Guid ControllerID { get; set; }

		public System.Guid ID { get; set; }

		public System.Int32 Order { get; set; }

		public System.String Hash { get; set; }

	}
	public class ActivityLogSetting
	{
		public System.Boolean Enabled { get; set; }

		public System.String ActivityLogHost { get; set; }

		public System.Int32 ExcludedActionCacheTimeout { get; set; }

	}
	public class ActivityLogVerify
	{
		public Kama.ApiManagement.Core.Model.ActivityLogVerifyResult VerifyResult { get; set; }

	}
	public class ApiFirstServer
	{
		public System.Guid Id { get; set; }

		public System.String ConnectionId { get; set; }

		public System.DateTime Date { get; set; }

		public System.Boolean Expired { get; set; }

	}
	public class ApiServerDetail
	{
		public System.String ConnectionId { get; set; }

		public System.String Name { get; set; }

		public System.String Url { get; set; }

		public System.String ReconnectingUrl { get; set; }

		public System.Guid ApplicationID { get; set; }

	}
	public class ApiServerIndex
	{
		public System.String Name { get; set; }

		public System.Int32 Index { get; set; }

	}
	public class ApplicationHelper
	{
	}
	public class AppSettings
	{
		public Kama.AppCore.DeploymentMode DeploymentMode { get; set; }

		public System.Guid ApplicationID { get; set; }

		public System.String OrganizationHost { get; set; }

		public System.Double AccessTokenExpireTimeSpan { get; set; }

		public System.Double CacheMinute { get; set; }

		public System.String ApiKey { get; set; }

		public System.String ApiSecret { get; set; }

		public Kama.ApiManagement.Core.Model.ServerType ServerType { get; set; }

	}
	public class Client
	{
		public System.Guid ApplicationID { get; set; }

		public System.String ApplicationName { get; set; }

		public System.String ApplicationCode { get; set; }

		public System.Boolean ApplicationEnabled { get; set; }

		public System.String Name { get; set; }

		public System.String Abbreviation { get; set; }

		public System.String Secret { get; set; }

		public Kama.ApiManagement.Core.Model.ClientType Type { get; set; }

		public System.Boolean Enabled { get; set; }

		public System.Boolean SsoState { get; set; }

		public System.Int32 RefreshTokenLifeTime { get; set; }

		public System.String AllowedOrigin { get; set; }

		public System.String Url { get; set; }

		public System.String UserID { get; set; }

		public System.String UserHash { get; set; }

		public System.String CallBack { get; set; }

		public System.Guid ID { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Int32 Order { get; set; }

		public System.String Hash { get; set; }

	}
	public class ClientListVM
	{
		public System.Guid ApplicationID { get; set; }

		public System.String Name { get; set; }

		public System.String UserID { get; set; }

		public System.String UserHash { get; set; }

		public System.String CallBack { get; set; }

		public Kama.ApiManagement.Core.Model.SsoEnum Type { get; set; }

		public System.String Key { get; set; }

		public System.String Abbreviation { get; set; }

		public Kama.ApiManagement.Core.Model.EnableState Enabled { get; set; }

		public Kama.ApiManagement.Core.Model.ClientType TypeClient { get; set; }

		public System.String ConnectionHubId { get; set; }

		public System.Guid ID { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Int32 Order { get; set; }

		public System.String Hash { get; set; }

	}
	public class Controller
	{
		public System.String Name { get; set; }

		public System.String Title { get; set; }

		public System.String ApplicationName { get; set; }

		public System.Guid ApplicationID { get; set; }

		public System.Int32 Total { get; set; }

		public System.Guid ID { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Int32 Order { get; set; }

		public System.String Hash { get; set; }

	}
	public class ControllerListVM
	{
		public System.String Name { get; set; }

		public System.String Title { get; set; }

		public System.Guid? ApplicationID { get; set; }

		public System.Guid? ClientID { get; set; }

		public System.Int32 PageSize { get; set; }

		public System.Int32 PageIndex { get; set; }

		public List<Kama.ApiManagement.Core.Model.SortExp> SortExp { get; set; }

		public System.Boolean GetTotalCount { get; set; }

	}
	public class ExcelCellVM
	{
		public System.Int32? Row { get; set; }

		public System.Int32? Column { get; set; }

	}
	public class ExceptionRequest
	{
		public System.Int32 Daily { get; set; }

		public System.Int32 Minutely { get; set; }

		public System.Int32 Hourly { get; set; }

		public System.String Action { get; set; }

	}
	public class ExcludedAction
	{
		public System.Guid ApplicationID { get; set; }

		public System.String ApplicationName { get; set; }

		public System.String ActionName { get; set; }

		public System.String ControllerName { get; set; }

	}
	public class ExcludedActionListVM
	{
		public System.Guid? ApplicationID { get; set; }

		public System.String ControllerName { get; set; }

		public System.String ActionName { get; set; }

		public System.Int32 PageSize { get; set; }

		public System.Int32 PageIndex { get; set; }

		public List<Kama.ApiManagement.Core.Model.SortExp> SortExp { get; set; }

		public System.Boolean GetTotalCount { get; set; }

	}
	public class ExployeeExcelProcessErrors
	{
		public System.String NationalCode { get; set; }

		public System.String Messages { get; set; }

	}
	public class FileModel
	{
		public System.String FileName { get; set; }

		public System.String Comment { get; set; }

		public System.Byte[] Data { get; set; }

		public System.String Base64 { get; set; }

		public System.Guid ID { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Int32 Order { get; set; }

		public System.String Hash { get; set; }

	}
	public class GetTotalCountVM
	{
		public System.Int32 Total { get; set; }

	}
	public class GroupRequest
	{
		public List<Kama.ApiManagement.Core.Model.GroupRequestModel> Models { get; set; }

	}
	public class GroupRequestModel
	{
		public System.String Url { get; set; }

		public System.Object Model { get; set; }

	}
	public class IssuedToken
	{
		public System.Int32 Total { get; set; }

		public System.Guid? UserID { get; set; }

		public System.Guid ClientID { get; set; }

		public System.Guid RefreshTokenID { get; set; }

		public System.DateTime IssuedDate { get; set; }

		public System.DateTime ExpireDate { get; set; }

		public System.String Token { get; set; }

		public System.Boolean Expired { get; set; }

		public System.Guid? RefrshTokenID { get; set; }

		public System.DateTime? RefrshTokenExpireDate { get; set; }

		public System.Guid ID { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Int32 Order { get; set; }

		public System.String Hash { get; set; }

	}
	public class IssuedTokenListVM
	{
		public System.Guid? UserID { get; set; }

		public System.Guid? ClientID { get; set; }

		public System.Guid? RefreshTokenID { get; set; }

		public System.DateTime IssuedDate { get; set; }

		public System.DateTime ExpireDate { get; set; }

		public System.String Token { get; set; }

		public System.Boolean UndoOnlyApp { get; set; }

		public System.Int32 PageSize { get; set; }

		public System.Int32 PageIndex { get; set; }

		public List<Kama.ApiManagement.Core.Model.SortExp> SortExp { get; set; }

		public System.Boolean GetTotalCount { get; set; }

	}
	public class LimitationRequest
	{
		public System.Int32 Daily { get; set; }

		public System.Int32 Minutely { get; set; }

		public System.Int32 Hourly { get; set; }

		public List<System.String> IgnoreIp { get; set; }

		public List<Kama.ApiManagement.Core.Model.ExceptionRequest> Exceptions { get; set; }

	}
	public class LimitRequest
	{
		public System.Int32 Daily { get; set; }

		public System.Int32 Minutely { get; set; }

		public System.Int32 Hourly { get; set; }

	}
	public class ListVM
	{
		public System.Int32 PageSize { get; set; }

		public System.Int32 PageIndex { get; set; }

		public List<Kama.ApiManagement.Core.Model.SortExp> SortExp { get; set; }

		public System.Boolean GetTotalCount { get; set; }

	}
	public class Model
	{
		public System.Guid ID { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Int32 Order { get; set; }

		public System.String Hash { get; set; }

	}
	public class Qr
	{
		public System.String Key { get; set; }

		public System.String Value { get; set; }

		public System.String Hash { get; set; }

		public System.String UserName { get; set; }

	}
	public class RefreshToken
	{
		public System.Int32 Total { get; set; }

		public System.Guid UserID { get; set; }

		public System.DateTime IssuedDate { get; set; }

		public System.DateTime ExpireDate { get; set; }

		public System.String ProtectedTicket { get; set; }

		public System.String SsoTicket { get; set; }

		public System.Boolean Expired { get; set; }

		public Kama.ApiManagement.Core.Model.OperatingSystemType OS { get; set; }

		public System.String OSVersion { get; set; }

		public Kama.ApiManagement.Core.Model.BrowserType Browser { get; set; }

		public System.String BrowserVersion { get; set; }

		public Kama.ApiManagement.Core.Model.DeviceType DeviceType { get; set; }

		public System.Guid ID { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Int32 Order { get; set; }

		public System.String Hash { get; set; }

	}
	public class RefreshTokenVM
	{
		public System.Guid ID { get; set; }

		public System.Guid ClientId { get; set; }

		public System.String ClientSecret { get; set; }

		public System.String GrantType { get; set; }

	}
	public class RouteDetail
	{
		public System.String ActionPath { get; set; }

		public System.String ServerName { get; set; }

		public System.String Api { get; set; }

		public System.String ApiVersion { get; set; }

		public System.String ControllerName { get; set; }

		public System.String ActionName { get; set; }

		public System.String Id { get; set; }

		public System.String Url { get; set; }

	}
	public class SortExp
	{
		public System.String ColumnName { get; set; }

		public Kama.ApiManagement.Core.Model.SortOrderType SortOrder { get; set; }

	}
	public class Sso
	{
		public Kama.ApiManagement.Core.Model.SsoEnum Type { get; set; }

		public System.String Url { get; set; }

		public System.String Key { get; set; }

		public System.String Hash { get; set; }

		public System.String Token { get; set; }

		public System.String AppName { get; set; }

		public System.String AppAbbreviation { get; set; }

		public System.String UserID { get; set; }

		public System.String UserHash { get; set; }

		public System.String CallBack { get; set; }

		public System.Boolean SmsLogin { get; set; }

		public System.Boolean GetType { get; set; }

		public List<System.Guid> AppIDs { get; set; }

		public System.Guid? ClientID { get; set; }

		public System.String ConnectionHubId { get; set; }

		public System.Guid ID { get; set; }

		public System.DateTime CreationDate { get; set; }

		public System.Int32 Order { get; set; }

	}
	public class SsoCache
	{
		public System.Guid ID { get; set; }

		public System.Guid? MasterPassword { get; set; }

		public System.String Key { get; set; }

		public System.String SsoTicket { get; set; }

		public System.String Hash { get; set; }

		public System.String UserName { get; set; }

		public System.String UserHash { get; set; }

		public System.DateTime Date { get; set; }

		public System.DateTime ExpireDate { get; set; }

	}
	public class SsoVM
	{
		public Kama.ApiManagement.Core.Model.SsoEnum Type { get; set; }

		public System.String UserID { get; set; }

		public System.String UserHash { get; set; }

		public System.String CallBack { get; set; }

		public System.String Key { get; set; }

		public System.Guid? ApplicationID { get; set; }

		public System.Guid? ClientID { get; set; }

		public System.String ConnectionHubId { get; set; }

		public System.Int32 PageSize { get; set; }

		public System.Int32 PageIndex { get; set; }

		public List<Kama.ApiManagement.Core.Model.SortExp> SortExp { get; set; }

		public System.Boolean GetTotalCount { get; set; }

	}
	public class TimeRange
	{
		public System.Int32 StartHour { get; set; }

		public System.Int32 EndHour { get; set; }

	}
	public class Token
	{
		public System.Guid ClientId { get; set; }

		public System.String ClientSecret { get; set; }

		public System.String GrantType { get; set; }

		public System.String UserName { get; set; }

		public System.String Password { get; set; }

		public Kama.ApiManagement.Core.Model.LoginType LoginType { get; set; }

		public System.String CellPhone { get; set; }

		public System.String Email { get; set; }

		public System.String SecurityStamp { get; set; }

	}
	public class TokenObject
	{
		public System.String expires { get; set; }

		public System.String issued { get; set; }

		public System.String access_token { get; set; }

		public System.String client_id { get; set; }

		public System.String token_type { get; set; }

		public System.String refresh_token { get; set; }

		public System.String username { get; set; }

	}
	public class TokenSwitchMode
	{
		public Kama.Organization.Core.Model.User User { get; set; }

		public System.String SsoTicket { get; set; }

		public System.String NationalCode { get; set; }

		public System.Guid? MasterPasswordID { get; set; }

	}
	public class ValidateExcelErrorVM<T>
	{
		public T Error { get; set; }

		public System.String Fieldvalue { get; set; }

		public List<Kama.ApiManagement.Core.Model.ExcelCellVM> Cells { get; set; }

	}
	public class ValidateExcelVM<T1, T2>
	{
		public List<ValidateExcelErrorVM<T2>> Errors { get; set; }

		public Dictionary<System.String,System.Int32> HeaderColumns { get; set; }

		public List<T1> List { get; set; }

		public System.Boolean Success { get; set; }

	}
	public enum ApplicationEnum : System.Int32
	{
		Unknown = 0,
		سامانه_خدمات = 1,
		سامانه_آموزش = 2,
		سامانه_مدیریت_اطلاعات_پرداخت_کارکنان_نظام_اداری = 3,
		سامانه_استخدام_و_بکارگیری_نیروی_انسانی = 4,
		سامانه_ارزیابی_توسعه_شایستگی_های_عمومی_مدیران_حرفه_ای = 5,
		سامانه_ثبت_حقوق_و_مزایای_کارکنان = 6,
		سامانه_شورای_عالی_اداری = 7,
		سامانه_احراز_هویت_مرکزی = 8,
		سامانه_نظرسنجی = 9,
		گزارش_ها_و_داشبوردهای_سامانه_کارمند_ایران = 10,
		سامانه_سند_برنامه_نیروی_انسانی = 11,
		پایگاه_اطلاعات_کارکنان_نظام_اداری = 12,
		سامانه_ملی_مدیریت_ساختار_دستگاههای_اجرایی_کشور = 13,
		پایگاه_اطلاعات_مدیران_دستگاه_های_اجرایی = 14,
		سامانه_مدیریت_مشاغل = 15,
		سامانه_مدیریت_اطلاعات_پایه_سینا = 16,
		اپلیکیشن_سینا = 17,
	}
	public enum ServerType : System.Byte
	{
		Unknown = 0,
		صف_بندی = 1,
		آولین_سرور = 2,
	}
	public enum LoginType : System.Byte
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
	public enum OperatingSystemType : System.Byte
	{
		unknown = 0,
		windows = 1,
		android = 2,
		ios = 3,
		linux = 4,
		mac = 5,
		blackberry_os = 6,
		سایر = 7,
	}
	public enum BrowserType : System.Byte
	{
		unknown = 0,
		firefox = 1,
		chrome = 2,
		opera = 3,
		internet_explorer = 4,
		سایر = 5,
	}
	public enum DeviceType : System.Byte
	{
		unknown = 0,
		mobile = 1,
		desktop = 2,
		smartphone = 3,
		tablet = 4,
		iPhone = 5,
		سایر = 6,
	}
	public enum SsoEnum : System.Byte
	{
		Login = 1,
		Logout = 2,
		ClosePopUp = 3,
		ShiftSsoLogin = 4,
		ReloadPage = 5,
	}
	public enum EnableState : System.Byte
	{
		Unknown = 0,
		غیر_فعال = 1,
		فعال = 2,
	}
	public enum ClientType : System.Byte
	{
		Unknown = 0,
		JavaScript = 1,
		Native = 2,
	}
	public enum ActivityLogVerifyResult : System.Byte
	{
		Ok = 1,
		Excluded = 2,
		ActionBlocked = 3,
		UserBlocked = 4,
	}
	public enum SortOrderType : System.Byte
	{
		ASC = 0,
		DESC = 1,
	}
}
