using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Services
{
    public class EmployeeService : Employee
    {
        public override void EmployeeDetails()
        {
            Console.WriteLine("Employee Details: Name - John Doe, Position - Software Engineer");
        }

        public override void EmployeeMinSalary()
        {
           Console.WriteLine("Employee Salary: $80,000 per year");
        }

        public override void EmployeeBonus()
        {
            Console.WriteLine("Employee Bonus: $5,000");
        }
    }

    public class TemporaryEmployeeService : Employee
    {
        public override void EmployeeDetails()
        {
            Console.WriteLine("Temporary Employee Details: Name - Jane Smith, Position - Contract Developer");
        }
        public override void EmployeeMinSalary()
        {
            Console.WriteLine("Temporary Employee Salary: $50,000 per year");
        }
        public override void EmployeeBonus()
        {
            Console.WriteLine("Temporary Employee Bonus: $2,000");
        }
    }

    public class ContractEmployeeService : Employee
    {
        public override void EmployeeDetails()
        {
            Console.WriteLine("Intern Employee Details: Name - Alice Johnson, Position - Intern");
        }
        public override void EmployeeMinSalary()
        {
            Console.WriteLine("Intern Employee Salary: $30,000 per year");
        }
        public override void EmployeeBonus()
        {
            throw new NotImplementedException("Interns do not receive bonuses and this is violating LSP.");
        }
    }
}
