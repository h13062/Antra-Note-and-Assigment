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
    public class SubmissionRepository : ISubmissionRepository
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Submission>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Submission> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(Submission entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Submission entity)
        {
            throw new NotImplementedException();
        }
    }
}
