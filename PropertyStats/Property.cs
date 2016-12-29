using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.PropertyStats
{
    public class Property
    {
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("property_type")]
        public int TropertyType { get; set; }

        [JsonProperty("happy")]
        public int Happy { get; set; }

        [JsonProperty("upkeep")]
        public int Upkeep { get; set; }

        [JsonProperty("upgrades")]
        public List<string> Upgrades { get; set; }

        [JsonProperty("staff")]
        public List<string> Staff { get; set; }

        [JsonProperty("rented")]
        public Rented Rented { get; set; }

        [JsonProperty("users_living")]
        public string UsersLiving { get; set; }
    }
}
