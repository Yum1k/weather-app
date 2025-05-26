using Weather_App;

class Program
{
    static async Task Main(string[] args)
    {
        var apiClient = new ApiClient();
        var weatherService = new WeatherService();
        var uiHandler = new UIHandler();

        Console.Write("Введите город: ");
        string city = Console.ReadLine();

        string jsonData = await apiClient.GetWeatherJsonAsync(city);

        if (jsonData != null)
        {
            var weather = weatherService.ParseWeather(jsonData);
            uiHandler.ShowWeather(weather);
        }
        else
        {
            Console.WriteLine("Ошибка получения данных.");
        }
    }
}