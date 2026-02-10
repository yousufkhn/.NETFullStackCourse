namespace NotificationSystemDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public abstract class Notification
    {
        public abstract void Send();

        public void LogNotification()
        {
            System.Console.WriteLine("Loggin Notification");
        }
    }

    public interface IRetryable
    {
        public void Retry(int count);
    }

    public class EmailNotification : Notification, IRetryable
    {
        public override void Send()
        {
            System.Console.WriteLine("Send implementation");
        }

        public void Retry(int count)
        {
            System.Console.WriteLine($"How many retry available : {count}");
        }
    }
}