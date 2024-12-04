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
        private static List<Event> registeredEvents = new List<Event>();

        public static void clear()
        {
            CurrentUser = null;
        }

        public static void setUser(User user)
        {
            //user = CurrentUser;
            CurrentUser = user;

        }
        public static User getUser() { 
            return CurrentUser;
        }
        public static void AddRegisteredEvent(Event eventItem)
        {
            registeredEvents.Add(eventItem);
        }

        public static List<Event> GetRegisteredEvents()
        {
            return registeredEvents;
        }
    }
}
