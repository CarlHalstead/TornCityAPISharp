using System;

namespace TornCityAPISharp.Development
{
	/// <summary>
	/// This class is used for retrieving data about events
	/// </summary>
	public class EventsStatistics
	{
		private static string eventStatsUrl = "https://api.torn.com/user/?selections=events&key=";

		/// <summary>
		/// The URL for the events
		/// </summary>
		public static string URL
		{
			get { return (eventStatsUrl + API.apiKey); }
		}

		/// <summary>
		/// This will retrieve a list of all of the events you have.
		/// Does not work on other players
		/// </summary>
		/// <returns></returns>
		public static void GetEventStatistics()
		{
			throw new NotImplementedException("In development!");
		}
	}
}
