using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.UserStats
{
    public class UserMessages:IUserStatistics
    {
        [JsonProperty("messages")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public  Dictionary<long, Message> Messages { get; set; }

        public string GetMethodName()
        {
            return UserMethods.messages.ToString();
        }
    }
}
