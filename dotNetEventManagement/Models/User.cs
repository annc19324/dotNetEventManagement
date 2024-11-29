using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Models
{
    internal class User
    {
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

        private int UserId { get; set; }
        private string Username { get; set; }
        private string Fullname {  get; set; }
        private string Password { get; set; }
        private DateTime DateOfBirth {  get; set; }
        private string Mail { get; set; }
        private string Phone {  get; set; }
        private string Role {  get; set; }
    }
}
