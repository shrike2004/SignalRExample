namespace SignalRExample.Model
{
    public class Notification
    {
        public NotificationType Type { get; set; }
        public int Progress { get; set; }
        public bool Loading { get; set; }
        public object Result { get; set; }
    }


    public enum NotificationType : int
    {
        Start = 0,
        InProcess,
        Complete,
        Timeout,
        Canceled,
        Failed
    }
}
