//using Kama.ApiManagement.Helper;
//using Microsoft.AspNetCore.Mvc.Filters;

//namespace Kama.ApiManagement.Attributes;

//public class ActivityLogAttribute : ActionFilterAttribute
//{
//    DateTime startTime;
//    bool isExcludedAction = false;
//    bool activityLogEnabled = false;

//    ActivityLogHelper activityLogHelper;

//    public override void OnActionExecuting(ActionExecutingContext context)
//    {
//        try
//        {
//            startTime = DateTime.Now;

//            activityLogHelper = new ActivityLogHelper(context);

//            activityLogEnabled = activityLogHelper.Setting != null && activityLogHelper.Setting.Enabled;

//            //check if activity log is enabled
//            if (!activityLogEnabled)
//            {
//                base.OnActionExecuting(context);
//                return;
//            }

//            // check if not excluded action
//            isExcludedAction = activityLogHelper.IsExcludedAction();
//            if (isExcludedAction)
//            {
//                base.OnActionExecuting(context);
//                return;
//            }

//            // verify if action or user is blocked Log
//            var verifyResult = activityLogHelper.Verify();
//            if (verifyResult.Success)
//            {
//                if (verifyResult.Data.VerifyResult == Core.Model.ActivityLogVerifyResult.ActionBlocked)
//                {
//                    //context.HttpContext.Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
//                    //context.HttpContext.Response.WriteAsJsonAsync(Result.Failure(-397, "تعداد درخواست ها بیش از حد مجاز است. لطفا دقایقی دیگر تلاش نمایید."));

//                    context.Result = new BadRequestResult();
//                    return;
//                }

//                if (verifyResult.Data.VerifyResult == Core.Model.ActivityLogVerifyResult.UserBlocked)
//                {
//                    //context.HttpContext.Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
//                    //context.HttpContext.Response.WriteAsJsonAsync(Result.Failure(-397, "کاربری شما مسدود شده است. لطفا روزهای آینده تلاش نمایید."));

//                    context.Result = new BadRequestResult();
//                    return;
//                }
//            }

//            // CallType
//            activityLogHelper.GetCallType();

//            // get object
//            activityLogHelper.GetObject();
//        }
//        catch (Exception ex)
//        {

//        }
//    }

//    public override void OnActionExecuted(ActionExecutedContext actionExecutedContext)
//    {
//        try
//        {
//            if (!activityLogEnabled)
//            {
//                base.OnActionExecuted(actionExecutedContext);
//                return;
//            }

//            if (isExcludedAction)
//            {
//                base.OnActionExecuted(actionExecutedContext);
//                return;
//            }

//            // duration
//            activityLogHelper.ActivityLog.Duration = (DateTime.Now - startTime).Milliseconds;

//            // success state
//            activityLogHelper.GetSuccessState(actionExecutedContext);

//            // add log
//            activityLogHelper.AddLog();

//            base.OnActionExecuted(actionExecutedContext);
//        }
//        catch (Exception ex)
//        {
//            //ErrorLogger.LogException(ex);
//            base.OnActionExecuted(actionExecutedContext);
//        }
//    }
//}
////}