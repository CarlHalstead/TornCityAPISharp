using Newtonsoft.Json;

namespace TornCityAPISharp.CompanyStats
{
    public class Upgrades
    {
        [JsonProperty("company_size")]
        public int CompanySize { get; set; }

        [JsonProperty("staffroom_size")]
        public string StaffroomSize { get; set; }

        [JsonProperty("storage_size")]
        public string StorageSize { get; set; }

        [JsonProperty("storage_space")]
        public int StorageSpace { get; set; }
    }
}
