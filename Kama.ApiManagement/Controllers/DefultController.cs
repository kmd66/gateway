using Kama.ApiManagement.Helper;
using Microsoft.AspNetCore.Http;
using Kama.ApiManagement.Core;
using System.Dynamic;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Kama.ApiManagement;

[Infrastructure.Log.ActivityLog]
public class DefultController : ControllerBase
{
    public DefultController(IHttpContextAccessor httpContext,
        IApiHubServerUrl serverUrl)
    {
        _httpContext = httpContext;

        _serverUrl = serverUrl;
        //_serverUrl = new ApiHubServerUrl(_routeDetail.ServerName, _appSettings.ServerType, hub);
        _apiRequest = new ApiRequest();
        //_hub = hub;
    }
    //private readonly IHubContext<ApiHub> _hub;

    private readonly IHttpContextAccessor _httpContext;
    //private readonly AppSettings _appSettings;
    private RouteDetail _routeDetail;
    private readonly IApiHubServerUrl _serverUrl;
    private readonly ApiRequest _apiRequest;

    private async Task<ActionResult<dynamic>> _Request([FromBody] dynamic model, bool post = true)
    {
        _routeDetail = new RouteDetail(_httpContext.HttpContext.Request);
        _serverUrl.SetHostName(_routeDetail.ServerName);

        var baseUrlResult = await _serverUrl.Get();
        if (!baseUrlResult.Success)
            return Result<dynamic>.Failure(code: baseUrlResult.Code, message: baseUrlResult.Message);
        _routeDetail.Url = $"{baseUrlResult.Data}/{_routeDetail.Url}";


        string result = post ?
            await _apiRequest.Post(model, _routeDetail.Url, Request.Headers)
            : await _apiRequest.Get(_routeDetail.Url, Request.Headers);

        return RequestData(model,result);
    }
    private dynamic RequestData(dynamic model, string result)
    {
        return Newtonsoft.Json.JsonConvert.DeserializeObject<ExpandoObject>(result);


        dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject<ExpandoObject>(result);

        if (model?.ToString() != null && model?.ToString() != "")
        {
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<IDictionary<string, object>>(model.ToString());
            if (dictionary.ContainsKey("KamaQuery"))
            {
                IDictionary<string, object> dictionaryResult = data;
                //dictionary["Name"] = "Reza";
                //var t = dictionary["Data"];

                if (dictionaryResult.ContainsKey("Data") && dictionaryResult["Data"] != null)
                {
                    var kamaQuery = dictionary["KamaQuery"];
                    var _modelResult = dictionaryResult["Data"];

                    if (_modelResult is System.Collections.IList && _modelResult.GetType().IsGenericType)
                        dictionaryResult["Data"] = KamaQueryList(_modelResult, kamaQuery);
                    else
                        dictionaryResult["Data"] = KamaQuery(_modelResult, kamaQuery.propertys);

                    //var resultData= dictionaryResult["Data"];

                }
            }
        }
        return data;
    }

    private dynamic KamaQuery(object _modelResult, dynamic propertys)
    {
        IDictionary<string, object> dictionaryReturn = new Dictionary<string, object>();

        var modelResult = Newtonsoft.Json.JsonConvert.DeserializeObject<IDictionary<string, object>>(
            Newtonsoft.Json.JsonConvert.SerializeObject(_modelResult)
            );
        foreach (var property in propertys)
        {
            dictionaryReturn[property.ToString()] = modelResult[property.ToString()];
            //dictionaryReturn[property.ToString()] = "123 "+ property.ToString();

        }
        return dictionaryReturn;
    }
    private dynamic KamaQueryList(object _modelResult, dynamic kamaQuery)
    {
        int top = 0;
        List<dynamic> list = new List<dynamic>();

        foreach (var d in (IList<dynamic>)_modelResult)
        {
            var tt = kamaQuery.top;
            if (kamaQuery.top != null && top == (int)kamaQuery.top)
                break;
            if (kamaQuery.propertys == null)
                list.Add(d);
            else
            {
                IDictionary<string, object> dictionaryReturn = new Dictionary<string, object>();
                var t = Newtonsoft.Json.JsonConvert.DeserializeObject<IDictionary<string, object>>(
                    Newtonsoft.Json.JsonConvert.SerializeObject(d)
                    );
                foreach (var property in kamaQuery.propertys)
                {
                    dictionaryReturn[property.ToString()] = t[property.ToString()];
                    //dictionaryReturn[property.ToString()] = "123 "+ property.ToString();

                }
                list.Add(dictionaryReturn);
            }
            top++;
        }

        return list;
    }


    [AllowAnonymous, HttpPost, Route("~/{servername}/{r1?}/{r2?}/{r3?}/{r4?}/{r5?}/{r6?}/{r7?}/{r8?}/{r9?}")]
    public Task<ActionResult<dynamic>> X([FromBody] dynamic model)
        => _Request(model);


    [AllowAnonymous, HttpGet, Route("~/{servername}/{r1?}/{r2?}/{r3?}/{r4?}/{r5?}/{r6?}/{r7?}/{r8?}/{r9?}")]
    public Task<ActionResult<dynamic>> Y()
        => _Request(null, false);



    [AllowAnonymous, HttpPost, Route("~/GroupRequest")]
    public async Task<ActionResult<dynamic>> GroupRequest([FromBody] GroupRequest model)
    {
        if(model == null || model.Models == null || model.Models.Count == 0)
            return Result<dynamic>.Failure(message: "model null");

        List<dynamic> returnModel = new List<dynamic>();
        foreach (var item in model.Models)
        {
            _routeDetail = new RouteDetail(item.Url);
            _serverUrl.SetHostName(_routeDetail.ServerName);
            var baseUrlResult = await _serverUrl.Get();
            if (!baseUrlResult.Success)
                return Result<dynamic>.Failure(code: baseUrlResult.Code, message: baseUrlResult.Message);
            _routeDetail.Url = $"{baseUrlResult.Data}/{_routeDetail.Url}";
            
            string result = await _apiRequest.Post(item.Model, _routeDetail.Url, Request.Headers);

            dynamic data = RequestData(item.Model, result);


            //IDictionary<string, object> dictionary = data;

            //dictionary["Name"] = "Reza";
            //var t = dictionary["Data"];
            //if (!dictionary.ContainsKey("Data1"))
            //    data.Data1 = "dsdas";
            returnModel.Add(data);
        }

        return Result<dynamic>.Successful(data: returnModel);
    }

}


//{
//  "ServerType": "1",
//  "KamaQuery":{
//    "propertys":["DeploymentMode","ApiSecret"],
    //"top": 5
//  }
//}

//{
//  "models": [
//    {
//      "url": "Salary/api/v1/TestApi/Logout1",
//      "model":{
//         "DeploymentMode": "1"
//      }
//    },
//    {
//      "url": "Salary/api/v1/TestApi/Logout2",
//      "model":{
//         "DeploymentMode": "2"
//      }
//    }
//  ]
//}