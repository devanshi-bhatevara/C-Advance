

namespace C_AdvancedPractice.Events
{
    public class Subscriber
    {
        public void OnNotificationReceived(string message)
        {
            Console.WriteLine("Subscriber received: " + message);
        }
    }
}
