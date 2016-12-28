using Newtonsoft.Json;
using System.Collections.Generic;
using TornCityAPISharp.CustomJsonConverter;

namespace TornCityAPISharp.EventsStats
{
	/// <summary>
	/// This class simply holds the list of events
	/// </summary>
	public class EventsBase
	{
        /// <summary>
        /// This is the list of events
        /// </summary>
        [JsonProperty("events")]
        [JsonConverter(typeof(ArrayOrDictionaryConverter))]
        public Dictionary<long, Event> events { get; set; }
	}
}
