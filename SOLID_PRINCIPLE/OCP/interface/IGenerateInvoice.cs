using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public interface IGenerateInvoice
    {
        double GenerateInvoice(double amount);
    }
}
