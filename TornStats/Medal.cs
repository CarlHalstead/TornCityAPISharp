using Newtonsoft.Json;

namespace TornCityAPISharp.TornStats
{
    public class Medal
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
