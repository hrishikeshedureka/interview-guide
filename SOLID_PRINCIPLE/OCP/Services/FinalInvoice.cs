using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Services
{
    public class FinalInvoice : IGenerateInvoice
    {
        public double GenerateInvoice(double amount)
        {
            Console.WriteLine($"Generating final invoice with 20% discount for the amount {amount} = {amount - (amount * 20 / 100)} ");
            return amount + (amount * 20 / 100); // 20% discount for final payments
        }
    }
}
