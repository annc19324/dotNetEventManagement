using dotNetEventManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
                //string queryUserExist = "select count(*) from Users where Username = @username";
                //using (SqlCommand cmd = new SqlCommand(queryUserExist, conn))
                //{
                //    cmd.Parameters.AddWithValue("@username", username);
                //    int count = (int)cmd.ExecuteScalar();
                //    if (count == 0)
                //    {
                //        return LoginStatus.UsernameNotFound;
                //    }
                //}
                if (!checkUsernameExist(username))
                {
                    return LoginStatus.UsernameNotFound;
                }

                string queryRole = "select role from Users where username = @username and [password] = @password";
                string inputPassword = HashPassword(password);
                using (SqlCommand cmd = new SqlCommand(queryRole, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    //cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@password", inputPassword);

                    var _role = cmd.ExecuteScalar();
                    if (_role != null)
                    {
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


        public bool checkUsernameExist(string username)
        {
            string query = "select count(*) from Users where username = @username ";
            using (SqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool addAccount(User user)
        {
            using (SqlConnection conn = dbContext.GetConnection())
            {
                string hashedPassword = HashPassword(user.Password);
                string query = "insert into users (Username, Fullname, Password, DateOfBirth, Mail, Phone, Role) values(@Username, @Fullname, @Password, @DateOfBirth, @Mail, @Phone, @Role)";
                try
                {
                    conn.Open();
                    if (checkUsernameExist(user.Username))
                    {
                        return false;
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Fullname", user.Fullname);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Mail", user.Mail);
                        cmd.Parameters.AddWithValue("@Phone", user.Phone);
                        cmd.Parameters.AddWithValue("@Role", "user");

                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            Console.WriteLine("them tai khoan thanh cong");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("them tai khoan that bai");
                            return false;
                        }
                    }
                }
                //ok
                catch (Exception ex)
                {
                    Console.WriteLine("loi ket noi csdl: " + ex.Message);
                    return false;
                }
            }
        }

        public bool changePassword(string username, string password, string mail)
        {
            string hashedPassword = HashPassword(password);
            string query = "UPDATE users SET password = @password WHERE username = @username AND mail = @mail";

            using (SqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = username });
                    cmd.Parameters.Add(new SqlParameter("@mail", SqlDbType.NVarChar) { Value = mail });
                    cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar) { Value = hashedPassword });

                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            Console.WriteLine("Cập nhật mật khẩu thành công");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Cập nhật mật khẩu thất bại");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }

}