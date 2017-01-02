using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace TornCityAPISharp.TornStats
{
    public class TornItems: ITornStats
    {
        [JsonProperty("items")]
        public Dictionary<int, Item> Items { get; set; }

        public string GetMethodName()
        {
            return TornMethods.items.ToString();
        }
    }
}
