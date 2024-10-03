using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class SQLConnection
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=PREDATOR;Initial Catalog=Employee;Integrated Security=True;TrustServerCertificate=True");
            connect.Open();
            return connect;
        }
    }
}
