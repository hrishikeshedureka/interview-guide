using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public interface INotifier
    {
        void SendNotification(string message);
    }
}
