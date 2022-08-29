using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SignalRExample.Hubs;
using SignalRExample.Model;
using SignalRExample.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SignalRExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        Random rng = new Random();
        private readonly IHubContext<NotifyHub, IHubClient> _hubContext;
        private readonly IBackgroundTaskQueue _taskQueue;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IHubContext<NotifyHub, IHubClient> hubContext,
            IBackgroundTaskQueue taskQueue

            )
        {
            _logger = logger;
            _hubContext = hubContext;
            _taskQueue = taskQueue;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public async Task Create()
        {
            Notification startNotification = new Notification()
            {
                Type = NotificationType.Start,
                Loading = true
            };
            await _hubContext.Clients.All.SendMessage(startNotification);
            await _taskQueue.QueueBackgroundWorkItemAsync(CreateWorkItem);
        }


        /// <summary>
        /// https://docs.microsoft.com/ru-ru/aspnet/core/fundamentals/host/hosted-services?view=aspnetcore-6.0&tabs=visual-studio
        /// Раздел "Фоновые задачи в очереди"
        /// </summary>
        private async ValueTask CreateWorkItem(CancellationToken token)
        {
            // Simulate three 2-second tasks to complete
            // for each enqueued work item

            int delayLoop = 0;
            var guid = Guid.NewGuid().ToString();

            _logger.LogInformation("Queued Background Task {Guid} is starting.", guid);

            while (!token.IsCancellationRequested && delayLoop < 3)
            {
                try
                {
                    await Task.Delay(TimeSpan.FromSeconds(2), token);
                }
                catch (OperationCanceledException)
                {
                    // Prevent throwing if the Delay is cancelled
                }

                delayLoop++;
                Notification completeNotification = new Notification()
                {
                    Type = NotificationType.InProcess,
                    Loading = true,
                    Progress = delayLoop * 33
                };
                await _hubContext.Clients.All.SendMessage(completeNotification);
                _logger.LogInformation("Queued Background Task {Guid} is running. "
                                       + "{DelayLoop}/3", guid, delayLoop);
            }

            if (delayLoop == 3)
            {
                _logger.LogInformation("Queued Background Task {Guid} is complete.", guid);
                var item = new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(rng.Next(1, 30)),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                };

                Notification completeNotification = new Notification()
                {
                    Type = NotificationType.Complete,
                    Loading = false,
                    Progress = 100,
                    Result = item,
                };
                await _hubContext.Clients.All.SendMessage(completeNotification);
            }
            else
            {
                _logger.LogInformation("Queued Background Task {Guid} was cancelled.", guid);
            }
        }
    }
}
