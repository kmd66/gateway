using System;
using Kama.DatabaseModel;
using System.Threading.Tasks;
 using System.Collections.Generic;

namespace Kama.ApiManagement.Infrastructure.DAL
{
public class ALG: Database
{
#region Constructors
public ALG(string connectionString)
	:base(connectionString){}

public ALG(string connectionString, IModelValueBinder modelValueBinder)
	:base(connectionString, modelValueBinder){}
#endregion

#region ModifyAction

public System.Data.SqlClient.SqlCommand GetCommand_ModifyAction(Guid? _id, Guid? _controllerID, string _name, string _title, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spModifyAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AControllerID", IsOutput = false, Value = _controllerID == null ? DBNull.Value : (object)_controllerID }, 
					new Parameter { Name = "@AName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_name) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_name) }, 
					new Parameter { Name = "@ATitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_title) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_title) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> ModifyActionAsync(Guid? _id, Guid? _controllerID, string _name, string _title, int? timeout = null)
{
	using(var cmd = GetCommand_ModifyAction(_id, _controllerID, _name, _title, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> ModifyActionDapperAsync<T>(Guid? _id, Guid? _controllerID, string _name, string _title, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spModifyAction",new {AID=_id,AControllerID=_controllerID,AName=string.IsNullOrWhiteSpace(_name) ? _name : ReplaceArabicWithPersianChars(_name),ATitle=string.IsNullOrWhiteSpace(_title) ? _title : ReplaceArabicWithPersianChars(_title)} , timeout );
}

public ResultSet ModifyAction(Guid? _id, Guid? _controllerID, string _name, string _title, int? timeout = null)
{
	using(var cmd = GetCommand_ModifyAction(_id, _controllerID, _name, _title, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region CreateOnlineActivityLog

public System.Data.SqlClient.SqlCommand GetCommand_CreateOnlineActivityLog(Guid? _id, string _controllerName, string _actionName, string _controllerTitle, string _actionTitle, Guid? _positionID, string _userName, byte? _callType, Guid? _clientID, int? _duration, byte? _os, string _oSVersion, byte? _browser, string _browserVersion, byte? _deviceType, Guid? _applicationID, Guid? _userID, string _userIP, Guid? _objectID, string _objectJson, byte? _success, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spCreateOnlineActivityLog", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerTitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerTitle) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerTitle) }, 
					new Parameter { Name = "@AActionTitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionTitle) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionTitle) }, 
					new Parameter { Name = "@APositionID", IsOutput = false, Value = _positionID == null ? DBNull.Value : (object)_positionID }, 
					new Parameter { Name = "@AUserName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userName) }, 
					new Parameter { Name = "@ACallType", IsOutput = false, Value = _callType == null ? DBNull.Value : (object)_callType }, 
					new Parameter { Name = "@AClientID", IsOutput = false, Value = _clientID == null ? DBNull.Value : (object)_clientID }, 
					new Parameter { Name = "@ADuration", IsOutput = false, Value = _duration == null ? DBNull.Value : (object)_duration }, 
					new Parameter { Name = "@AOS", IsOutput = false, Value = _os == null ? DBNull.Value : (object)_os }, 
					new Parameter { Name = "@AOSVersion", IsOutput = false, Value = string.IsNullOrWhiteSpace(_oSVersion) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_oSVersion) }, 
					new Parameter { Name = "@ABrowser", IsOutput = false, Value = _browser == null ? DBNull.Value : (object)_browser }, 
					new Parameter { Name = "@ABrowserVersion", IsOutput = false, Value = string.IsNullOrWhiteSpace(_browserVersion) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_browserVersion) }, 
					new Parameter { Name = "@ADeviceType", IsOutput = false, Value = _deviceType == null ? DBNull.Value : (object)_deviceType }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AUserID", IsOutput = false, Value = _userID == null ? DBNull.Value : (object)_userID }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@AObjectID", IsOutput = false, Value = _objectID == null ? DBNull.Value : (object)_objectID }, 
					new Parameter { Name = "@AObjectJson", IsOutput = false, Value = string.IsNullOrWhiteSpace(_objectJson) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_objectJson) }, 
					new Parameter { Name = "@ASuccess", IsOutput = false, Value = _success == null ? DBNull.Value : (object)_success }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> CreateOnlineActivityLogAsync(Guid? _id, string _controllerName, string _actionName, string _controllerTitle, string _actionTitle, Guid? _positionID, string _userName, byte? _callType, Guid? _clientID, int? _duration, byte? _os, string _oSVersion, byte? _browser, string _browserVersion, byte? _deviceType, Guid? _applicationID, Guid? _userID, string _userIP, Guid? _objectID, string _objectJson, byte? _success, int? timeout = null)
{
	using(var cmd = GetCommand_CreateOnlineActivityLog(_id, _controllerName, _actionName, _controllerTitle, _actionTitle, _positionID, _userName, _callType, _clientID, _duration, _os, _oSVersion, _browser, _browserVersion, _deviceType, _applicationID, _userID, _userIP, _objectID, _objectJson, _success, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> CreateOnlineActivityLogDapperAsync<T>(Guid? _id, string _controllerName, string _actionName, string _controllerTitle, string _actionTitle, Guid? _positionID, string _userName, byte? _callType, Guid? _clientID, int? _duration, byte? _os, string _oSVersion, byte? _browser, string _browserVersion, byte? _deviceType, Guid? _applicationID, Guid? _userID, string _userIP, Guid? _objectID, string _objectJson, byte? _success, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spCreateOnlineActivityLog",new {AID=_id,AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName),AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerTitle=string.IsNullOrWhiteSpace(_controllerTitle) ? _controllerTitle : ReplaceArabicWithPersianChars(_controllerTitle),AActionTitle=string.IsNullOrWhiteSpace(_actionTitle) ? _actionTitle : ReplaceArabicWithPersianChars(_actionTitle),APositionID=_positionID,AUserName=string.IsNullOrWhiteSpace(_userName) ? _userName : ReplaceArabicWithPersianChars(_userName),ACallType=_callType,AClientID=_clientID,ADuration=_duration,AOS=_os,AOSVersion=string.IsNullOrWhiteSpace(_oSVersion) ? _oSVersion : ReplaceArabicWithPersianChars(_oSVersion),ABrowser=_browser,ABrowserVersion=string.IsNullOrWhiteSpace(_browserVersion) ? _browserVersion : ReplaceArabicWithPersianChars(_browserVersion),ADeviceType=_deviceType,AApplicationID=_applicationID,AUserID=_userID,AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),AObjectID=_objectID,AObjectJson=string.IsNullOrWhiteSpace(_objectJson) ? _objectJson : ReplaceArabicWithPersianChars(_objectJson),ASuccess=_success} , timeout );
}

public ResultSet CreateOnlineActivityLog(Guid? _id, string _controllerName, string _actionName, string _controllerTitle, string _actionTitle, Guid? _positionID, string _userName, byte? _callType, Guid? _clientID, int? _duration, byte? _os, string _oSVersion, byte? _browser, string _browserVersion, byte? _deviceType, Guid? _applicationID, Guid? _userID, string _userIP, Guid? _objectID, string _objectJson, byte? _success, int? timeout = null)
{
	using(var cmd = GetCommand_CreateOnlineActivityLog(_id, _controllerName, _actionName, _controllerTitle, _actionTitle, _positionID, _userName, _callType, _clientID, _duration, _os, _oSVersion, _browser, _browserVersion, _deviceType, _applicationID, _userID, _userIP, _objectID, _objectJson, _success, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetActionCount

public System.Data.SqlClient.SqlCommand GetCommand_GetActionCount(string _controllerName, string _actionName, Guid? _userID, Guid? _clientID, Guid? _applicationID, bool? _returnMinuteCount, bool? _returnHourCount, bool? _returnDayCount, bool? _returnMonthCount, string _userName, string _userIP, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetActionCount", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AUserID", IsOutput = false, Value = _userID == null ? DBNull.Value : (object)_userID }, 
					new Parameter { Name = "@AClientID", IsOutput = false, Value = _clientID == null ? DBNull.Value : (object)_clientID }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AReturnMinuteCount", IsOutput = false, Value = _returnMinuteCount == null ? DBNull.Value : (object)_returnMinuteCount }, 
					new Parameter { Name = "@AReturnHourCount", IsOutput = false, Value = _returnHourCount == null ? DBNull.Value : (object)_returnHourCount }, 
					new Parameter { Name = "@AReturnDayCount", IsOutput = false, Value = _returnDayCount == null ? DBNull.Value : (object)_returnDayCount }, 
					new Parameter { Name = "@AReturnMonthCount", IsOutput = false, Value = _returnMonthCount == null ? DBNull.Value : (object)_returnMonthCount }, 
					new Parameter { Name = "@AUserName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userName) }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetActionCountAsync(string _controllerName, string _actionName, Guid? _userID, Guid? _clientID, Guid? _applicationID, bool? _returnMinuteCount, bool? _returnHourCount, bool? _returnDayCount, bool? _returnMonthCount, string _userName, string _userIP, int? timeout = null)
{
	using(var cmd = GetCommand_GetActionCount(_controllerName, _actionName, _userID, _clientID, _applicationID, _returnMinuteCount, _returnHourCount, _returnDayCount, _returnMonthCount, _userName, _userIP, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetActionCountDapperAsync<T>(string _controllerName, string _actionName, Guid? _userID, Guid? _clientID, Guid? _applicationID, bool? _returnMinuteCount, bool? _returnHourCount, bool? _returnDayCount, bool? _returnMonthCount, string _userName, string _userIP, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetActionCount",new {AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName),AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AUserID=_userID,AClientID=_clientID,AApplicationID=_applicationID,AReturnMinuteCount=_returnMinuteCount,AReturnHourCount=_returnHourCount,AReturnDayCount=_returnDayCount,AReturnMonthCount=_returnMonthCount,AUserName=string.IsNullOrWhiteSpace(_userName) ? _userName : ReplaceArabicWithPersianChars(_userName),AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP)} , timeout );
}

public ResultSet GetActionCount(string _controllerName, string _actionName, Guid? _userID, Guid? _clientID, Guid? _applicationID, bool? _returnMinuteCount, bool? _returnHourCount, bool? _returnDayCount, bool? _returnMonthCount, string _userName, string _userIP, int? timeout = null)
{
	using(var cmd = GetCommand_GetActionCount(_controllerName, _actionName, _userID, _clientID, _applicationID, _returnMinuteCount, _returnHourCount, _returnDayCount, _returnMonthCount, _userName, _userIP, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetDailyActivityLog

public System.Data.SqlClient.SqlCommand GetCommand_GetDailyActivityLog(Guid? _actionID, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetDailyActivityLog", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AActionID", IsOutput = false, Value = _actionID == null ? DBNull.Value : (object)_actionID }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetDailyActivityLogAsync(Guid? _actionID, int? timeout = null)
{
	using(var cmd = GetCommand_GetDailyActivityLog(_actionID, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetDailyActivityLogDapperAsync<T>(Guid? _actionID, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetDailyActivityLog",new {AActionID=_actionID} , timeout );
}

public ResultSet GetDailyActivityLog(Guid? _actionID, int? timeout = null)
{
	using(var cmd = GetCommand_GetDailyActivityLog(_actionID, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetMonthlyActivityLogs

public System.Data.SqlClient.SqlCommand GetCommand_GetMonthlyActivityLogs(Guid? _actionID, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetMonthlyActivityLogs", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AActionID", IsOutput = false, Value = _actionID == null ? DBNull.Value : (object)_actionID }, 
					new Parameter { Name = "@ADateFrom", IsOutput = false, Value = _dateFrom == null ? DBNull.Value : (object)_dateFrom }, 
					new Parameter { Name = "@ADateTo", IsOutput = false, Value = _dateTo == null ? DBNull.Value : (object)_dateTo }, 
					new Parameter { Name = "@APageSize", IsOutput = false, Value = _pageSize == null ? DBNull.Value : (object)_pageSize }, 
					new Parameter { Name = "@APageIndex", IsOutput = false, Value = _pageIndex == null ? DBNull.Value : (object)_pageIndex }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetMonthlyActivityLogsAsync(Guid? _actionID, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetMonthlyActivityLogs(_actionID, _dateFrom, _dateTo, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetMonthlyActivityLogsDapperAsync<T>(Guid? _actionID, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetMonthlyActivityLogs",new {AActionID=_actionID,ADateFrom=_dateFrom,ADateTo=_dateTo,APageSize=_pageSize,APageIndex=_pageIndex} , timeout );
}

public ResultSet GetMonthlyActivityLogs(Guid? _actionID, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetMonthlyActivityLogs(_actionID, _dateFrom, _dateTo, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetActivityLogs

public System.Data.SqlClient.SqlCommand GetCommand_GetActivityLogs(string _controllerTitle, string _actionName, Guid? _positionID, Guid? _applicationID, string _userName, string _userFullName, int? _pageIndex, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, byte? _callType, byte? _success, int? _pageSize, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetActivityLogs", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AControllerTitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerTitle) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerTitle) }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@APositionID", IsOutput = false, Value = _positionID == null ? DBNull.Value : (object)_positionID }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AUserName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userName) }, 
					new Parameter { Name = "@AUserFullName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userFullName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userFullName) }, 
					new Parameter { Name = "@APageIndex", IsOutput = false, Value = _pageIndex == null ? DBNull.Value : (object)_pageIndex }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@ADateFrom", IsOutput = false, Value = _dateFrom == null ? DBNull.Value : (object)_dateFrom }, 
					new Parameter { Name = "@ADateTo", IsOutput = false, Value = _dateTo == null ? DBNull.Value : (object)_dateTo }, 
					new Parameter { Name = "@ACallType", IsOutput = false, Value = _callType == null ? DBNull.Value : (object)_callType }, 
					new Parameter { Name = "@ASuccess", IsOutput = false, Value = _success == null ? DBNull.Value : (object)_success }, 
					new Parameter { Name = "@APageSize", IsOutput = false, Value = _pageSize == null ? DBNull.Value : (object)_pageSize }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetActivityLogsAsync(string _controllerTitle, string _actionName, Guid? _positionID, Guid? _applicationID, string _userName, string _userFullName, int? _pageIndex, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, byte? _callType, byte? _success, int? _pageSize, int? timeout = null)
{
	using(var cmd = GetCommand_GetActivityLogs(_controllerTitle, _actionName, _positionID, _applicationID, _userName, _userFullName, _pageIndex, _userIP, _dateFrom, _dateTo, _callType, _success, _pageSize, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetActivityLogsDapperAsync<T>(string _controllerTitle, string _actionName, Guid? _positionID, Guid? _applicationID, string _userName, string _userFullName, int? _pageIndex, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, byte? _callType, byte? _success, int? _pageSize, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetActivityLogs",new {AControllerTitle=string.IsNullOrWhiteSpace(_controllerTitle) ? _controllerTitle : ReplaceArabicWithPersianChars(_controllerTitle),AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),APositionID=_positionID,AApplicationID=_applicationID,AUserName=string.IsNullOrWhiteSpace(_userName) ? _userName : ReplaceArabicWithPersianChars(_userName),AUserFullName=string.IsNullOrWhiteSpace(_userFullName) ? _userFullName : ReplaceArabicWithPersianChars(_userFullName),APageIndex=_pageIndex,AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),ADateFrom=_dateFrom,ADateTo=_dateTo,ACallType=_callType,ASuccess=_success,APageSize=_pageSize} , timeout );
}

public ResultSet GetActivityLogs(string _controllerTitle, string _actionName, Guid? _positionID, Guid? _applicationID, string _userName, string _userFullName, int? _pageIndex, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, byte? _callType, byte? _success, int? _pageSize, int? timeout = null)
{
	using(var cmd = GetCommand_GetActivityLogs(_controllerTitle, _actionName, _positionID, _applicationID, _userName, _userFullName, _pageIndex, _userIP, _dateFrom, _dateTo, _callType, _success, _pageSize, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetActivityLog

public System.Data.SqlClient.SqlCommand GetCommand_GetActivityLog(Guid? _controllerID, Guid? _actionID, string _userIP, DateTime? _creationDateFrom, DateTime? _creationDateTo, string _userName, short? _callType, bool? _getTotalCount, int? _pageSize, int? _pageIndex, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetActivityLog", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AControllerID", IsOutput = false, Value = _controllerID == null ? DBNull.Value : (object)_controllerID }, 
					new Parameter { Name = "@AActionID", IsOutput = false, Value = _actionID == null ? DBNull.Value : (object)_actionID }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@ACreationDateFrom", IsOutput = false, Value = _creationDateFrom == null ? DBNull.Value : (object)_creationDateFrom }, 
					new Parameter { Name = "@ACreationDateTo", IsOutput = false, Value = _creationDateTo == null ? DBNull.Value : (object)_creationDateTo }, 
					new Parameter { Name = "@AUserName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userName) }, 
					new Parameter { Name = "@ACallType", IsOutput = false, Value = _callType == null ? DBNull.Value : (object)_callType }, 
					new Parameter { Name = "@AGetTotalCount", IsOutput = false, Value = _getTotalCount == null ? DBNull.Value : (object)_getTotalCount }, 
					new Parameter { Name = "@APageSize", IsOutput = false, Value = _pageSize == null ? DBNull.Value : (object)_pageSize }, 
					new Parameter { Name = "@APageIndex", IsOutput = false, Value = _pageIndex == null ? DBNull.Value : (object)_pageIndex }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetActivityLogAsync(Guid? _controllerID, Guid? _actionID, string _userIP, DateTime? _creationDateFrom, DateTime? _creationDateTo, string _userName, short? _callType, bool? _getTotalCount, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetActivityLog(_controllerID, _actionID, _userIP, _creationDateFrom, _creationDateTo, _userName, _callType, _getTotalCount, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetActivityLogDapperAsync<T>(Guid? _controllerID, Guid? _actionID, string _userIP, DateTime? _creationDateFrom, DateTime? _creationDateTo, string _userName, short? _callType, bool? _getTotalCount, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetActivityLog",new {AControllerID=_controllerID,AActionID=_actionID,AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),ACreationDateFrom=_creationDateFrom,ACreationDateTo=_creationDateTo,AUserName=string.IsNullOrWhiteSpace(_userName) ? _userName : ReplaceArabicWithPersianChars(_userName),ACallType=_callType,AGetTotalCount=_getTotalCount,APageSize=_pageSize,APageIndex=_pageIndex} , timeout );
}

public ResultSet GetActivityLog(Guid? _controllerID, Guid? _actionID, string _userIP, DateTime? _creationDateFrom, DateTime? _creationDateTo, string _userName, short? _callType, bool? _getTotalCount, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetActivityLog(_controllerID, _actionID, _userIP, _creationDateFrom, _creationDateTo, _userName, _callType, _getTotalCount, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetAction

public System.Data.SqlClient.SqlCommand GetCommand_GetAction(Guid? _id, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetActionAsync(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetAction(_id, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetActionDapperAsync<T>(Guid? _id, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetAction",new {AID=_id} , timeout );
}

public ResultSet GetAction(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetAction(_id, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetController

public System.Data.SqlClient.SqlCommand GetCommand_GetController(Guid? _id, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetController", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetControllerAsync(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetController(_id, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetControllerDapperAsync<T>(Guid? _id, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetController",new {AID=_id} , timeout );
}

public ResultSet GetController(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetController(_id, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region ModifyExcludedAction

public System.Data.SqlClient.SqlCommand GetCommand_ModifyExcludedAction(bool? _isNewRecord, Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spModifyExcludedAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AIsNewRecord", IsOutput = false, Value = _isNewRecord == null ? DBNull.Value : (object)_isNewRecord }, 
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> ModifyExcludedActionAsync(bool? _isNewRecord, Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
	using(var cmd = GetCommand_ModifyExcludedAction(_isNewRecord, _id, _applicationID, _actionName, _controllerName, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> ModifyExcludedActionDapperAsync<T>(bool? _isNewRecord, Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spModifyExcludedAction",new {AIsNewRecord=_isNewRecord,AID=_id,AApplicationID=_applicationID,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName)} , timeout );
}

public ResultSet ModifyExcludedAction(bool? _isNewRecord, Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
	using(var cmd = GetCommand_ModifyExcludedAction(_isNewRecord, _id, _applicationID, _actionName, _controllerName, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region CreateBlockedUser

public System.Data.SqlClient.SqlCommand GetCommand_CreateBlockedUser(Guid? _id, Guid? _userID, string _userIP, int? _blockDays, string _description, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spCreateBlockedUser", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AUserID", IsOutput = false, Value = _userID == null ? DBNull.Value : (object)_userID }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@ABlockDays", IsOutput = false, Value = _blockDays == null ? DBNull.Value : (object)_blockDays }, 
					new Parameter { Name = "@ADescription", IsOutput = false, Value = string.IsNullOrWhiteSpace(_description) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_description) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> CreateBlockedUserAsync(Guid? _id, Guid? _userID, string _userIP, int? _blockDays, string _description, int? timeout = null)
{
	using(var cmd = GetCommand_CreateBlockedUser(_id, _userID, _userIP, _blockDays, _description, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> CreateBlockedUserDapperAsync<T>(Guid? _id, Guid? _userID, string _userIP, int? _blockDays, string _description, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spCreateBlockedUser",new {AID=_id,AUserID=_userID,AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),ABlockDays=_blockDays,ADescription=string.IsNullOrWhiteSpace(_description) ? _description : ReplaceArabicWithPersianChars(_description)} , timeout );
}

public ResultSet CreateBlockedUser(Guid? _id, Guid? _userID, string _userIP, int? _blockDays, string _description, int? timeout = null)
{
	using(var cmd = GetCommand_CreateBlockedUser(_id, _userID, _userIP, _blockDays, _description, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region CreateActivityLog

public System.Data.SqlClient.SqlCommand GetCommand_CreateActivityLog(Guid? _id, string _controllerName, string _actionName, string _controllerTitle, string _actionTitle, Guid? _positionID, string _userName, byte? _callType, Guid? _clientID, DateTime? _creationDate, int? _duration, byte? _os, string _oSVersion, byte? _browser, string _browserVersion, byte? _deviceType, Guid? _applicationID, Guid? _userID, string _userIP, Guid? _objectID, string _objectJson, byte? _success, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spCreateActivityLog", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerTitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerTitle) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerTitle) }, 
					new Parameter { Name = "@AActionTitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionTitle) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionTitle) }, 
					new Parameter { Name = "@APositionID", IsOutput = false, Value = _positionID == null ? DBNull.Value : (object)_positionID }, 
					new Parameter { Name = "@AUserName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userName) }, 
					new Parameter { Name = "@ACallType", IsOutput = false, Value = _callType == null ? DBNull.Value : (object)_callType }, 
					new Parameter { Name = "@AClientID", IsOutput = false, Value = _clientID == null ? DBNull.Value : (object)_clientID }, 
					new Parameter { Name = "@ACreationDate", IsOutput = false, Value = _creationDate == null ? DBNull.Value : (object)_creationDate }, 
					new Parameter { Name = "@ADuration", IsOutput = false, Value = _duration == null ? DBNull.Value : (object)_duration }, 
					new Parameter { Name = "@AOS", IsOutput = false, Value = _os == null ? DBNull.Value : (object)_os }, 
					new Parameter { Name = "@AOSVersion", IsOutput = false, Value = string.IsNullOrWhiteSpace(_oSVersion) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_oSVersion) }, 
					new Parameter { Name = "@ABrowser", IsOutput = false, Value = _browser == null ? DBNull.Value : (object)_browser }, 
					new Parameter { Name = "@ABrowserVersion", IsOutput = false, Value = string.IsNullOrWhiteSpace(_browserVersion) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_browserVersion) }, 
					new Parameter { Name = "@ADeviceType", IsOutput = false, Value = _deviceType == null ? DBNull.Value : (object)_deviceType }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AUserID", IsOutput = false, Value = _userID == null ? DBNull.Value : (object)_userID }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@AObjectID", IsOutput = false, Value = _objectID == null ? DBNull.Value : (object)_objectID }, 
					new Parameter { Name = "@AObjectJson", IsOutput = false, Value = string.IsNullOrWhiteSpace(_objectJson) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_objectJson) }, 
					new Parameter { Name = "@ASuccess", IsOutput = false, Value = _success == null ? DBNull.Value : (object)_success }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> CreateActivityLogAsync(Guid? _id, string _controllerName, string _actionName, string _controllerTitle, string _actionTitle, Guid? _positionID, string _userName, byte? _callType, Guid? _clientID, DateTime? _creationDate, int? _duration, byte? _os, string _oSVersion, byte? _browser, string _browserVersion, byte? _deviceType, Guid? _applicationID, Guid? _userID, string _userIP, Guid? _objectID, string _objectJson, byte? _success, int? timeout = null)
{
	using(var cmd = GetCommand_CreateActivityLog(_id, _controllerName, _actionName, _controllerTitle, _actionTitle, _positionID, _userName, _callType, _clientID, _creationDate, _duration, _os, _oSVersion, _browser, _browserVersion, _deviceType, _applicationID, _userID, _userIP, _objectID, _objectJson, _success, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> CreateActivityLogDapperAsync<T>(Guid? _id, string _controllerName, string _actionName, string _controllerTitle, string _actionTitle, Guid? _positionID, string _userName, byte? _callType, Guid? _clientID, DateTime? _creationDate, int? _duration, byte? _os, string _oSVersion, byte? _browser, string _browserVersion, byte? _deviceType, Guid? _applicationID, Guid? _userID, string _userIP, Guid? _objectID, string _objectJson, byte? _success, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spCreateActivityLog",new {AID=_id,AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName),AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerTitle=string.IsNullOrWhiteSpace(_controllerTitle) ? _controllerTitle : ReplaceArabicWithPersianChars(_controllerTitle),AActionTitle=string.IsNullOrWhiteSpace(_actionTitle) ? _actionTitle : ReplaceArabicWithPersianChars(_actionTitle),APositionID=_positionID,AUserName=string.IsNullOrWhiteSpace(_userName) ? _userName : ReplaceArabicWithPersianChars(_userName),ACallType=_callType,AClientID=_clientID,ACreationDate=_creationDate,ADuration=_duration,AOS=_os,AOSVersion=string.IsNullOrWhiteSpace(_oSVersion) ? _oSVersion : ReplaceArabicWithPersianChars(_oSVersion),ABrowser=_browser,ABrowserVersion=string.IsNullOrWhiteSpace(_browserVersion) ? _browserVersion : ReplaceArabicWithPersianChars(_browserVersion),ADeviceType=_deviceType,AApplicationID=_applicationID,AUserID=_userID,AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),AObjectID=_objectID,AObjectJson=string.IsNullOrWhiteSpace(_objectJson) ? _objectJson : ReplaceArabicWithPersianChars(_objectJson),ASuccess=_success} , timeout );
}

public ResultSet CreateActivityLog(Guid? _id, string _controllerName, string _actionName, string _controllerTitle, string _actionTitle, Guid? _positionID, string _userName, byte? _callType, Guid? _clientID, DateTime? _creationDate, int? _duration, byte? _os, string _oSVersion, byte? _browser, string _browserVersion, byte? _deviceType, Guid? _applicationID, Guid? _userID, string _userIP, Guid? _objectID, string _objectJson, byte? _success, int? timeout = null)
{
	using(var cmd = GetCommand_CreateActivityLog(_id, _controllerName, _actionName, _controllerTitle, _actionTitle, _positionID, _userName, _callType, _clientID, _creationDate, _duration, _os, _oSVersion, _browser, _browserVersion, _deviceType, _applicationID, _userID, _userIP, _objectID, _objectJson, _success, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetActions

public System.Data.SqlClient.SqlCommand GetCommand_GetActions(string _name, string _controllerName, string _controllerTitle, string _title, Guid? _applicationID, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetActions", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_name) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_name) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
					new Parameter { Name = "@AControllerTitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerTitle) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerTitle) }, 
					new Parameter { Name = "@ATitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_title) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_title) }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@ASortExp", IsOutput = false, Value = string.IsNullOrWhiteSpace(_sortExp) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_sortExp) }, 
					new Parameter { Name = "@APageSize", IsOutput = false, Value = _pageSize == null ? DBNull.Value : (object)_pageSize }, 
					new Parameter { Name = "@APageIndex", IsOutput = false, Value = _pageIndex == null ? DBNull.Value : (object)_pageIndex }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetActionsAsync(string _name, string _controllerName, string _controllerTitle, string _title, Guid? _applicationID, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetActions(_name, _controllerName, _controllerTitle, _title, _applicationID, _sortExp, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetActionsDapperAsync<T>(string _name, string _controllerName, string _controllerTitle, string _title, Guid? _applicationID, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetActions",new {AName=string.IsNullOrWhiteSpace(_name) ? _name : ReplaceArabicWithPersianChars(_name),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName),AControllerTitle=string.IsNullOrWhiteSpace(_controllerTitle) ? _controllerTitle : ReplaceArabicWithPersianChars(_controllerTitle),ATitle=string.IsNullOrWhiteSpace(_title) ? _title : ReplaceArabicWithPersianChars(_title),AApplicationID=_applicationID,ASortExp=string.IsNullOrWhiteSpace(_sortExp) ? _sortExp : ReplaceArabicWithPersianChars(_sortExp),APageSize=_pageSize,APageIndex=_pageIndex} , timeout );
}

public ResultSet GetActions(string _name, string _controllerName, string _controllerTitle, string _title, Guid? _applicationID, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetActions(_name, _controllerName, _controllerTitle, _title, _applicationID, _sortExp, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetActionWithSerializedObject

public System.Data.SqlClient.SqlCommand GetCommand_GetActionWithSerializedObject(Guid? _id, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetActionWithSerializedObject", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetActionWithSerializedObjectAsync(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetActionWithSerializedObject(_id, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetActionWithSerializedObjectDapperAsync<T>(Guid? _id, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetActionWithSerializedObject",new {AID=_id} , timeout );
}

public ResultSet GetActionWithSerializedObject(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetActionWithSerializedObject(_id, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetControllers

public System.Data.SqlClient.SqlCommand GetCommand_GetControllers(Guid? _applicationID, string _name, string _title, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetControllers", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_name) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_name) }, 
					new Parameter { Name = "@ATitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_title) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_title) }, 
					new Parameter { Name = "@ASortExp", IsOutput = false, Value = string.IsNullOrWhiteSpace(_sortExp) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_sortExp) }, 
					new Parameter { Name = "@APageSize", IsOutput = false, Value = _pageSize == null ? DBNull.Value : (object)_pageSize }, 
					new Parameter { Name = "@APageIndex", IsOutput = false, Value = _pageIndex == null ? DBNull.Value : (object)_pageIndex }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetControllersAsync(Guid? _applicationID, string _name, string _title, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetControllers(_applicationID, _name, _title, _sortExp, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetControllersDapperAsync<T>(Guid? _applicationID, string _name, string _title, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetControllers",new {AApplicationID=_applicationID,AName=string.IsNullOrWhiteSpace(_name) ? _name : ReplaceArabicWithPersianChars(_name),ATitle=string.IsNullOrWhiteSpace(_title) ? _title : ReplaceArabicWithPersianChars(_title),ASortExp=string.IsNullOrWhiteSpace(_sortExp) ? _sortExp : ReplaceArabicWithPersianChars(_sortExp),APageSize=_pageSize,APageIndex=_pageIndex} , timeout );
}

public ResultSet GetControllers(Guid? _applicationID, string _name, string _title, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetControllers(_applicationID, _name, _title, _sortExp, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetActionsWithSerializedObjectByApplicationID

public System.Data.SqlClient.SqlCommand GetCommand_GetActionsWithSerializedObjectByApplicationID(Guid? _applicationID, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetActionsWithSerializedObjectByApplicationID", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetActionsWithSerializedObjectByApplicationIDAsync(Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_GetActionsWithSerializedObjectByApplicationID(_applicationID, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetActionsWithSerializedObjectByApplicationIDDapperAsync<T>(Guid? _applicationID, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetActionsWithSerializedObjectByApplicationID",new {AApplicationID=_applicationID} , timeout );
}

public ResultSet GetActionsWithSerializedObjectByApplicationID(Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_GetActionsWithSerializedObjectByApplicationID(_applicationID, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetActionWithSerializedObjectByApplicationID

public System.Data.SqlClient.SqlCommand GetCommand_GetActionWithSerializedObjectByApplicationID(Guid? _applicationID, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetActionWithSerializedObjectByApplicationID", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetActionWithSerializedObjectByApplicationIDAsync(Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_GetActionWithSerializedObjectByApplicationID(_applicationID, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetActionWithSerializedObjectByApplicationIDDapperAsync<T>(Guid? _applicationID, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetActionWithSerializedObjectByApplicationID",new {AApplicationID=_applicationID} , timeout );
}

public ResultSet GetActionWithSerializedObjectByApplicationID(Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_GetActionWithSerializedObjectByApplicationID(_applicationID, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetActionWithSerializedObjects

public System.Data.SqlClient.SqlCommand GetCommand_GetActionWithSerializedObjects(Guid? _applicationID, string _actionName, string _controllerName, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetActionWithSerializedObjects", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
					new Parameter { Name = "@ASortExp", IsOutput = false, Value = string.IsNullOrWhiteSpace(_sortExp) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_sortExp) }, 
					new Parameter { Name = "@APageSize", IsOutput = false, Value = _pageSize == null ? DBNull.Value : (object)_pageSize }, 
					new Parameter { Name = "@APageIndex", IsOutput = false, Value = _pageIndex == null ? DBNull.Value : (object)_pageIndex }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetActionWithSerializedObjectsAsync(Guid? _applicationID, string _actionName, string _controllerName, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetActionWithSerializedObjects(_applicationID, _actionName, _controllerName, _sortExp, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetActionWithSerializedObjectsDapperAsync<T>(Guid? _applicationID, string _actionName, string _controllerName, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetActionWithSerializedObjects",new {AApplicationID=_applicationID,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName),ASortExp=string.IsNullOrWhiteSpace(_sortExp) ? _sortExp : ReplaceArabicWithPersianChars(_sortExp),APageSize=_pageSize,APageIndex=_pageIndex} , timeout );
}

public ResultSet GetActionWithSerializedObjects(Guid? _applicationID, string _actionName, string _controllerName, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetActionWithSerializedObjects(_applicationID, _actionName, _controllerName, _sortExp, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region DeleteActionWithSerializedObject

public System.Data.SqlClient.SqlCommand GetCommand_DeleteActionWithSerializedObject(Guid? _id, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spDeleteActionWithSerializedObject", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> DeleteActionWithSerializedObjectAsync(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_DeleteActionWithSerializedObject(_id, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> DeleteActionWithSerializedObjectDapperAsync<T>(Guid? _id, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spDeleteActionWithSerializedObject",new {AID=_id} , timeout );
}

public ResultSet DeleteActionWithSerializedObject(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_DeleteActionWithSerializedObject(_id, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetBlockActionsByApplicationID

public System.Data.SqlClient.SqlCommand GetCommand_GetBlockActionsByApplicationID(Guid? _applicationID, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetBlockActionsByApplicationID", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetBlockActionsByApplicationIDAsync(Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockActionsByApplicationID(_applicationID, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetBlockActionsByApplicationIDDapperAsync<T>(Guid? _applicationID, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetBlockActionsByApplicationID",new {AApplicationID=_applicationID} , timeout );
}

public ResultSet GetBlockActionsByApplicationID(Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockActionsByApplicationID(_applicationID, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region DeleteBlockAction

public System.Data.SqlClient.SqlCommand GetCommand_DeleteBlockAction(Guid? _id, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spDeleteBlockAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> DeleteBlockActionAsync(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_DeleteBlockAction(_id, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> DeleteBlockActionDapperAsync<T>(Guid? _id, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spDeleteBlockAction",new {AID=_id} , timeout );
}

public ResultSet DeleteBlockAction(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_DeleteBlockAction(_id, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetBlockedUsersHistory

public System.Data.SqlClient.SqlCommand GetCommand_GetBlockedUsersHistory(Guid? _userID, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetBlockedUsersHistory", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AUserID", IsOutput = false, Value = _userID == null ? DBNull.Value : (object)_userID }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@ADateFrom", IsOutput = false, Value = _dateFrom == null ? DBNull.Value : (object)_dateFrom }, 
					new Parameter { Name = "@ADateTo", IsOutput = false, Value = _dateTo == null ? DBNull.Value : (object)_dateTo }, 
					new Parameter { Name = "@APageSize", IsOutput = false, Value = _pageSize == null ? DBNull.Value : (object)_pageSize }, 
					new Parameter { Name = "@APageIndex", IsOutput = false, Value = _pageIndex == null ? DBNull.Value : (object)_pageIndex }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetBlockedUsersHistoryAsync(Guid? _userID, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockedUsersHistory(_userID, _userIP, _dateFrom, _dateTo, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetBlockedUsersHistoryDapperAsync<T>(Guid? _userID, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetBlockedUsersHistory",new {AUserID=_userID,AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),ADateFrom=_dateFrom,ADateTo=_dateTo,APageSize=_pageSize,APageIndex=_pageIndex} , timeout );
}

public ResultSet GetBlockedUsersHistory(Guid? _userID, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockedUsersHistory(_userID, _userIP, _dateFrom, _dateTo, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetBlockActions

public System.Data.SqlClient.SqlCommand GetCommand_GetBlockActions(Guid? _applicationID, string _actionName, string _controllerName, string _userIP, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetBlockActions", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@ASortExp", IsOutput = false, Value = string.IsNullOrWhiteSpace(_sortExp) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_sortExp) }, 
					new Parameter { Name = "@APageSize", IsOutput = false, Value = _pageSize == null ? DBNull.Value : (object)_pageSize }, 
					new Parameter { Name = "@APageIndex", IsOutput = false, Value = _pageIndex == null ? DBNull.Value : (object)_pageIndex }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetBlockActionsAsync(Guid? _applicationID, string _actionName, string _controllerName, string _userIP, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockActions(_applicationID, _actionName, _controllerName, _userIP, _sortExp, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetBlockActionsDapperAsync<T>(Guid? _applicationID, string _actionName, string _controllerName, string _userIP, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetBlockActions",new {AApplicationID=_applicationID,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName),AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),ASortExp=string.IsNullOrWhiteSpace(_sortExp) ? _sortExp : ReplaceArabicWithPersianChars(_sortExp),APageSize=_pageSize,APageIndex=_pageIndex} , timeout );
}

public ResultSet GetBlockActions(Guid? _applicationID, string _actionName, string _controllerName, string _userIP, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockActions(_applicationID, _actionName, _controllerName, _userIP, _sortExp, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetBlockActionByApplicationID

public System.Data.SqlClient.SqlCommand GetCommand_GetBlockActionByApplicationID(Guid? _applicationID, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetBlockActionByApplicationID", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetBlockActionByApplicationIDAsync(Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockActionByApplicationID(_applicationID, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetBlockActionByApplicationIDDapperAsync<T>(Guid? _applicationID, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetBlockActionByApplicationID",new {AApplicationID=_applicationID} , timeout );
}

public ResultSet GetBlockActionByApplicationID(Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockActionByApplicationID(_applicationID, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region UnblockUser

public System.Data.SqlClient.SqlCommand GetCommand_UnblockUser(Guid? _userID, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spUnblockUser", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AUserID", IsOutput = false, Value = _userID == null ? DBNull.Value : (object)_userID }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> UnblockUserAsync(Guid? _userID, int? timeout = null)
{
	using(var cmd = GetCommand_UnblockUser(_userID, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> UnblockUserDapperAsync<T>(Guid? _userID, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spUnblockUser",new {AUserID=_userID} , timeout );
}

public ResultSet UnblockUser(Guid? _userID, int? timeout = null)
{
	using(var cmd = GetCommand_UnblockUser(_userID, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetBlockedUsers

public System.Data.SqlClient.SqlCommand GetCommand_GetBlockedUsers(Guid? _userID, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetBlockedUsers", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AUserID", IsOutput = false, Value = _userID == null ? DBNull.Value : (object)_userID }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@ADateFrom", IsOutput = false, Value = _dateFrom == null ? DBNull.Value : (object)_dateFrom }, 
					new Parameter { Name = "@ADateTo", IsOutput = false, Value = _dateTo == null ? DBNull.Value : (object)_dateTo }, 
					new Parameter { Name = "@APageSize", IsOutput = false, Value = _pageSize == null ? DBNull.Value : (object)_pageSize }, 
					new Parameter { Name = "@APageIndex", IsOutput = false, Value = _pageIndex == null ? DBNull.Value : (object)_pageIndex }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetBlockedUsersAsync(Guid? _userID, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockedUsers(_userID, _userIP, _dateFrom, _dateTo, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetBlockedUsersDapperAsync<T>(Guid? _userID, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetBlockedUsers",new {AUserID=_userID,AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),ADateFrom=_dateFrom,ADateTo=_dateTo,APageSize=_pageSize,APageIndex=_pageIndex} , timeout );
}

public ResultSet GetBlockedUsers(Guid? _userID, string _userIP, DateTime? _dateFrom, DateTime? _dateTo, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockedUsers(_userID, _userIP, _dateFrom, _dateTo, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetBlockAction

public System.Data.SqlClient.SqlCommand GetCommand_GetBlockAction(Guid? _id, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetBlockAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetBlockActionAsync(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockAction(_id, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetBlockActionDapperAsync<T>(Guid? _id, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetBlockAction",new {AID=_id} , timeout );
}

public ResultSet GetBlockAction(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockAction(_id, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetBlockedUser

public System.Data.SqlClient.SqlCommand GetCommand_GetBlockedUser(Guid? _id, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetBlockedUser", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetBlockedUserAsync(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockedUser(_id, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetBlockedUserDapperAsync<T>(Guid? _id, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetBlockedUser",new {AID=_id} , timeout );
}

public ResultSet GetBlockedUser(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockedUser(_id, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region ModifyBlockAction

public System.Data.SqlClient.SqlCommand GetCommand_ModifyBlockAction(bool? _isNewRecord, Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spModifyBlockAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AIsNewRecord", IsOutput = false, Value = _isNewRecord == null ? DBNull.Value : (object)_isNewRecord }, 
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@ALimitPerMinute", IsOutput = false, Value = _limitPerMinute == null ? DBNull.Value : (object)_limitPerMinute }, 
					new Parameter { Name = "@ALimitPerHour", IsOutput = false, Value = _limitPerHour == null ? DBNull.Value : (object)_limitPerHour }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> ModifyBlockActionAsync(bool? _isNewRecord, Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
	using(var cmd = GetCommand_ModifyBlockAction(_isNewRecord, _id, _applicationID, _actionName, _controllerName, _userIP, _limitPerMinute, _limitPerHour, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> ModifyBlockActionDapperAsync<T>(bool? _isNewRecord, Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spModifyBlockAction",new {AIsNewRecord=_isNewRecord,AID=_id,AApplicationID=_applicationID,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName),AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),ALimitPerMinute=_limitPerMinute,ALimitPerHour=_limitPerHour} , timeout );
}

public ResultSet ModifyBlockAction(bool? _isNewRecord, Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
	using(var cmd = GetCommand_ModifyBlockAction(_isNewRecord, _id, _applicationID, _actionName, _controllerName, _userIP, _limitPerMinute, _limitPerHour, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetBlockeds

public System.Data.SqlClient.SqlCommand GetCommand_GetBlockeds(string _userIP, Guid? _userID, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetBlockeds", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@AUserID", IsOutput = false, Value = _userID == null ? DBNull.Value : (object)_userID }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetBlockedsAsync(string _userIP, Guid? _userID, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockeds(_userIP, _userID, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetBlockedsDapperAsync<T>(string _userIP, Guid? _userID, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetBlockeds",new {AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),AUserID=_userID} , timeout );
}

public ResultSet GetBlockeds(string _userIP, Guid? _userID, int? timeout = null)
{
	using(var cmd = GetCommand_GetBlockeds(_userIP, _userID, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetExcludedAction

public System.Data.SqlClient.SqlCommand GetCommand_GetExcludedAction(Guid? _id, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetExcludedAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetExcludedActionAsync(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetExcludedAction(_id, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetExcludedActionDapperAsync<T>(Guid? _id, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetExcludedAction",new {AID=_id} , timeout );
}

public ResultSet GetExcludedAction(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_GetExcludedAction(_id, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetExcludedActions

public System.Data.SqlClient.SqlCommand GetCommand_GetExcludedActions(Guid? _applicationID, string _actionName, string _controllerName, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetExcludedActions", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
					new Parameter { Name = "@ASortExp", IsOutput = false, Value = string.IsNullOrWhiteSpace(_sortExp) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_sortExp) }, 
					new Parameter { Name = "@APageSize", IsOutput = false, Value = _pageSize == null ? DBNull.Value : (object)_pageSize }, 
					new Parameter { Name = "@APageIndex", IsOutput = false, Value = _pageIndex == null ? DBNull.Value : (object)_pageIndex }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetExcludedActionsAsync(Guid? _applicationID, string _actionName, string _controllerName, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetExcludedActions(_applicationID, _actionName, _controllerName, _sortExp, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetExcludedActionsDapperAsync<T>(Guid? _applicationID, string _actionName, string _controllerName, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetExcludedActions",new {AApplicationID=_applicationID,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName),ASortExp=string.IsNullOrWhiteSpace(_sortExp) ? _sortExp : ReplaceArabicWithPersianChars(_sortExp),APageSize=_pageSize,APageIndex=_pageIndex} , timeout );
}

public ResultSet GetExcludedActions(Guid? _applicationID, string _actionName, string _controllerName, string _sortExp, int? _pageSize, int? _pageIndex, int? timeout = null)
{
	using(var cmd = GetCommand_GetExcludedActions(_applicationID, _actionName, _controllerName, _sortExp, _pageSize, _pageIndex, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region AddController

public System.Data.SqlClient.SqlCommand GetCommand_AddController(Guid? _id, string _controllerName, Guid? _applicationID, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spAddController", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> AddControllerAsync(Guid? _id, string _controllerName, Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_AddController(_id, _controllerName, _applicationID, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> AddControllerDapperAsync<T>(Guid? _id, string _controllerName, Guid? _applicationID, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spAddController",new {AID=_id,AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName),AApplicationID=_applicationID} , timeout );
}

public ResultSet AddController(Guid? _id, string _controllerName, Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_AddController(_id, _controllerName, _applicationID, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region DeleteExcludedAction

public System.Data.SqlClient.SqlCommand GetCommand_DeleteExcludedAction(Guid? _id, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spDeleteExcludedAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> DeleteExcludedActionAsync(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_DeleteExcludedAction(_id, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> DeleteExcludedActionDapperAsync<T>(Guid? _id, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spDeleteExcludedAction",new {AID=_id} , timeout );
}

public ResultSet DeleteExcludedAction(Guid? _id, int? timeout = null)
{
	using(var cmd = GetCommand_DeleteExcludedAction(_id, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region GetExcludedActionsByApplicationID

public System.Data.SqlClient.SqlCommand GetCommand_GetExcludedActionsByApplicationID(Guid? _applicationID, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spGetExcludedActionsByApplicationID", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> GetExcludedActionsByApplicationIDAsync(Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_GetExcludedActionsByApplicationID(_applicationID, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> GetExcludedActionsByApplicationIDDapperAsync<T>(Guid? _applicationID, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spGetExcludedActionsByApplicationID",new {AApplicationID=_applicationID} , timeout );
}

public ResultSet GetExcludedActionsByApplicationID(Guid? _applicationID, int? timeout = null)
{
	using(var cmd = GetCommand_GetExcludedActionsByApplicationID(_applicationID, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region AddAction

public System.Data.SqlClient.SqlCommand GetCommand_AddAction(Guid? _id, string _actionName, Guid? _applicationID, Guid? _controllerID, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spAddAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AControllerID", IsOutput = false, Value = _controllerID == null ? DBNull.Value : (object)_controllerID }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> AddActionAsync(Guid? _id, string _actionName, Guid? _applicationID, Guid? _controllerID, int? timeout = null)
{
	using(var cmd = GetCommand_AddAction(_id, _actionName, _applicationID, _controllerID, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> AddActionDapperAsync<T>(Guid? _id, string _actionName, Guid? _applicationID, Guid? _controllerID, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spAddAction",new {AID=_id,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AApplicationID=_applicationID,AControllerID=_controllerID} , timeout );
}

public ResultSet AddAction(Guid? _id, string _actionName, Guid? _applicationID, Guid? _controllerID, int? timeout = null)
{
	using(var cmd = GetCommand_AddAction(_id, _actionName, _applicationID, _controllerID, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region UpdateAction

public System.Data.SqlClient.SqlCommand GetCommand_UpdateAction(Guid? _id, string _title, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spUpdateAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@ATitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_title) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_title) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> UpdateActionAsync(Guid? _id, string _title, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateAction(_id, _title, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> UpdateActionDapperAsync<T>(Guid? _id, string _title, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spUpdateAction",new {AID=_id,ATitle=string.IsNullOrWhiteSpace(_title) ? _title : ReplaceArabicWithPersianChars(_title)} , timeout );
}

public ResultSet UpdateAction(Guid? _id, string _title, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateAction(_id, _title, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region UpdateController

public System.Data.SqlClient.SqlCommand GetCommand_UpdateController(Guid? _id, string _name, string _title, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spUpdateController", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_name) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_name) }, 
					new Parameter { Name = "@ATitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_title) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_title) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> UpdateControllerAsync(Guid? _id, string _name, string _title, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateController(_id, _name, _title, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> UpdateControllerDapperAsync<T>(Guid? _id, string _name, string _title, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spUpdateController",new {AID=_id,AName=string.IsNullOrWhiteSpace(_name) ? _name : ReplaceArabicWithPersianChars(_name),ATitle=string.IsNullOrWhiteSpace(_title) ? _title : ReplaceArabicWithPersianChars(_title)} , timeout );
}

public ResultSet UpdateController(Guid? _id, string _name, string _title, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateController(_id, _name, _title, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region UpdateExcludedAction

public System.Data.SqlClient.SqlCommand GetCommand_UpdateExcludedAction(Guid? _id, string _actionName, string _controllerName, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spUpdateExcludedAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> UpdateExcludedActionAsync(Guid? _id, string _actionName, string _controllerName, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateExcludedAction(_id, _actionName, _controllerName, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> UpdateExcludedActionDapperAsync<T>(Guid? _id, string _actionName, string _controllerName, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spUpdateExcludedAction",new {AID=_id,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName)} , timeout );
}

public ResultSet UpdateExcludedAction(Guid? _id, string _actionName, string _controllerName, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateExcludedAction(_id, _actionName, _controllerName, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region UpdateBlockedUser

public System.Data.SqlClient.SqlCommand GetCommand_UpdateBlockedUser(Guid? _id, string _description, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spUpdateBlockedUser", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@ADescription", IsOutput = false, Value = string.IsNullOrWhiteSpace(_description) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_description) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> UpdateBlockedUserAsync(Guid? _id, string _description, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateBlockedUser(_id, _description, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> UpdateBlockedUserDapperAsync<T>(Guid? _id, string _description, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spUpdateBlockedUser",new {AID=_id,ADescription=string.IsNullOrWhiteSpace(_description) ? _description : ReplaceArabicWithPersianChars(_description)} , timeout );
}

public ResultSet UpdateBlockedUser(Guid? _id, string _description, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateBlockedUser(_id, _description, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region UpdateBlockAction

public System.Data.SqlClient.SqlCommand GetCommand_UpdateBlockAction(Guid? _id, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spUpdateBlockAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@ALimitPerMinute", IsOutput = false, Value = _limitPerMinute == null ? DBNull.Value : (object)_limitPerMinute }, 
					new Parameter { Name = "@ALimitPerHour", IsOutput = false, Value = _limitPerHour == null ? DBNull.Value : (object)_limitPerHour }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> UpdateBlockActionAsync(Guid? _id, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateBlockAction(_id, _actionName, _controllerName, _userIP, _limitPerMinute, _limitPerHour, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> UpdateBlockActionDapperAsync<T>(Guid? _id, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spUpdateBlockAction",new {AID=_id,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName),AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),ALimitPerMinute=_limitPerMinute,ALimitPerHour=_limitPerHour} , timeout );
}

public ResultSet UpdateBlockAction(Guid? _id, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateBlockAction(_id, _actionName, _controllerName, _userIP, _limitPerMinute, _limitPerHour, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region UpdateActionWithSerializedObject

public System.Data.SqlClient.SqlCommand GetCommand_UpdateActionWithSerializedObject(Guid? _id, string _actionName, string _controllerName, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spUpdateActionWithSerializedObject", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> UpdateActionWithSerializedObjectAsync(Guid? _id, string _actionName, string _controllerName, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateActionWithSerializedObject(_id, _actionName, _controllerName, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> UpdateActionWithSerializedObjectDapperAsync<T>(Guid? _id, string _actionName, string _controllerName, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spUpdateActionWithSerializedObject",new {AID=_id,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName)} , timeout );
}

public ResultSet UpdateActionWithSerializedObject(Guid? _id, string _actionName, string _controllerName, int? timeout = null)
{
	using(var cmd = GetCommand_UpdateActionWithSerializedObject(_id, _actionName, _controllerName, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region CreateActionWithSerializedObject

public System.Data.SqlClient.SqlCommand GetCommand_CreateActionWithSerializedObject(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spCreateActionWithSerializedObject", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> CreateActionWithSerializedObjectAsync(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
	using(var cmd = GetCommand_CreateActionWithSerializedObject(_id, _applicationID, _actionName, _controllerName, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> CreateActionWithSerializedObjectDapperAsync<T>(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spCreateActionWithSerializedObject",new {AID=_id,AApplicationID=_applicationID,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName)} , timeout );
}

public ResultSet CreateActionWithSerializedObject(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
	using(var cmd = GetCommand_CreateActionWithSerializedObject(_id, _applicationID, _actionName, _controllerName, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region CreateBlockAction

public System.Data.SqlClient.SqlCommand GetCommand_CreateBlockAction(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spCreateBlockAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@ALimitPerMinute", IsOutput = false, Value = _limitPerMinute == null ? DBNull.Value : (object)_limitPerMinute }, 
					new Parameter { Name = "@ALimitPerHour", IsOutput = false, Value = _limitPerHour == null ? DBNull.Value : (object)_limitPerHour }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> CreateBlockActionAsync(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
	using(var cmd = GetCommand_CreateBlockAction(_id, _applicationID, _actionName, _controllerName, _userIP, _limitPerMinute, _limitPerHour, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> CreateBlockActionDapperAsync<T>(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spCreateBlockAction",new {AID=_id,AApplicationID=_applicationID,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName),AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),ALimitPerMinute=_limitPerMinute,ALimitPerHour=_limitPerHour} , timeout );
}

public ResultSet CreateBlockAction(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, string _userIP, int? _limitPerMinute, int? _limitPerHour, int? timeout = null)
{
	using(var cmd = GetCommand_CreateBlockAction(_id, _applicationID, _actionName, _controllerName, _userIP, _limitPerMinute, _limitPerHour, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region CreateExcludedAction

public System.Data.SqlClient.SqlCommand GetCommand_CreateExcludedAction(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spCreateExcludedAction", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AApplicationID", IsOutput = false, Value = _applicationID == null ? DBNull.Value : (object)_applicationID }, 
					new Parameter { Name = "@AActionName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_actionName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_actionName) }, 
					new Parameter { Name = "@AControllerName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_controllerName) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_controllerName) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> CreateExcludedActionAsync(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
	using(var cmd = GetCommand_CreateExcludedAction(_id, _applicationID, _actionName, _controllerName, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> CreateExcludedActionDapperAsync<T>(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spCreateExcludedAction",new {AID=_id,AApplicationID=_applicationID,AActionName=string.IsNullOrWhiteSpace(_actionName) ? _actionName : ReplaceArabicWithPersianChars(_actionName),AControllerName=string.IsNullOrWhiteSpace(_controllerName) ? _controllerName : ReplaceArabicWithPersianChars(_controllerName)} , timeout );
}

public ResultSet CreateExcludedAction(Guid? _id, Guid? _applicationID, string _actionName, string _controllerName, int? timeout = null)
{
	using(var cmd = GetCommand_CreateExcludedAction(_id, _applicationID, _actionName, _controllerName, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region ModifyController

public System.Data.SqlClient.SqlCommand GetCommand_ModifyController(Guid? _id, string _name, string _title, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spModifyController", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AName", IsOutput = false, Value = string.IsNullOrWhiteSpace(_name) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_name) }, 
					new Parameter { Name = "@ATitle", IsOutput = false, Value = string.IsNullOrWhiteSpace(_title) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_title) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> ModifyControllerAsync(Guid? _id, string _name, string _title, int? timeout = null)
{
	using(var cmd = GetCommand_ModifyController(_id, _name, _title, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> ModifyControllerDapperAsync<T>(Guid? _id, string _name, string _title, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spModifyController",new {AID=_id,AName=string.IsNullOrWhiteSpace(_name) ? _name : ReplaceArabicWithPersianChars(_name),ATitle=string.IsNullOrWhiteSpace(_title) ? _title : ReplaceArabicWithPersianChars(_title)} , timeout );
}

public ResultSet ModifyController(Guid? _id, string _name, string _title, int? timeout = null)
{
	using(var cmd = GetCommand_ModifyController(_id, _name, _title, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region MoveTempToActivityLog

public System.Data.SqlClient.SqlCommand GetCommand_MoveTempToActivityLog(int? timeout = null)
{
var cmd = base.CreateCommand("alg.spMoveTempToActivityLog", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> MoveTempToActivityLogAsync(int? timeout = null)
{
	using(var cmd = GetCommand_MoveTempToActivityLog(timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> MoveTempToActivityLogDapperAsync<T>(int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spMoveTempToActivityLog",new {} , timeout );
}

public ResultSet MoveTempToActivityLog(int? timeout = null)
{
	using(var cmd = GetCommand_MoveTempToActivityLog(timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region MoveOnlineActivityLogToTemp

public System.Data.SqlClient.SqlCommand GetCommand_MoveOnlineActivityLogToTemp(int? timeout = null)
{
var cmd = base.CreateCommand("alg.spMoveOnlineActivityLogToTemp", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> MoveOnlineActivityLogToTempAsync(int? timeout = null)
{
	using(var cmd = GetCommand_MoveOnlineActivityLogToTemp(timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> MoveOnlineActivityLogToTempDapperAsync<T>(int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spMoveOnlineActivityLogToTemp",new {} , timeout );
}

public ResultSet MoveOnlineActivityLogToTemp(int? timeout = null)
{
	using(var cmd = GetCommand_MoveOnlineActivityLogToTemp(timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

#region ModifyBlockedUser

public System.Data.SqlClient.SqlCommand GetCommand_ModifyBlockedUser(bool? _isNewRecord, Guid? _id, Guid? _userID, string _userIP, int? _blockDays, string _description, int? timeout = null)
{
var cmd = base.CreateCommand("alg.spModifyBlockedUser", 
	System.Data.CommandType.StoredProcedure, 
	new Parameter[]{
					new Parameter { Name = "@AIsNewRecord", IsOutput = false, Value = _isNewRecord == null ? DBNull.Value : (object)_isNewRecord }, 
					new Parameter { Name = "@AID", IsOutput = false, Value = _id == null ? DBNull.Value : (object)_id }, 
					new Parameter { Name = "@AUserID", IsOutput = false, Value = _userID == null ? DBNull.Value : (object)_userID }, 
					new Parameter { Name = "@AUserIP", IsOutput = false, Value = string.IsNullOrWhiteSpace(_userIP) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_userIP) }, 
					new Parameter { Name = "@ABlockDays", IsOutput = false, Value = _blockDays == null ? DBNull.Value : (object)_blockDays }, 
					new Parameter { Name = "@ADescription", IsOutput = false, Value = string.IsNullOrWhiteSpace(_description) ? DBNull.Value : (object)ReplaceArabicWithPersianChars(_description) }, 
	});

			if (timeout != null)
				cmd.CommandTimeout = (int)timeout;
			return cmd;
}

public async Task<ResultSet> ModifyBlockedUserAsync(bool? _isNewRecord, Guid? _id, Guid? _userID, string _userIP, int? _blockDays, string _description, int? timeout = null)
{
	using(var cmd = GetCommand_ModifyBlockedUser(_isNewRecord, _id, _userID, _userIP, _blockDays, _description, timeout))
{
	return new ResultSet(cmd, await ExecuteAsync(cmd), _modelValueBinder);
}
}

public async Task<AppCore.Result<IEnumerable<T>>> ModifyBlockedUserDapperAsync<T>(bool? _isNewRecord, Guid? _id, Guid? _userID, string _userIP, int? _blockDays, string _description, int? timeout = null)
{
	return await  DapperQueryAsync<T>("alg.spModifyBlockedUser",new {AIsNewRecord=_isNewRecord,AID=_id,AUserID=_userID,AUserIP=string.IsNullOrWhiteSpace(_userIP) ? _userIP : ReplaceArabicWithPersianChars(_userIP),ABlockDays=_blockDays,ADescription=string.IsNullOrWhiteSpace(_description) ? _description : ReplaceArabicWithPersianChars(_description)} , timeout );
}

public ResultSet ModifyBlockedUser(bool? _isNewRecord, Guid? _id, Guid? _userID, string _userIP, int? _blockDays, string _description, int? timeout = null)
{
	using(var cmd = GetCommand_ModifyBlockedUser(_isNewRecord, _id, _userID, _userIP, _blockDays, _description, timeout))
{
	return new ResultSet(cmd, Execute(cmd), _modelValueBinder);
}
}

#endregion

}

}
