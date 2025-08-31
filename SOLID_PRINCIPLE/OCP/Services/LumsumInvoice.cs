using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Services
{
    public class LumsumInvoice : IGenerateInvoice
    {
        public double GenerateInvoice(double amount)
        {
            Console.WriteLine($"Generating Lumsum invoice with 10% discount for the amount {amount} = {amount - (amount * 10 / 100)} ");
            return amount + (amount * 10 / 100); // 10% discount for lump sum payments
        }
    }
}
