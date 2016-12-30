using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.UserStats
{
    public class UserJobPoints: IUserStatistics
    {
        [JsonProperty("jobs")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<string,int> Jobs { get; set; }

        [JsonProperty("company")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<int, Company> Company { get; set; }

        public string GetMethodName()
        {
            return UserMethods.jobpoints.ToString();
        }
    }
}
