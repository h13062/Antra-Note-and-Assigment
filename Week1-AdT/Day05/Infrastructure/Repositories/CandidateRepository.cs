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
    public class CandidateRepository : ICandidateRepository
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Candidate>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Candidate> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(Candidate entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Candidate entity)
        {
            throw new NotImplementedException();
        }
    }
}
