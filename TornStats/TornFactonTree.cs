using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.TornStats
{
    public class TornFactonTree : ITornStats
    {
        [JsonProperty("upgrades")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<int , Dictionary<int,UpgradeDetails>> Upgrades { get; set; }

        public string GetMethodName()
        {
            return TornMethods.factiontree.ToString();
        }
    }

    public class UpgradeDetails
    {
        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ability")]
        public string Ability { get; set; }

        [JsonProperty("challenge")]
        public string Challenge { get; set; }

        [JsonProperty("base_cost")]
        public int BaseCost { get; set; }
    }
}
