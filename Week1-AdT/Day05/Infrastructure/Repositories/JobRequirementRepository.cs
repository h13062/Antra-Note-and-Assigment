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
    public class JobRequirementRepository : IJobRequirementRepository
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<JobRequirement>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<JobRequirement> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(JobRequirement entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(JobRequirement entity)
        {
            throw new NotImplementedException();
        }
    }
}
