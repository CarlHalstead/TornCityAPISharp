using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.CompanyStats
{
    public class News
    {
        [JsonProperty("timestamp")]
        public int timestamp { get; set; }

        [JsonProperty("news")]
        public string news { get; set; }
    }
}
