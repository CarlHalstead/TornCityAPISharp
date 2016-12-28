using Newtonsoft.Json;

namespace TornCityAPISharp.FactionStats
{
    public class Item
    {
        /// <summary>
        /// Item Id
        /// </summary>
        [JsonProperty("ID")]
        public int ItemId { get; set; }

        /// <summary>
        /// Item Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Item type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Quantity in stock
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Availeble yes/no
        /// </summary>
        [JsonProperty("available")]
        public bool Available { get; set; }

        /// <summary>
        /// Loaned or not
        /// </summary>
        [JsonProperty("loaned")]
        public bool Loaned { get; set; }

        /// <summary>
        /// Id of the person that loanded this item (can be null)
        /// </summary>
        [JsonProperty("loaned_to")]
        public string LoanedTo { get; set; }
    }
}
