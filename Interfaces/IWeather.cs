using Wether_api.Models;

namespace Wether_api.Interfaces
{
    public interface IWeather
    {
        public List<Weather> GetWeathers();
        public Weather GetWeatherByCity(string city);
    }
}
