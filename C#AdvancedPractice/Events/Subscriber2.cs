using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice.Events
{
    public class Subscriber2
    {
        public void OnNotificationReceived(string message)
        {
            Console.WriteLine("Subscriber2 received: " + message);
        }
    }
}
