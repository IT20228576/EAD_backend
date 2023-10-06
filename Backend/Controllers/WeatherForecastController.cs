using Backend;
using Microsoft.AspNetCore.Mvc;

namespace ChainStoreApi.Controllers;

[ApiController]
[Route("")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("getpuca", Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 1).Select(index => new WeatherForecast
        {
            Name = "puca sududa",
            Summary = "sala sududa"
        })
        .ToArray();
    }
}
