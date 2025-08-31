using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{

    // Products
    public abstract class Notification
    {
        public abstract void Send(string message);
    }

    //Concrete products
    public class EmailNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine("Sending EMAIL: " + message);
        }
    }
    public class SmsNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }
    public class WhatsAppNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine("Sending Whatsapp: " + message);
        }
    }


    // Creator
    public abstract class NotificationFactory
    {
        public abstract Notification CreateNotification();
    }

    // Concrete Creators
    public class EmailNotificationFactory : NotificationFactory
    {
        public override Notification CreateNotification()
        {
            return new EmailNotification();
        }
    }
    public class SmsNotificationFactory : NotificationFactory
    {
        public override Notification CreateNotification()
        {
            return new SmsNotification();
        }
    }
    public class WhatsAppNotificationFactory : NotificationFactory
    {
        public override Notification CreateNotification()
        {
            return new WhatsAppNotification();
        }
    }
}
