using Newtonsoft.Json;

namespace TornCityAPISharp.TornStats
{
    public class Gyms
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("members")]
        public int Members { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("min_cash")]
        public int MinCash { get; set; }

        [JsonProperty("max_cash")]
        public int MaxCash { get; set; }

        [JsonProperty("min_respect")]
        public int MinRespect { get; set; }

        [JsonProperty("max_respect")]
        public int MaxRespect { get; set; }
    }
}
