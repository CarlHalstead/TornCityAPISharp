using Newtonsoft.Json;
using System;
using System.IO;
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
                throw new Exception("Error Getting Response - " + ex.Message, ex);
            }

            try
            {
                var reader = new JsonTextReader(new StringReader(response));
                bool read = true;

                while(read)
                {
                    if(reader.Read())
                    {
                        if(reader.TokenType == JsonToken.PropertyName)
                        {
                            if(reader.Value.ToString() == "error")
                            {
                                var error = JsonConvert.DeserializeObject<ErrorWrapper>(response);
                                throw new Exception(error.error.code + " " + error.error.error);
                            }

                            read = false;
                        }
                    }else
                    {
                        read = false;
                    }
                }
                return JsonConvert.DeserializeObject<T>(response);
            }
            catch(Exception ex)
            {
                throw new Exception("Error converting Response " + ex.Message,ex);
            }
        }
    }
}
