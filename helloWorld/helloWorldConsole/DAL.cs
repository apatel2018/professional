using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace helloWorldConsole
{
    /// <summary>
    /// Access data from a source
    /// </summary>
    public class DAL
    {
        /// <summary>
        /// Build a URI (e.g Display or other endpoint)
        /// </summary>
        /// <returns>text that needs to be displayed</returns>
        public string GetTextToDisplay()
        {
            var URI = ConfigurationManager.AppSettings["GetText"].ToString();
            string response = CallGetRestEndpoint(URI);
            return response;
        }

        /// <summary>
        /// Generic method that can be used for all GET requests
        /// </summary>
        /// <param name="URI">Web api method url</param>
        /// <returns></returns>
        private string CallGetRestEndpoint(string URI)
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler()
                {
                    UseDefaultCredentials = true
                };
                using (var client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebAPIurl"].ToString());
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync(URI).Result;
                    var res = response.Content.ReadAsStringAsync().Result;
                    return res;
                }
            }
            catch (Exception ex)
            {
                return (string.Format("Exception in CallGetRestEndpoint URI: {0}, Error: {1} " , URI, ex.Message));                
            }
        }
    }
}
