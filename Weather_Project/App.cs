using Library;
using DotEnv.Core;

new EnvLoader().AddEnvFile("API.env").Load();
string API = "API_KEY".GetEnv();

WeatherData weatherData = new(API);
while (true)
{
Console.WriteLine("type the location you want data from");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string area = Console.ReadLine();

Console.WriteLine("write the date in the format of year-mm-dd");
Console.WriteLine("start date");

string start_date = Console.ReadLine(); 
Console.WriteLine("end date (press enter to skip)");
string end_date = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8604 // Possible null reference argument.
weatherData.FetchWeatherData(area, start_date, end_date, "metric", "events", "");
#pragma warning restore CS8604 // Possible null reference argument.

List<WeatherDailyData> weatherDailyData = weatherData.WeatherDailyData;

if (weatherDailyData != null)
{
    foreach ( WeatherDailyData dailyData in weatherDailyData)
    {
        Console.WriteLine($"{dailyData.TempMax}"+"°");

        Console.WriteLine($"{dailyData.TempMin}"+"°");

        Console.WriteLine($"{dailyData.Humidity}"+"%");
    }
}
Console.WriteLine("The name for each station used to collect the data");
Dictionary<string, Station> stations = weatherData.Stations;
if (stations != null)
{
    foreach (var item in stations)
    {
        Station station = item.Value;
        Console.WriteLine($"{station.Name}");
    }
}
Console.WriteLine("press enter to restart");
Console.ReadLine();
}

