using Weather_App;

class Program
{
    static async Task Main(string[] args)
    {

        Console.Write("Введите город: ");
        string city = Console.ReadLine();
        Console.Write("Введите ваш ключ API: ");
        string apiKey = Console.ReadLine();

        var apiClient = new ApiClient(apiKey);
        var weatherService = new WeatherService();
        var uiHandler = new UIHandler();

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