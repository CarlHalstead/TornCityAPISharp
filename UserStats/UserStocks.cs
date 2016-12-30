using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.UserStats
{
    public class UserStocks:IUserStatistics
    {
        [JsonProperty("stocks")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long,Stock> Stocks { get; set; }

        public string GetMethodName()
        {
            return UserMethods.stocks.ToString();
        }
    }
}
