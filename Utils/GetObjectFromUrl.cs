using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornCityAPISharp.Utils
{
    public class GetObjectFromUrl
    {
        private ApiCaller apiCaller = new ApiCaller();

        public async Task<T> GetObject<T> (string url)
        {
            string response;
            try
            {
                response = await apiCaller.GET(url);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Getting Response", ex);
            }

            try
            {
                return JsonConvert.DeserializeObject<T>(response);
            }
            catch(Exception ex)
            {
                throw new Exception("Error converting Response " + ex.Message);
            }
        }
    }
}
