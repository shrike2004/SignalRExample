using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace SignalRExample.Hubs
{
    /// <summary>
    /// https://www.c-sharpcorner.com/article/real-time-angular-11-application-with-signalr-and-net-5/
    /// </summary>
    public class NotifyHub : Hub<IHubClient>
    {
        private readonly ILogger<NotifyHub> _logger;

        public NotifyHub(ILogger<NotifyHub> logger)
        {
            _logger = logger;
        }

        public override Task OnConnectedAsync()
        {
            _logger.LogInformation("Who is connected: " + Context.ConnectionId);
            return base.OnConnectedAsync();
        }
    }
}
