using Newtonsoft.Json;
using System.Configuration;
using System.Text;

namespace CivicTransportCard.WinForms.Handler
{
    public static class ApiHandler
    {
        private static readonly string apiURL = ConfigurationManager.AppSettings["baseAPIURL"];
        private static readonly HttpClient client = new HttpClient();
        public static async Task<string> SendAPIPostRequestAsync(string url, object data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"{apiURL}{url}", content);
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }
        public static async Task<string> SendAPIPutRequestAsync(string url, object data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.PutAsync($"{apiURL}{url}", content);
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }
        public static async Task<string> SendAPIGetRequestAsync(string url)
        {
            var response = await client.GetAsync($"{apiURL}{url}");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }
    }
}
