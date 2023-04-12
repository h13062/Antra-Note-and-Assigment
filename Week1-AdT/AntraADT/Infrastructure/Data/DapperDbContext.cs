using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class DapperDbContext
    {
        IDbConnection dbConnection;
        public DapperDbContext()
        {
        }
        public IDbConnection GetConnection()
        {
            dbConnection = new SqlConnection("Data Source =.; Initial Catalog = MarchDapper; Integrated Security = True");
            return dbConnection;
        }
    }
}
