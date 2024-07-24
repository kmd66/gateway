//using Kama.ApiManagement.Core.Service;
//using Microsoft.AspNetCore.DataProtection.KeyManagement;
//using Microsoft.Extensions.Configuration;
//using Newtonsoft.Json;
//using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
//using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
//using StackExchange.Redis;
//using System.Reflection;

//namespace Kama.ApiManagement;

//[Route("api/[controller]")]
//public class TestRedisController : BaseApiController
//{
//    public TestRedisController(IConnectionMultiplexer connection) => _redisDB = connection.GetDatabase();
    
//    private readonly IDatabase _redisDB;
//    private readonly string _dbName = "test";

//    [AllowAnonymous, HttpPost, Route("Get")]
//    public async Task<Result<RefreshTokenVM>> Get([FromBody] RefreshTokenVM model)
//    {
//        //_redisDB.KeyDelete(_dbName);
//        var token = await _redisDB.HashGetAsync(_dbName, model.ID.ToString());
//        //var toksn = await _redisDB.StringGetAsync(_dbName);

//        var toke1n = await _redisDB.HashLengthAsync(_dbName);
//        var to4ke1n = await _redisDB.HashValuesAsync(_dbName);
//        //var ts = to4ke1n.Select(x=> JsonConvert.DeserializeObject<RefreshTokenVM>(x)).ToList();
//        var t = ConvertFromRedis<RefreshTokenVM>(to4ke1n);
//        if (token.HasValue)
//            return Result<RefreshTokenVM>.Successful(data: Newtonsoft.Json.JsonConvert.DeserializeObject<RefreshTokenVM>(token.ToString()));
//        else
//        return Result<RefreshTokenVM>.Successful(data: null);
//    }
   
//    [AllowAnonymous, HttpPost, Route("GetTop10")]
//    public async Task<Result<SortedSetEntry[]>> GetTop10([FromBody] RefreshTokenVM model)
//    {
//        SortedSetEntry[] values = _redisDB.SortedSetRangeByScoreWithScores(
//            _dbName, order: Order.Descending, take: 10);

//        return Result<SortedSetEntry[]>.Successful(data: values);
//    }

//    [AllowAnonymous, HttpPost, Route("Add")]
//    public async Task<Result> Add([FromBody] RefreshTokenVM model)
//    {
//        model.ID = Guid.NewGuid();
//        await _redisDB.HashSetAsync(_dbName, model.ID.ToString(), Newtonsoft.Json.JsonConvert.SerializeObject(model));
//        await _redisDB.SetAddAsync(_dbName+"a", Newtonsoft.Json.JsonConvert.SerializeObject(model));
//        int i = 0;
//        while (true)
//        {
//            i++;
//            if (i == 1000000)
//            {
//                break;
//            }
//            model.ID = Guid.NewGuid();
//            model.ClientSecret = $"e{i}";
//            await _redisDB.HashSetAsync(_dbName, model.ID.ToString(), Newtonsoft.Json.JsonConvert.SerializeObject(model));
//          //  await _redisDB.StringSetAsync(_dbName + "m", Newtonsoft.Json.JsonConvert.SerializeObject(model));
//        }
//        return Result.Successful();
//    }   

//    [AllowAnonymous, HttpPost, Route("Exists")]
//    public async Task<Result<bool>> Exists([FromBody] RefreshTokenVM model)
//    {
//        var t = await _redisDB.HashExistsAsync(_dbName, model.ID.ToString());
//        return Result<bool>.Successful(data :t);
//    }


//    [AllowAnonymous, HttpPost, Route("Delete")]
//    public async Task<Result<bool>> Delete([FromBody] RefreshTokenVM model)
//    {
//        var t = await _redisDB.HashDeleteAsync(_dbName, model.ID.ToString());
//        return Result<bool>.Successful(data: t);
//    }

   
//    private static List<T> ConvertFromRedis<T>(RedisValue[] hashEntries)
//    {
//        List<T> l = new List<T>();
//        foreach (var hashEntrie in hashEntries)
//            l.Add(JsonConvert.DeserializeObject<T>(hashEntrie));
//        return l;
//    }
//}

