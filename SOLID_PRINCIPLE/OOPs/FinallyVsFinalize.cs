using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPs
{
    public class FinallyVsFinalize
    {
        ~FinallyVsFinalize()
        {
            // Finalizer (destructor) - called by the garbage collector
            Console.WriteLine("In Finalize Method: Object is being finalized.");

            //Called by the garbage collector, not manually.
            //Non - deterministic — you don’t know exactly when it will run.
            //Should be avoided unless absolutely necessary.
            //Use GC.SuppressFinalize(this) in Dispose() to prevent double cleanup
        }

        public void TestFinally()
        {
            try
            {
                Console.WriteLine("In Try Block");
                int x = 10;
                int y = 0;
                int z = x / y; // This will throw DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("In Catch Block: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("In Finally Block: This block always executes.");
                //Notice: The original exception is caught, but the new one from finally crashes the program unless handled.
                //To avoid losing important errors or crashing unexpectedly, wrap risky code inside finally with its own try-catch:
                try
                {
                    // This will throw a new exception
                    int x = int.Parse("not a number");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in finally: " + ex.Message);
                }
            }
        }
      
    }
}
