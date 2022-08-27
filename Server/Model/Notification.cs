namespace SignalRExample.Model
{
    public class Notification
    {
        public NotificationType Type { get; set; }
        public object Result { get; set; }
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
