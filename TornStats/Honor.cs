using Newtonsoft.Json;

namespace TornCityAPISharp.TornStats
{
    public class Honor
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("circulation")]
        public int Circulation { get; set; }
    }
}
