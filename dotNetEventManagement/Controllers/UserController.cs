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

        //public enum LoginStatus
        //{
        //    Success,
        //    UsernameNotFound,
        //    PasswordNotFound,
        //    User,
        //    Admin
        //}

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
        public User CheckLogin(string username, string password)
        {
            using (SqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                if (!checkUsernameExist(username))
                {
                    return null;
                }

                string queryRole = "select * from Users where username = @username and [password] = @password";
                string inputPassword = HashPassword(password);
                using (SqlCommand cmd = new SqlCommand(queryRole, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    //cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@password", inputPassword);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User()
                            {
                                UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                Fullname = reader.GetString(reader.GetOrdinal("Fullname")),
                                Password = reader.GetString(reader.GetOrdinal("Password")),
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                Mail = reader.GetString(reader.GetOrdinal("Mail")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                Role = reader.GetString(reader.GetOrdinal("Role"))
                            };
                            return user;
                        }
                        else
                        {
                            return null;
                        }
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

        public bool changeInformation(int userid, string username, string fullname, DateTime dateOfBirth, string mail, string phone)
        {
            string query = "update users set username = @username, fullname = @fullname, dateofbirth = @dateofbirth, mail = @mail, phone=@phone where userid = @userid";
            using (SqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@dateofbirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@userid", userid);
                    int count = cmd.ExecuteNonQuery();
                    return count > 0;
                }
            }
        }

        public bool changeNewPassword(int userid, string oldPassword, string newPassword)
        {
            string query = "update users set password = @newpassword where userid = @userId and password = @oldpassword";
            string oldHashedPassword = HashPassword(oldPassword);
            string newHashedPassword = HashPassword(newPassword);
            using (SqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userid);
                    cmd.Parameters.AddWithValue("@oldpassword", oldHashedPassword);
                    cmd.Parameters.AddWithValue("@newpassword", newHashedPassword);
                    int count = cmd.ExecuteNonQuery();
                    return count > 0;
                }
            }
        }
    }

}