using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyController.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        // private static readonly string[] Summaries = new[]
        // {
        //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };
        //
        // private readonly ILogger<WeatherForecastController> _logger;
        //
        // public WeatherForecastController(ILogger<WeatherForecastController> logger)
        // {
        //     _logger = logger;
        //     _weatherForecasts = weatherForecasts;
        // }
        
        // [HttpGet]
        //
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //         {
        //             Date = DateTime.Now.AddDays(index),
        //             TemperatureC = rng.Next(-20, 55),
        //             Summary = Summaries[rng.Next(Summaries.Length)]
        //         })
        //         .ToArray();
        // }
        
        private readonly List<WeatherForecast> _weatherForecasts;

        public WeatherForecastController(List<WeatherForecast> weatherForecasts)
        {
            _weatherForecasts = weatherForecasts;
        }

        [HttpPost]
        public IActionResult Post([FromBody] WeatherForecast weatherForecast)
        {
            if (_weatherForecasts.TrueForAll(wf => wf.Date != weatherForecast.Date))
                _weatherForecasts.Add(weatherForecast);
            return Ok();
            
        }

        [HttpPut]
        public IActionResult Put([FromBody] WeatherForecast replace)
        {
            _weatherForecasts.FirstOrDefault(wf => wf.Date == replace.Date)?.CopyData(replace);
            return Ok();
        }
        
        [HttpDelete]
        public IActionResult Delete([FromBody] WeatherForecast weatherForecast)
        {
            _weatherForecasts.Remove(weatherForecast);
            return Ok();
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_weatherForecasts.OrderBy(wf => wf.Date));
        }
    }
}