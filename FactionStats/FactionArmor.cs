using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.Enums;
using System;

namespace TornCityAPISharp.FactionStats
{
    public class FactionArmor : IFactionStatistics
    {
        [JsonProperty("armor")]
        public List<Item> Armor { get; set; }

        public string GetMethodName()
        {
            return FactionMethods.armor.ToString(); ;
        }
    }
}
