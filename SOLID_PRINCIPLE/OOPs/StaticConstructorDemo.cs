using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPs
{
    public class StaticConstructorDemo
    {

        static StaticConstructorDemo()
        {

        }
    }


    //we can use static constructor to initialize static data members or to perform a particular action that needs to be performed only once.
    //like singleton pattern
    public class Logger
    {
        private static readonly Logger _instance;
        static Logger()
        {
            _instance = new Logger();
        }
        private Logger() { }
        public static Logger Instance => _instance;
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

}
