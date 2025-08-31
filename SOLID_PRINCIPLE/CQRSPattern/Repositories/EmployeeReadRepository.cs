using CQRSPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Repositories
{
    public class EmployeeReadRepository : IEmployeeReadRepository
    {
        public Employee GetById(int id)
        {
            // Get the employee record from a data store
            // Below is for demo purposes only
            return new Employee()
            {
                Id = 100,
                FirstName = "John",
                LastName = "Smith",
                DateOfBirth = new DateTime(2000, 1, 1),
                Street = "100 Toronto Street",
                City = "Toronto",
                PostalCode = "k1k 1k1"
            };
        }
    }
}
