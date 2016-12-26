using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace TornCityAPISharp
{
	public class FactionStatistics
	{
		public enum FactionData
		{
			ID,
			name,
			leader,
			best_chain,
			respect,
			rank
		}

		private static string generalStatsUrl = "https://api.torn.com/faction/?selections=&key=";

		/// <summary>
		/// The URL for the general stats
		/// </summary>
		public static string URL
		{
			get { return (generalStatsUrl + API.apiKey); }
		}

		/// <summary>
		/// This retrieves inforamtion about ALL available statistics for the WHOLE of Torn, asynchronously
		/// </summary>
		/// <returns></returns>
		public static async Task<string> GetSimpleFactionStatisticsAsync(FactionData fd)
		{
			var t = await Task<string>.Factory.StartNew(() => GetSimpleFactionStatistics(fd));
			return t;
		}

		/// <summary>
		/// This retrieves inforamtion about ALL available statistics for the WHOLE of Torn
		/// </summary>
		/// <returns></returns>
		[Obsolete("Consider using the Async version within an Async method using await when calling the function")]
		public static string GetSimpleFactionStatistics(FactionData fd)
		{
			if (API.DoesAPIKeyExist() == false) {
				return null;
			}

			using (WebClient wc = new WebClient())
			{
				var json = wc.DownloadString(URL);
				var data = JsonConvert.DeserializeObject<Dictionary<object, object>>(json);
				return data[fd.ToString()].ToString();
			}
		}
	}
}
