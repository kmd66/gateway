using Kama.ApiManagement.Core.Service;

namespace Kama.ApiManagement;

[Route("api/[controller]")]
public class QrController : BaseApiController
{
    public QrController(
        Core.IRequestInfo requestInfo
        , IQrHelper qrHelper
    )
    {
        _requestInfo = requestInfo;
        _qrHelper = qrHelper;
    }
    protected readonly Core.IRequestInfo _requestInfo;
    protected readonly IQrHelper _qrHelper;

    [AllowAnonymous]
    [HttpPost, Route("SetCode")]
    public Task<AppCore.Result<Qr>> SetCode()
    {
        var qr = _qrHelper.SetObjectCache();
        return AppCore.Result<Qr>.SuccessfulAsync(data: qr);
    }

    [AllowAnonymous]
    [HttpPost, Route("CheckCode")]
    public Task<AppCore.Result<Qr>> CheckCode(Qr model)
    {
        var qr = _qrHelper.CheckObjectCache(model.Key);
        if (qr == null)
            return AppCore.Result<Qr>.FailureAsync(message: "ObjectCacheNull");
        return AppCore.Result<Qr>.SuccessfulAsync(data: qr);
    }

    [HttpPost, Route("EditCode")]
    public Task<AppCore.Result<Qr>> EditCode(Qr model)
    {
        var qr = _qrHelper.EditObjectCache(_requestInfo.UserName, model);
        //var qr = QrDirection.EditObjectCache(model.UserName, model);
        return AppCore.Result<Qr>.SuccessfulAsync(data: qr);
    }

}

