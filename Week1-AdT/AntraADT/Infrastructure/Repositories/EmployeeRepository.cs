using ApllicationCore.Contracts.Repositories;
using ApllicationCore.Entities;
using Dapper;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class EmployeeRepository : IRepository<Employees>
    {
        private readonly DapperDbContext _dbContext;
        public EmployeeRepository()
        {
            _dbContext = new DapperDbContext(); //connection to database
        }
        public int Delete(Employees obj)
        {
            throw new NotImplementedException();
        }

        public int DeleteById(int id)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                return conn.Execute("Delete From Employees Where Id = @Id", new { Id = id });
            }
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
            IDbConnection conn = _dbContext.GetConnection();
            return conn.Execute("Insert Into Employees Values(@FirstName,@LastName,@Salary,@DeptId)", obj);
        }

        public int Update(Employees obj)
        {
            throw new NotImplementedException();
        }
    }
}
