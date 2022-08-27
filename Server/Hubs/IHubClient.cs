using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRExample.Hubs
{
    public interface IHubClient
    {
        Task SendMessage(object message);
    }
}
