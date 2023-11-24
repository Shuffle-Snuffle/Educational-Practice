using System;
using System.IO;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string configFilePath = "default_city.txt";
        string defaultCity = "Moscow";
        string city;

        if (args.Length > 0)
        {
            city = args[0];
        }
        else
        {
            if (File.Exists(configFilePath))
            {
                defaultCity = File.ReadAllText(configFilePath);
            }

            Console.WriteLine($"Input new default city name (leave empty to use '{defaultCity}'):");
            string userInput = Console.ReadLine();

            city = (string.IsNullOrWhiteSpace(userInput)) ? defaultCity : userInput;

            File.WriteAllText(configFilePath, city);
        }

        string apiKey = "2119f4db9e5c577caa22b460ea4c1765";
        string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                string response = await client.GetStringAsync(apiUrl);
                DataFromOpenweather weatherData = JsonSerializer.Deserialize<DataFromOpenweather>(response);

                Console.WriteLine($"Weather in {city} on {DateTime.Now.ToShortDateString()}:");
                Console.WriteLine($"Temperature: {weatherData.main.temp - 273.15:F3}°C");
                Console.WriteLine($"Speed of wind: {weatherData.wind.speed}m/s");
                Console.WriteLine($"Description: {weatherData.weather[0].description}");
            }
            catch (HttpRequestException)
            {
                Console.WriteLine($"Error fetching weather data for {city}. Please check the city name and try again.");
            }
        }
    }
}

public class WeatherInfo
{
    public double temp { get; set; }
    public string description { get; set; }
}

public class DataFromOpenweather
{
    public Wind wind { get; set; }
    public WeatherInfo main { get; set; }
    public WeatherInfo[] weather { get; set; }
}

public class Wind
{
    public double speed { get; set; }
}