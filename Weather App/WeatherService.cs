using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Weather_App
{
    public class WeatherService
    {
        public WeatherData ParseWeather(string json)
        {
            dynamic data = JsonConvert.DeserializeObject(json);
            return new WeatherData
            {
                City = data.name,
                Temperature = data.main.temp,
                Humidity = data.main.humidity,
                WindSpeed = data.wind.speed,
                Date = UnixTimeStampToDateTime((double)data.dt),
            };
        }

        private DateTime UnixTimeStampToDateTime(double unixTime)
        {
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return dtDateTime.AddSeconds(unixTime).ToLocalTime();
        }
    }
}
