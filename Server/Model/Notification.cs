using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRExample.Model
{
    public class Notification
    {
        public NotificationType Type { get; set; }
    }


    public enum NotificationType : int
    {
        Start = 0,
        Complete,
        Timeout,
        Canceled,
        Failed
    }
}
