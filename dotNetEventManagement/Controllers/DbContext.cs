using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dotNetEventManagement.Controllers
{
    public class DbContext
    {
        private readonly string connectionString = "Data Source=LAPTOP_ANNC\\MSSQLSERVER_AN; Initial Catalog=dotNetEventManagement; User Id = sa; Password=12345; TrustServerCertificate=true;";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
