using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Services
{
    public class PushNotification : INotifier
    {
        public PushNotification() { }

        public void SendNotification(string message)
        {
            Console.WriteLine($"Push notification sent with message: {message}");
        }
    }
}
