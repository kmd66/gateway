//using Microsoft.AspNetCore.Mvc.Filters;
//using Microsoft.AspNetCore.Routing;
//using System.Collections;
//using Microsoft.AspNetCore.Mvc.Controllers;
//using Microsoft.Extensions.DependencyInjection;
//using System.Reflection;
//using Microsoft.Extensions.Caching.Memory;
//namespace Kama.ApiManagement.Helper;

//public class ActivityLogHelper
//{
//    protected readonly Core.IRequestInfo _requestInfo;

//    protected readonly Core.Model.ActivityLogSetting activityLogSetting;

//    protected ActionExecutingContext _context;
//    protected ControllerActionDescriptor controllerActionDescriptor;
//    protected Core.Model.ActivityLogAddVM activityLog;

//    public Core.Model.ActivityLogSetting Setting { get { return activityLogSetting; } }

//    public ActivityLogHelper(ActionExecutingContext context)
//    {
//        var configuration = context.HttpContext.RequestServices.GetService<Microsoft.Extensions.Configuration.IConfiguration>();
//        _requestInfo = context.HttpContext.RequestServices.GetService<Core.IRequestInfo>();
//        _context = context;

//        controllerActionDescriptor = (ControllerActionDescriptor)context.ActionDescriptor;

//        _ = bool.TryParse(configuration.GetSection("ActivityLog:Enabled").Value, out bool activityLogEnabled);
//        _ = int.TryParse(configuration.GetSection("ActivityLog:ExcludedActionCacheTimeout").Value, out int excludedActionCacheTimeout);

//        activityLogSetting = new Core.Model.ActivityLogSetting
//        {
//            ActivityLogHost = configuration.GetSection("ActivityLog:ActivityLogHost").Value,
//            Enabled = activityLogEnabled,
//            ExcludedActionCacheTimeout = excludedActionCacheTimeout
//        };

//        _ = Guid.TryParse(configuration.GetSection("AppSettings:ApplicationID").Value, out Guid applicationId);

//        var requestApplicationID = context.HttpContext.Request.Headers["ApplicationID"].FirstOrDefault();
//        if (!string.IsNullOrEmpty(requestApplicationID))
//        {
//            applicationId = new Guid(requestApplicationID);
//        }

//        var controllerName = controllerActionDescriptor.ControllerName;
//        var actionName = controllerActionDescriptor.ActionName;

//        if (controllerActionDescriptor.ControllerName == "Defult")
//        {
//            List<string> pathList = new List<string>();
//            var pathSplit = context.HttpContext.Request.Path.Value.Split('/');
//            foreach (var path in pathSplit)
//            {
//                if (!string.IsNullOrEmpty(path.Replace(" ", "")) 
//                    && path.ToUpper() != "API" 
//                    && path.ToUpper() != "V1")
//                {
//                    pathList.Add(path);
//                }
//            }
//            if (pathList.Count > 2)
//            {
//                controllerName = pathList[1];
//                actionName = pathList[2];
//            }
//        }


//        activityLog = new Core.Model.ActivityLogAddVM
//        {
//            ControllerName = controllerName,
//            ActionName = actionName,
//            UserIP = _requestInfo?.RemoteIP,
//            PositionID = _requestInfo?.PositionId,
//            UserID = _requestInfo?.UserId,
//            UserName = _requestInfo?.UserName,
//            ApplicationID = applicationId,
//            ClientID = _requestInfo?.ClientId
//        };
//    }

//    public Core.Model.ActivityLogAddVM ActivityLog
//        => activityLog;

//    public void AddLog()
//    {
//        var route = "api/ActivityLog/AddDb";
//        var httpClient = new Kama.Library.Helper.HttpClient();
//        var headers = GetHeaders();

//        httpClient.PostAsync<IEnumerable<Core.Model.ExcludedAction>>(Setting.ActivityLogHost, route, headers, activityLog);
//    }

//    public Result<Core.Model.ActivityLogVerify> Verify()
//    {
//        //var route = $"api/ActivityLog/Verify";
//        //var httpClient = new Kama.Library.Helper.HttpClient();
//        //var headers = GetHeaders();

//        //var result = Task.Run(async () => await httpClient.PostAsync<Core.Model.ActivityLogVerify>(Setting.ActivityLogHost, route, headers, activityLog)).Result;

//        //return result;
//        return Result<Core.Model.ActivityLogVerify>.Failure(message: "");
//    }

//    public bool IsExcludedAction()
//    {
//        var excludedActions = ListExcludedActions();
//        if (excludedActions != null
//            && excludedActions.Any(e =>
//            e.ApplicationID == activityLog.ApplicationID
//            && e.ControllerName == activityLog.ControllerName
//            && e.ActionName == activityLog.ActionName))
//            return true;

//        return false;
//    }

//    public void GetObject()
//    {
//        try
//        {
//            var idStr = _context.HttpContext.GetRouteData().Values["id"]?.ToString();
//            if (idStr != null)
//            {
//                Guid.TryParse(idStr, out Guid id);
//                activityLog.ObjectID = id;
//            }

//            if (_context.ActionArguments != null && _context.ActionArguments.Any())
//            {
//                var inputArgument = _context.ActionArguments.FirstOrDefault().Value;
//                if (activityLog.ObjectID == null && inputArgument is object && !(inputArgument is IEnumerable))
//                {
//                    idStr = inputArgument.GetType().GetProperty("ID")?.GetValue(inputArgument, null)?.ToString();

//                    if (!string.IsNullOrEmpty(idStr))
//                    {
//                        Guid.TryParse(idStr, out Guid id);
//                        activityLog.ObjectID = id;
//                    }
//                }

//                activityLog.Object = inputArgument;
//            }

//        }
//        catch (Exception ex)
//        {

//        }
//    }

//    public void GetSuccessState(ActionExecutedContext actionExecutedContext)
//    {
//        activityLog.Success = ResponseStatus.ناموفق;

//        try
//        {
//            var descriptor = (ControllerActionDescriptor)actionExecutedContext.ActionDescriptor;
//            var returnType = descriptor.MethodInfo.ReturnType.FullName;
//            if (returnType != null)
//            {
//                var returnObject = actionExecutedContext.Result as ObjectResult;

//                if (returnObject != null)
//                {
//                    var result = returnObject.Value as Result;

//                    if (result != null && result.Success)
//                    {
//                        activityLog.Success = ResponseStatus.موفق;

//                        var data = result.GetType().GetProperty("Data")?.GetValue(result, null);

//                        if (activityLog.ObjectID == null && data != null && !(data is IEnumerable))
//                        {
//                            var idStr = data.GetType().GetProperty("ID")?.GetValue(data, null)?.ToString();
//                            Guid.TryParse(idStr, out Guid id);
//                            activityLog.ObjectID = id;
//                        }
//                    }
//                }
//            }
//        }
//        catch (Exception ex)
//        {

//        }
//    }

//    public void GetCallType()
//    {
//        activityLog.CallType = CallType.UI;
//        var controllerattrs = controllerActionDescriptor.ControllerTypeInfo.GetCustomAttributes<ActionFilterAttribute>(true).ToList();
//        if (controllerattrs != null && controllerattrs.Count() > 0)
//            activityLog.CallType = controllerattrs.Any(f => f.TypeId.ToString().Contains("WebService")) ? activityLog.CallType = CallType.WebService : activityLog.CallType = CallType.UI;
//    }

//    protected virtual IEnumerable<Core.Model.ExcludedAction> ListExcludedActions()
//    {
//        var activityLogUri = new Uri(Setting.ActivityLogHost);
//        var route = "api/ExcludedAction/ListByApplicationID";

//        var cache = _context.HttpContext.RequestServices.GetService<IMemoryCache>();

//        if (!cache.TryGetValue("ExcludedActions", out IEnumerable<Core.Model.ExcludedAction> excludedActions))
//        {
//            var httpClient = new HttpClient();
//            var headers = GetHeaders();

//            var listResult = Task.Run(() => httpClient.PostAsync<IEnumerable<Core.Model.ExcludedAction>>(Setting.ActivityLogHost, route, headers, new Core.Model.ExcludedActionListVM { })).Result;

//            if (listResult.Success)
//            {
//                excludedActions = listResult.Data;

//                var cacheEntryOptions = new MemoryCacheEntryOptions()
//                                .SetAbsoluteExpiration(TimeSpan.FromSeconds(Setting?.ExcludedActionCacheTimeout ?? 120));

//                cache.Set("ExcludedActions", excludedActions, cacheEntryOptions);
//            }
//        }

//        return excludedActions;
//    }

//    private Dictionary<string, string> GetHeaders()
//    {
//        var headers = new Dictionary<string, string>();

//        headers.Add(Claims.UserAgent, _context.HttpContext.Request.Headers[Claims.UserAgent].FirstOrDefault());
//        headers.Add(Claims.Authorization, _context.HttpContext.Request.Headers[Claims.Authorization].FirstOrDefault());

//        return headers;
//    }

//}