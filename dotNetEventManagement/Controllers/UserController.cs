using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Controllers
{
    public class UserController
    {
        private readonly DbContext dbContext;

        public UserController()
        {
            dbContext = new DbContext();
        }

        public enum LoginStatus
        {
            Success,
            UsernameNotFound,
            PasswordNotFound,
            User,
            Admin
        }

        //ma hoa mat khau
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        //ktra dang nhap username co ton tai khong? neu co thi xem la admin hay user 
        public LoginStatus CheckLogin(string username, string password)
        {
            using (SqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                string queryUserExist = "select count(*) from Users where Username = @username";
                using (SqlCommand cmd = new SqlCommand(queryUserExist, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0) {
                        return LoginStatus.UsernameNotFound;
                    }
                }

                string queryRole = "select role from Users where username = @username and [password] = @password";
                //string inputPassword = HashPassword(password);
                using (SqlCommand cmd = new SqlCommand(queryRole, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    //cmd.Parameters.AddWithValue("@password", inputPassword);

                    var _role = cmd.ExecuteScalar();
                    if (_role != null) { 
                        string role = _role.ToString();
                        return role == "admin" ? LoginStatus.Admin : LoginStatus.User;
                    }
                    else
                    {
                        return LoginStatus.PasswordNotFound;
                    }
                }
            }
        }
    }
}
