//using Microsoft.AspNetCore.Mvc;
//using System.Net.Http;
//using System.Net;
//using Microsoft.Extensions.Primitives;
//using Newtonsoft.Json.Linq;
//using System;
//using Kama.ApiManagement.Core.Model;
//using Kama.ApiManagement.Helper;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Kama.ApiManagement.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ValuesController1 : ControllerBase
//    {
//        [AllowAnonymous]
//        [HttpPost, Route("~/ha1")]
//        public async Task<IActionResult> Routes([FromBody] dynamic model)
//        {
//                var
//            _apiRequest = new ApiRequest();
//            HttpResponseMessage result = await _apiRequest.PostHttpResponseMessage(model, "http://localhost:2548/api/Defult/Logout1/");

//            // Here we ask the framework to dispose the response object a the end of the user resquest
//            this.HttpContext.Response.RegisterForDispose(result);

//            return new HttpResponseMessageResult(result);
//        }
//    }
//    public class HttpResponseMessageResult : IActionResult
//    {
//        private readonly HttpResponseMessage _responseMessage;

//        public HttpResponseMessageResult(HttpResponseMessage responseMessage)
//        {
//            _responseMessage = responseMessage; // could add throw if null
//        }

//        public async Task ExecuteResultAsync(ActionContext context)
//        {
//            context.HttpContext.Response.StatusCode = (int)_responseMessage.StatusCode;

//            foreach (var header in _responseMessage.Headers)
//            {
//                context.HttpContext.Response.Headers.TryAdd(header.Key, new StringValues(header.Value.ToArray()));
//            }

//            if (_responseMessage.Content != null)
//            {
//                using (var stream = await _responseMessage.Content.ReadAsStreamAsync())
//                {
//                    await stream.CopyToAsync(context.HttpContext.Response.Body);
//                    await context.HttpContext.Response.Body.FlushAsync();
//                }
//            }
//        }
//    }
//}
