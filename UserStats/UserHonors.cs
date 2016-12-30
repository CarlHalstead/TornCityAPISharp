using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class UserHonors:IUserStatistics
    {
        [JsonProperty("honors_awarded")]
        public List<int> HonorsAwarded { get; set; }

        [JsonProperty("honors_time")]
        public List<int> HonorsTime { get; set; }

        public string GetMethodName()
        {
            return UserMethods.honors.ToString();
        }
    }
}
