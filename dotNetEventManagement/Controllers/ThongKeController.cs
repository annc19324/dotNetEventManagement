using dotNetEventManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Controllers
{
    public class ThongKeController
    {
        private Connect dbConnect;

        public ThongKeController()
        {
            dbConnect = new Connect();
        }

        public List<ThongKeClass> GetListByLopHoc()
        {
            string sql = "select OrderDate, Count(*) as So_Luong from [Orders] group by OrderDate";
            List<ThongKeClass> list = new List<ThongKeClass>(); 
            try { SqlConnection cons = dbConnect.ConnectSQL();
                SqlCommand cmd = new SqlCommand(sql, cons);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) { 
                    ThongKeClass thongke = new ThongKeClass {
                        Ngay_dang_ky = reader["OrderDate"].ToString(),
                        So_luong_Don = Convert.ToInt32(reader["So_Luong"])
                    }; 
                    list.Add(thongke);
                } 
                return list; 
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }

}
