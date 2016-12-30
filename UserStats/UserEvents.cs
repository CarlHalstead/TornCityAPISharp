using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.UserStats
{
    public class UserEvents:IUserStatistics
    {
        [JsonProperty("events")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Event> Events { get; set;}

        public string GetMethodName()
        {
            return UserMethods.events.ToString();
        }
    }
}
