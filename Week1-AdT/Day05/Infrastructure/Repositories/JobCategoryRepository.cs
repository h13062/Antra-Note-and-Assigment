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
    public class JobCategoryRepository : IJobCategoryRepository
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<JobCategory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<JobCategory> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(JobCategory entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(JobCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
