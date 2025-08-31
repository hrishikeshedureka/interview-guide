using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Services
{
    public class SMSNotification : INotifier
    {
        public SMSNotification()
        {
            // Constructor logic if needed
        }

        public void SendNotification(string message)
        {
           Console.WriteLine($"SMS notification sent with message: {message}");
        }
    }
}
