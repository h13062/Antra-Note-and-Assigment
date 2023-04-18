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
    public class StatusRepository : IStatusRepository
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Status>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Status> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(Status entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Status entity)
        {
            throw new NotImplementedException();
        }
    }
}
