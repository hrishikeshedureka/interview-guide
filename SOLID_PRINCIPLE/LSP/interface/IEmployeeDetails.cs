using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public interface IEmployeeDetails
    {
        void DisplayEmployeeDetails(string name, string position, decimal salary);
        void SalaryDetails(decimal salary);
    }
}
