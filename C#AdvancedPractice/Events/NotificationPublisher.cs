using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice.Events
{
    public delegate void NotifyEventHandler(string message);
    public class NotificationPublisher
    {
        public event NotifyEventHandler Notify;
        public void PublishNotification(string message)
        {
            Console.WriteLine("Publisher is sending notification");
            Notify?.Invoke(message); //if there is any subscriber then invoke this event
        }
    }
}
