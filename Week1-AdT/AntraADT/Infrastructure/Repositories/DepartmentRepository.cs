using ApllicationCore.Contracts.Repositories;
using ApllicationCore.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class DepartmentRepository : IRepository<Departments>
    {
        private readonly DapperDbContext _dbContext;
        public DepartmentRepository() 
        { 
           _dbContext = new DapperDbContext(); 
        }


        public int DeleteById(int id)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                return conn.Execute("Delete From Departments Where Id = @Id", new { Id = id });
            }
        }

        public IEnumerable<Departments> GetAll()
        {
            throw new NotImplementedException();
        }

        public Departments GetById(int id)
        {
            IDbConnection conn = _dbContext.GetConnection();
            return conn.QuerySingleOrDefault<Departments>("Select Id, DeptName, Location from Departments Where Id = @Id", new {Id = id});
        }

        public int Insert(Departments obj)
        {
            IDbConnection conn = _dbContext.GetConnection();
            return conn.Execute("Insert Into Departments Values(@DeptName,@Location)", obj);
        }

        public int Update(Departments obj)
        {
            IDbConnection conn = _dbContext.GetConnection();
            return conn.Execute("Update Departments set DeptName = @DeptName, Location = @location Where Id = @Id", obj);
        }
    }
}
