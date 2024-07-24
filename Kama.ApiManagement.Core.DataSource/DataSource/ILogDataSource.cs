using Kama.ApiManagement.Core.Model;
using Kama.AppCore;

namespace Kama.ApiManagement.Core.DataSource
{
    public interface ILogDataSource : IDataSource
    {
        Task<Result<Core.Model.Action>> ActionAddAsync(Core.Model.Action model);
        Task<Result<IEnumerable<Core.Model.Action>>> ActionListAsync(ActionListVM model);
        Task<Result<Core.Model.Controller>> ControllerAddAsync(Core.Model.Controller model);
        Task<Result<IEnumerable<Core.Model.Controller>>> ControllerListAsync(ControllerListVM model);
        Task<Result> AddDb(Core.Model.ActivityLogAddVM model);
    }
}
