using System.Net;

namespace TornCityAPISharp.Utils
{
	class Miscellaneous
	{
		public static bool IsInternetWorking()
		{
			try
			{
				using (var client = new WebClient())
				{
					// try to load google.com
					// if it fails, there is no internet
					using (var stream = client.OpenRead("http://www.google.com"))
					{
						return true;
					}
				}
			}
			catch
			{
				return false;
			}
		}
	}
}
