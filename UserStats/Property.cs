using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Property
    {
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("property_type")]
        public int PropertyType { get; set; }
    }
}
