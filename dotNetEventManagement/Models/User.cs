using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Models
{
    public class User
    {
        public User()
        {
        }
        public User(int userId, string username, string fullname, string password, string role)
        {
            UserId = userId;
            Username = username;
            Fullname = fullname;
            Password = password;
            Role = role;
        }
        public User(string username, string fullname, string password, DateTime dateOfBirth, string mail, string phone)
        {
            Username = username;
            Fullname = fullname;
            Password = password;
            DateOfBirth = dateOfBirth;
            Mail = mail;
            Phone = phone;
        }

        public User(int userId, string username, string fullname, string password, DateTime dateOfBirth, string mail, string phone, string role)
        {
            UserId = userId;
            Username = username;
            Fullname = fullname;
            Password = password;
            DateOfBirth = dateOfBirth;
            Mail = mail;
            Phone = phone;
            Role = role;
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
    }
}
