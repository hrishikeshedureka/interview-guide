using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class HumanWorkerViolatingISP : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Human is eating.");
        }

        public void Sleep()
        {
          Console.WriteLine("Human is sleeping.");
        }

        public void Work()
        {
            Console.WriteLine("Human is working.");
        }
    }
}
