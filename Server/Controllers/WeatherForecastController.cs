using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SignalRExample.Hubs;
using SignalRExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IHubContext<NotifyHub, IHubClient> _hubContext;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IHubContext<NotifyHub, IHubClient> hubContext)
        {
            _logger = logger;
            _hubContext = hubContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public async Task Create(WeatherForecast weatherForecast)
        {
            Notification startNotification = new Notification()
            {
                Type = NotificationType.Start
            };
            await _hubContext.Clients.All.SendMessage(startNotification);

            await Task.Delay(5000);

            Notification completeNotification = new Notification()
            {
                Type = NotificationType.Complete,
                Result = weatherForecast

            };
            await _hubContext.Clients.All.SendMessage(completeNotification);
        }
    }
}
