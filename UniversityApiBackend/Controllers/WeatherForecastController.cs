using Microsoft.AspNetCore.Mvc;

namespace UniversityApiBackend.Controllers
{
    [ApiController]
<<<<<<< HEAD
<<<<<<< HEAD
    [Route("[controller]")] // localhost:7204/WeatherForecast
=======
    [Route("[controller]")]
>>>>>>> 2e7232a633bf4a597ef4321da9869b479b256789
=======
    [Route("[controller]")]
>>>>>>> 2e7232a633bf4a597ef4321da9869b479b256789
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
<<<<<<< HEAD
<<<<<<< HEAD
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
=======
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
>>>>>>> 2e7232a633bf4a597ef4321da9869b479b256789
=======
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
>>>>>>> 2e7232a633bf4a597ef4321da9869b479b256789

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

<<<<<<< HEAD
<<<<<<< HEAD
        //Method: GET => Get to localhost:7204/WeatherForecast
=======
>>>>>>> 2e7232a633bf4a597ef4321da9869b479b256789
=======
>>>>>>> 2e7232a633bf4a597ef4321da9869b479b256789
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}