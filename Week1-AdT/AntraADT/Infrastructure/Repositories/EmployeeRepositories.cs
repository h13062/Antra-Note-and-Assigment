using ApllicationCore.Contracts.Repositories;
using ApllicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class EmployeeRepositories : IRepository<Employees>
    {
        public int Delete(Employees obj)
        {
            throw new NotImplementedException();
        }

        public int DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employees> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employees GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Employees obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Employees obj)
        {
            throw new NotImplementedException();
        }
    }
}
