using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatterm
{
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _instance = null;
        private static readonly object _lock = new object();

        public static Singleton GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
            return _instance;
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("Executing some business logic in Singleton class.");
        }
    }

    public sealed class SingletonWithLazyInitialization
    {
        private static readonly Lazy<SingletonWithLazyInitialization> _instance =
            new Lazy<SingletonWithLazyInitialization>(() => new SingletonWithLazyInitialization(), LazyThreadSafetyMode.ExecutionAndPublication);

        private SingletonWithLazyInitialization() { Console.WriteLine("Singleton instance created"); }

        public static SingletonWithLazyInitialization Instance => _instance.Value;


        public void SomeBusinessLogic()
        {
            Console.WriteLine("Executing some business logic in Singleton class.");
        }
    }
}
