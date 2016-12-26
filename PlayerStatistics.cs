using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace TornCityAPISharp
{
	/// <summary>
	/// This class is for retrieving specific player stats
	/// </summary>
	public class PlayerStatistics
	{
		private static string userStatsUrl = "https://api.torn.com/user/?selections=&key=";

		/// <summary>
		/// This property is used to return the full URL which I will get the information from
		/// </summary>
		public static string URL
		{
			get { return (userStatsUrl + API.apiKey); }
		}

		/// <summary>
		/// This retrieves ALL of the stats that the API can give me of YOUR character, asynchronously
		/// </summary>
		/// <returns></returns>
		public static async Task<PlayerStats.PlayerBase> GetPlayerStatisticsAsync()
		{
			var t = await Task<PlayerStats.PlayerBase>.Factory.StartNew(() => GetPlayerStatistics());
			return t;
		}

		/// <summary>
		/// This will retrieve ALL of the stats that the API can give me of YOUR character
		/// </summary>
		/// <returns>Returns your stats</returns>
		[Obsolete("Consider using the Async version within an Async method using await when calling the function")]
		public static PlayerStats.PlayerBase GetPlayerStatistics()
		{
			if (API.DoesAPIKeyExist() == false) {
				return null;
			}

			using (WebClient wc = new WebClient())
			{
				var json = wc.DownloadString(URL);
				return JsonConvert.DeserializeObject<PlayerStats.PlayerBase>(json);
			}
		}

		/// <summary>
		/// The will retirve ALL of the stats that the API can give me of YOUR character, asynchronously
		/// </summary>
		/// <returns></returns>
		public static async Task<PlayerStats.PlayerBase> GetAnotherPlayersStatisticsAsync(int ID)
		{
			var t = await Task<PlayerStats.PlayerBase>.Factory.StartNew(() => GetAnotherPlayersStatistics(ID));
			return t;
		}

		/// <summary>
		/// This will retrive ALL of the stats that the API can give me of ANOTHER character
		/// </summary>
		/// <param name="ID"></param>
		/// <returns>Returns another players stats</returns>
		[Obsolete("Consider using the Async version within an Async method using await when calling the function")]
		public static PlayerStats.PlayerBase GetAnotherPlayersStatistics(int ID)
		{
			if (API.DoesAPIKeyExist() == false) {
				return null;
			}

			using (WebClient wc = new WebClient())
			{
				Console.WriteLine(URL.Insert(26, ID.ToString()));
				var json = wc.DownloadString(URL.Insert(26, ID.ToString()));
				return JsonConvert.DeserializeObject<PlayerStats.PlayerBase>(json);
			}
		}
	}
}