using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPs
{
    public class RefAndOutDemo
    {
        int x = 5;      //initlializing x and y with some values before pass as reference
        int y = 10;

        public void SwapValues()
        {
            RefDemo refDemo = new RefDemo();
            Console.WriteLine($"Before Swap: x = {x}, y = {y}");

            refDemo.Swap(ref x, ref y);
            
            Console.WriteLine($"After Swap: x = {x}, y = {y}");
        }
        public void CalculateValues()
        {
            int sum;        // no need to initialize sum and product before pass as out parameter
            int product;

            OutDemo outDemo = new OutDemo();
            outDemo.Calculate(x, y, out sum, out product);
            Console.WriteLine($"Sum: {sum}, Product: {product}");
        }
    }


    public class RefDemo
    {
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

    public class OutDemo
    {
        public void Calculate(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }
    }
}
