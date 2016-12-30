using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class UserPersonalStats:IUserStatistics
    {
        [JsonProperty("personalstats")]
        public Personalstats personalstats { get; set; }

        public string GetMethodName()
        {
            return UserMethods.personalstats.ToString();
        }
    }
}

