using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice
{

    public delegate void NotifyDelegate(string message);
    public delegate void NotifyDelegateWithoutInput();
    public delegate int IntegerDelegate();
    public class NotificationServiecDelegates
    {
        public static void SendEmail(string message)
        {
            Console.WriteLine(message);
        }

        public static void SendSms(string message)
        {
            Console.WriteLine(message);
        }

        public static void SendPushNotification(string message)
        {
            Console.WriteLine(message);
        }
        
        public static void SendEmail()
        {
            Console.WriteLine("from email");
        }

        //make sure to handle exceptions so the further methods in the vocation list are executed
        public static void SendSms()
        {
            try
            {
                Console.WriteLine("from sms");
                //throw new NotImplementedException();
        }
            catch {
                Console.WriteLine("Exception occured");
            }
        }

        public static void SendPushNotification()
        {
            Console.WriteLine("from push notification");
        } 
        
        public static int Method1()
        {
            return 1;
        }
          public static int Method2()
        {
            return 2;
        }
   
    }
}
