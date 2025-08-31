using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.services
{
    public class Admin : IFileReader, IFileWriter
    {
        public void ReadFile(string message)
        {
           Console.Write(message);
        }

        public void WriteFile(string message)
        {
            Console.Write(message);
        }
    }
}
