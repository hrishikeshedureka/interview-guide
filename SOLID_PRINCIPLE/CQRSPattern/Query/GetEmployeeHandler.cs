using CQRSPattern.Model;
using CQRSPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.Query
{
    public class GetEmployeeHandler
    {
        private readonly IEmployeeReadRepository _repo;

        public GetEmployeeHandler(IEmployeeReadRepository repo)
        {
            _repo = repo;
        }

        public Employee Handle(GetEmployeeQuery query)
        {
            return _repo.GetById(query.Id);
        }   
    }
}
