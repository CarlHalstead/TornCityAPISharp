using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornCityAPISharp.TornStats
{
    public class Companies
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public long Cost { get; set; }

        [JsonProperty("default_employees")]
        public int DefaultEmployees { get; set; }

        [JsonProperty("positions")]
        public Dictionary<string,Position> Postions { get; set; }

        [JsonProperty("specials")]
        public Dictionary<string,Specials> Specials { get; set; }

        [JsonProperty("stock")]
        public Dictionary<string, Stock> Stock { get; set; }
    }
}
