using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRExample.Hubs
{
    public class NotifyHub : Hub<IHubClient>
    {
    }
}
