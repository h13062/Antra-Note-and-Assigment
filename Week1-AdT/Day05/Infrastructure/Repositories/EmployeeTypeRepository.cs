using ApplicationCore.Contract.Repositories;
using ApplicationCore.Entites;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class EmployeeTypeRepository : IEmployeeTypeRepository
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(EmployeeType entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(EmployeeType entity)
        {
            throw new NotImplementedException();
        }
    }
}
