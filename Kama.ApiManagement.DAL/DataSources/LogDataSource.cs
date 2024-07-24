using Kama.Library.Helper.Security;

namespace Kama.ApiManagement.Infrastructure.DAL.DataSources;


public class LogDataSource : DataSource, ILogDataSource
{
    public LogDataSource()
         : base()
    {
    }

    public async Task<Result<Core.Model.Action>> ActionAddAsync(Core.Model.Action model)
    {
        try
        {
            var result = (await alg.AddActionAsync(
                _id: model.ID,
                _applicationID: model.ApplicationID,
                _actionName: model.Name,
                _controllerID: model.ControllerID
                )).ToActionResult<Core.Model.Action>();

            if (result.Success)
                return Result<Core.Model.Action>.Successful(data: model);

            return result;
        }
        catch (Exception e) { throw; }
    }

    public async Task<Result<IEnumerable<Core.Model.Action>>> ActionListAsync(ActionListVM model)
    {
        try
        {
            var result = (await alg.GetActionsAsync(
                   _name: model.Name,
                   _title: model.Title,
                   _controllerName: model.ControllerName,
                   _controllerTitle: model.ControllerTitle,
                   _applicationID: model.ApplicationID,
                   _sortExp: null,
                   _pageIndex: model.PageIndex,
                   _pageSize: model.PageSize
                )).ToListActionResult<Core.Model.Action>();
            return result;
        }
        catch (Exception e) { throw; }
    }

    public async Task<Result<Controller>> ControllerAddAsync(Controller model)
    {
        try
        {
            var result = (await alg.AddControllerAsync(
                _id: model.ID,
                _applicationID: model.ApplicationID,
                _controllerName: model.Name
                )).ToActionResult<Controller>();

            if (result.Success)
                return Result<Controller>.Successful(data: model);

            return result;
        }
        catch (Exception e) { throw; }
    }

    public async Task<Result<IEnumerable<Controller>>> ControllerListAsync(ControllerListVM model)
    {
        try
        {
            var result = await alg.GetControllersDapperAsync<Controller>(
                   _name: model.Name,
                   _title: model.Title,
                   _applicationID: model.ApplicationID,
                   _sortExp: null ,//model.SortExp.ToSortExpString(),
                   _pageIndex: model.PageIndex,
                   _pageSize: model.PageSize
                );
            return result;
        }
        catch (Exception e) { throw; }
    }

    public async Task<Result> AddDb(Core.Model.ActivityLogAddVM model)
    {
        try
        {
            var result = (await alg.CreateActivityLogAsync(
                _id: model.ID,
                _controllerName: model.ControllerName,
                _actionName: model.ActionName,
                _positionID: model.PositionID,
                _applicationID: model.ApplicationID,
                _userID: model.UserID,
                _userIP: model.UserIP,
                _objectID: model.ObjectID,
                _objectJson: _objSerializer.Serialize(model.Object), //.Compress(),
                _success: (byte)model.Success,
                _duration: model.Duration,
                _controllerTitle: model.ControllerTitle,
                _actionTitle: model.ActionTitle,
                _os: (byte)model.OS,
                _oSVersion: model.OSVersion,
                _browser: (byte)model.Browser,
                _browserVersion: model.BrowserVersion,
                _deviceType: (byte)model.DeviceType,
                _userName: model.UserName,
                _callType: (byte)model.CallType,
                _clientID: model.ClientID,
                _creationDate: model.CreationDate
                )).ToActionResult();

            return result;
        }
        catch (Exception e)
        {
            return null;
        }
    }

   
}