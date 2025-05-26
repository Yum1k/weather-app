using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Weather_App
{
    public class ApiClient
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private const string apiKey = "e25200f69a391237ab2eaa4f130b677b";

        public async Task<string> GetWeatherJsonAsync(string city)
        {
            var url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch
            {
                return null;
            }
        }
    }
}
