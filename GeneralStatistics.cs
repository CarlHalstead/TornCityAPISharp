using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace TornCityAPISharp
{
	/// <summary>
	/// This class is used to retrive information about the WHOLE of Torn
	/// </summary>
	public class GeneralStatistics
	{
		private static string generalStatsUrl = "https://api.torn.com/torn/?selections=stats&key=";

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
		public static async Task<TornGeneralStats.TornGeneralBase> GetGeneralStatisticsAsync()
		{
			var t = await Task<TornGeneralStats.TornGeneralBase>.Factory.StartNew(() => GetGeneralStatistics());
			return t;
		}

		/// <summary>
		/// This retrieves inforamtion about ALL available statistics for the WHOLE of Torn
		/// </summary>
		/// <returns></returns>
		[Obsolete("Consider using the Async version within an Async method using await when calling the function")]
		public static TornGeneralStats.TornGeneralBase GetGeneralStatistics()
		{
			if (API.DoesAPIKeyExist() == false) {
				return null;
			}

			using (WebClient wc = new WebClient())
			{
				var json = wc.DownloadString(URL);
				return JsonConvert.DeserializeObject<TornGeneralStats.TornGeneralBase>(json);
			}
		}
	}
}