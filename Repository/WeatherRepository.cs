using Wether_api.Interfaces;
using Wether_api.Models;

namespace Wether_api.Repository
{
    public class WeatherRepository : IWeather
    {

        private readonly List<Weather> weatherList = new List<Weather>() {
            new Weather() { City = "Dnipro", Description = "Cloudy", Temperature = "20", Humidity = "50", Wind = "10" },
            new Weather() { City = "Nikopol", Description = "Sunny", Temperature = "25", Humidity = "60", Wind = "15" },
            new Weather() { City = "Lviv", Description = "Rainy", Temperature = "15", Humidity = "70", Wind = "5" },
            new Weather() { City = "Kharkiv", Description = "Snowy", Temperature = "10", Humidity = "80", Wind = "20" }
        };


        public Weather GetWeatherByCity(string city)
        {
            var weather = weatherList.FirstOrDefault(x => x.City.ToLower() == city.ToLower());
            return weather;
        }

        public List<Weather> GetWeathers()
        {
           return weatherList;
        }
    }
}
