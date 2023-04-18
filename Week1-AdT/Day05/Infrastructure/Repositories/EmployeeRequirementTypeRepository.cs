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
    public class EmployeeRequirementTypeRepository : IEmployeeRequirementTypeRepository
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeRequirementType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeRequirementType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(EmployeeRequirementType entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(EmployeeRequirementType entity)
        {
            throw new NotImplementedException();
        }
    }
}
