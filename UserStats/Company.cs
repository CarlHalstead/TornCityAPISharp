using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Company
    {
        [JsonProperty("name")]
        string Name { get; set; }

        [JsonProperty("jobpoint")]
        int JobPoint { get; set; }
    }
}
