using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Controllers
{
    public class Connect
    {
        private SqlConnection conn;

        public SqlConnection ConnectSQL()
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-8NL4P7LM;Initial Catalog=EventManagement;Integrated Security=True;Trust Server Certificate=True";

                conn = new SqlConnection(connectionString);
                conn.Open();
                Console.WriteLine("Kết nối thành công tới CSDL 'EventManagement'");
                return conn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không kết nối được CSDL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
