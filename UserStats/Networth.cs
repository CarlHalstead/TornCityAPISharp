using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Networth
    {
        [JsonProperty("pending")]
        public long? Pending { get; set; }

        [JsonProperty("wallet")]
        public long? Wallet { get; set; }

        [JsonProperty("bank")]
        public long? Bank { get; set; }

        [JsonProperty("points")]
        public int? Points { get; set; }

        [JsonProperty("cayman")]
        public long? Cayman { get; set; }

        [JsonProperty("vault")]
        public int? Vault { get; set; }

        [JsonProperty("items")]
        public int? Items { get; set; }

        [JsonProperty("displaycase")]
        public int? Displaycase { get; set; }

        [JsonProperty("bazaar")]
        public int? Bazaar { get; set; }

        [JsonProperty("properties")]
        public int? Properties { get; set; }

        [JsonProperty("stockmarket")]
        public long? Stockmarket { get; set; }

        [JsonProperty("auctionhouse")]
        public int? Auctionhouse { get; set; }

        [JsonProperty("company")]
        public long? Company { get; set; }

        [JsonProperty("bookie")]
        public long? Bookie { get; set; }

        [JsonProperty("loan")]
        public int? Loan { get; set; }

        [JsonProperty("unpaidfees")]
        public int? Unpaidfees { get; set; }

        [JsonProperty("total")]
        public long? Total { get; set; }

        [JsonProperty("parsetime")]
        public double? Parsetime { get; set; }
    }
}
