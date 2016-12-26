using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.Utils
{
    public class ApiCaller
    {
        public async Task<string> GET(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            try
            {
                WebResponse response = await request.GetResponseAsync();

                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    string errorText = reader.ReadToEnd();
                    throw new WebException(errorText, ex);
                }
            }
        }
    }
}

