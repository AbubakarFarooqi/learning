using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_principles.src.SOLID.O.Practice
{

    //class NotificationService
    //{
    //    public void SendNotification(string type, string message)
    //    {
    //        if (type == "Email")
    //        {
    //            Console.WriteLine($"Sending EMAIL: {message}");
    //        }
    //        else if (type == "SMS")
    //        {
    //            Console.WriteLine($"Sending SMS: {message}");
    //        }
    //        else if (type == "Push")
    //        {
    //            Console.WriteLine($"Sending PUSH notification: {message}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Unknown notification type.");
    //        }
    //    }
    //}

    abstract class NotificationService
    {
        public abstract void SendNotification(string msg);
    }
    class EmailNotification : NotificationService
    {
        public override void SendNotification(string msg)
        {
            Console.WriteLine($"Sending Email Notification {msg}");
        }
    }
    class WhatsAppNotification : NotificationService
    {
        public override void SendNotification(string msg)
        {
            Console.WriteLine($"Sending Whatsapp Notification {msg}");
        }
    }
    // rest code

}
