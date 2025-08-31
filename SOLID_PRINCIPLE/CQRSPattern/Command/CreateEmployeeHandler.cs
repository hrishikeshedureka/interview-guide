using CQRSPattern.Model;
using CQRSPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Command
{
    public class CreateEmployeeHandler
    {
        private readonly IEmployeeWriteRepository _repo;

        public CreateEmployeeHandler(IEmployeeWriteRepository repo)
        {
            _repo = repo;
        }

        public void Handle(CreateEmployeeCommand command)
        {
            var employee = new Employee { Name = command.Name };
            _repo.Save(employee);
        }
    }
}
