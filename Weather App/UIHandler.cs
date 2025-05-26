using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App
{
    public class UIHandler
    {
        public void ShowWeather(WeatherData data)
        {
            Console.WriteLine($"Город: {data.City}");
            Console.WriteLine($"Температура: {data.Temperature}°C");
            Console.WriteLine($"Влажность: {data.Humidity}%");
            Console.WriteLine($"Скорость ветра: {data.WindSpeed} м/с");
            Console.WriteLine($"Дата: {data.Date}");
        }
    }
}
