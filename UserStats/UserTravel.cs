using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class UserTravel:IUserStatistics
    {
        [JsonProperty("travel")]
        public Travel Travel { get; set; }

        public string GetMethodName()
        {
            return UserMethods.travel.ToString();
        }
    }
}