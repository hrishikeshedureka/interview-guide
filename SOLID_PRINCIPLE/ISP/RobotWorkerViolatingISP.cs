using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class RobotWorkerViolatingISP : IWorker
    {
        public void Eat()
        {
           throw new NotImplementedException("Robots do not eat.");
        }

        public void Sleep()
        {
           throw new NotImplementedException("Robots do not sleep.");
        }

        public void Work()
        {
           Console.WriteLine("Robot is working.");
        }
    }
}
