using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    #region We cannot create an instance of an abstract class. So, what is the use of a constructor in an abstract class?
    public abstract class AbstractClassDemo
    {
        protected string Name;
        public AbstractClassDemo(string name)
        {
            Name = name;
            Console.WriteLine("AbstractClassDemo constructor called");
        }
        public abstract void Display(); // Abstract method, must be implemented by derived classes
    }

    public class DerivedClass : AbstractClassDemo
    {
        public DerivedClass(string name) : base(name)
        {
            Console.WriteLine("DerivedClass constructor");
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
    #endregion

}
