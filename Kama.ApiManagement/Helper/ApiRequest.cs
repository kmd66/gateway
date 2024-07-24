using Microsoft.AspNetCore.Http;
using System.Net;
using System.Net.Http;

namespace Kama.ApiManagement.Helper
{
    public class ApiRequest
    {

        static string ApiKey = "";
        static string ApiSecret = "";
        public static void SetKeys(string apiKey, string apiSecret)
        {
            ApiKey = apiKey;
            ApiSecret = apiSecret;
        }
        public static void SetProperty(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            ApiKey = configuration["AppSettings:ApiKey"];
            ApiSecret = configuration["AppSettings:ApiSecret"];
        }

        public static void ReConnect(ApiServerDetail model)
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    var url = $"{model.Url}/{model.ReconnectingUrl}";
                    setHeder(client, null);
                    string json = "{}";
                    var content = new StringContent("{}", System.Text.Encoding.UTF8, "application/json");
                    var response = client.PostAsync(url, content).Result;
                    var responseString = response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<string> Post(dynamic model, string url, IHeaderDictionary heders)
        {
            var response = await PostHttpResponseMessage(model, url, heders);
            var responseString = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //var responseJsosn = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result);
                var failure = Result.Failure(message: $"ApiRequest Post  Failure {response.StatusCode.ToString()}");
                failure.Code = ((int)response.StatusCode);
                return Newtonsoft.Json.JsonConvert.SerializeObject(failure);
                // = response.StatusCode.;
            }

            return string.IsNullOrEmpty(responseString)? Newtonsoft.Json.JsonConvert.SerializeObject(Result.Successful()) : responseString;
        }

        public async Task<string> Get(string url, IHeaderDictionary heders)
        {
            var response = await GetHttpResponseMessage(url, heders);
            var responseString = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var failure = Result.Failure(message: $"ApiRequest Post  Failure {response.StatusCode.ToString()}");
                failure.Code = ((int)response.StatusCode);
                return Newtonsoft.Json.JsonConvert.SerializeObject(failure);
            }

            return string.IsNullOrEmpty(responseString) ? Newtonsoft.Json.JsonConvert.SerializeObject(Result.Successful()) : responseString;
        }

        public async Task<HttpResponseMessage> PostHttpResponseMessage(dynamic model, string url, IHeaderDictionary heders)
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    setHeder(client, heders);

                    string json = model.ToString();
                    //json = json.Replace(":\"Unknown\"", ":0");

                    var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(url, content);
                    return response;
                }
            }
            catch (Exception e)
            {
                var response = new HttpResponseMessage(HttpStatusCode.BadGateway);
                response.Content = new StringContent(e.Message);
                return response;
            }
        }

        public async Task<HttpResponseMessage> GetHttpResponseMessage(string url, IHeaderDictionary heders)
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    setHeder(client, heders);
                    var response = await client.GetAsync(url);
                    return response;
                }
            }
            catch (Exception e)
            {
                var response = new HttpResponseMessage(HttpStatusCode.BadGateway);
                response.Content = new StringContent(e.Message);
                return response;
            }
        }
        private static void setHeder(System.Net.Http.HttpClient client, IHeaderDictionary heders)
        {
            client.DefaultRequestHeaders.Add(ApiKey, ApiSecret);
            if (heders != null)
                heders?.Distinct().ToList().ForEach(x =>
                {
                    var t = x.Value.First();
                    if (x.Key != "Content-Length" &&
                        x.Key != "Content-Type" && 
                        x.Key != "Authorization" &&
                        x.Key != "Host" && 
                        x.Key != ApiKey )
                        client.DefaultRequestHeaders.Add(x.Key, x.Value.First());
                });
        }
    }
}
