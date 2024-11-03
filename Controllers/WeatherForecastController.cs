using Microsoft.AspNetCore.Mvc;
using System.Net;
using Wether_api.Interfaces;
using Wether_api.Models;

namespace Wether_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
    

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeather _weather;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeather weather)
        {
            _logger = logger;
            _weather = weather;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Weather> Get()
        {
          return _weather.GetWeathers();
        }
        [HttpGet("{city}", Name = "GetWeatherByCity")]
        public Weather Get(string city)
        {
            var weather = _weather.GetWeatherByCity(city);

            if(weather == null)
            {
                Response.StatusCode = (int)HttpStatusCode.NotFound;
                return  new Weather() { City = "Not found" };
            }
            return weather;

        }
    }
}
