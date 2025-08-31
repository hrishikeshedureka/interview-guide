using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.services
{
    public class PermanentEmployee : IEmployeeDetails, IEmployeeBonusDetails
    {
        public void CalculateBonus(decimal salary, decimal bonusPercentage)
        {
            Console.WriteLine($"Bonus for salary {salary:C} at {bonusPercentage:P} is: {salary * bonusPercentage}");
        }

        public void DisplayEmployeeDetails(string name, string position, decimal salary)
        {
            Console.WriteLine($"Name: {name}, Position: {position}, Salary: {salary:C}");
        }

        public void SalaryDetails(decimal salary)
        {
            Console.WriteLine($"Salary Details: {salary:C}");
        }
    }

    public class TemporaryEmployee : IEmployeeDetails, IEmployeeBonusDetails
    {
        public void CalculateBonus(decimal salary, decimal bonusPercentage)
        {
            Console.WriteLine($"Temporary Employee Bonus for salary {salary:C} at {bonusPercentage:P} is: {salary * bonusPercentage}");
        }
        public void DisplayEmployeeDetails(string name, string position, decimal salary)
        {
            Console.WriteLine($"Temporary Employee - Name: {name}, Position: {position}, Salary: {salary:C}");
        }
        public void SalaryDetails(decimal salary)
        {
            Console.WriteLine($"Temporary Employee Salary Details: {salary:C}");
        }
    }
    

    public class ContractEmployee : IEmployeeDetails
    {
        public void DisplayEmployeeDetails(string name, string position, decimal salary)
        {
            Console.WriteLine($"Contract Employee - Name: {name}, Position: {position}, Salary: {salary:C}");
        }
        public void SalaryDetails(decimal salary)
        {
            Console.WriteLine($"Contract Employee Salary Details: {salary:C}");
        }
    }
}
