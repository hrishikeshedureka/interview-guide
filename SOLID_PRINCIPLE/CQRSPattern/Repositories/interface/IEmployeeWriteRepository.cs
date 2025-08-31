using CQRSPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Repositories
{
    public interface IEmployeeWriteRepository
    {
        void Save(Employee employee);
    }

    public interface IEmployeeReadRepository
    {
        Employee GetById(int id);
        //IEnumerable<Employee> GetAll();
    }
}
