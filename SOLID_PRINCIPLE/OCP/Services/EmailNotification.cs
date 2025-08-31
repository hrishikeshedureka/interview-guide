using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Services
{
    public class EmailNotification : INotifier
    {
        public EmailNotification() {
        
        }

        public void SendNotification(string message)
        {
          Console.WriteLine($"Email notification sent with message: {message}");
        }
    }
}
