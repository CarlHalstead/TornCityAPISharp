using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.UserStats
{
    public class Message
    {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("Id")]
        public int MessageID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("seen")]
        public bool Seen { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }
}
