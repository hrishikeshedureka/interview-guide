using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IScopedService _scopeService;
        private readonly ISingletonService _singletonService;
        private readonly ITransientService _transientService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IScopedService scopedService, ISingletonService singletonService, ITransientService transientService)
        {
            _logger = logger;
            _scopeService = scopedService;
            _singletonService = singletonService;
            _transientService = transientService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("GetLifetime")]
        public IActionResult Lifetime()
        {
            return Ok(new
            {
                Transient = _transientService.GetOperationId(),
                Transient_2 = _transientService.GetOperationId(),
                Transient_3 = _transientService.GetOperationId(),

                Scope = _scopeService.GetOperationId(),
                Scope_2 = _scopeService.GetOperationId(),
                Scope_3 = _scopeService.GetOperationId(),

                Singleton = _singletonService.GetOperationId(),
                Singleton_2 = _singletonService.GetOperationId(),
                Singleton_3 = _singletonService.GetOperationId()
            });
        }
    }
}
