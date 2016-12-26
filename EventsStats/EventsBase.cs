using Newtonsoft.Json;
using System.Collections.Generic;

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
        public Dictionary<long, Event> events { get; set; }
	}
}
