using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Models
{
    public static class Session
    {
        public static User CurrentUser { get; set; }

        public static void clear()
        {
            CurrentUser = null;
        }

        public static void setUser(User user)
        {
            user = CurrentUser;
        }
        public static User getUser() { 
            return CurrentUser;
        }
    }
}
