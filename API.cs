using System;

namespace TornCityAPISharp
{
	/// <summary>
	/// This class holds some very simple information for the working of the API
	/// </summary>
	public class API
	{
		/// <summary>
		/// This holds a reference to the apiKey that you must provide
		/// </summary>
		public static string apiKey { get; set; }

		/// <summary>
		/// This returns true or false depending on whether the apiKey is real or null/white space
		/// </summary>
		/// <returns>Returns true or false</returns>
		public static bool DoesAPIKeyExist()
		{
			if (string.IsNullOrWhiteSpace(apiKey) == true) {
				Console.WriteLine("You have not given an API Key!");
				return false;
			}
			else {
				return true;
			}
		}
	}


}
