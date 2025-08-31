using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Interview1
    {
        //Bird b = new Bird();        //can not create
        //Crow c = new Bird();        //false
        //Sparrow s = new Sparrow();  //true
        //Bird b1 = new Eagle();		//true
    }

    public abstract class Bird
    {
    }

    public class Crow : Bird
    {
    }

    public class Sparrow : Bird
    {
    }

    public class Eagle : Bird
    {
    }
}
