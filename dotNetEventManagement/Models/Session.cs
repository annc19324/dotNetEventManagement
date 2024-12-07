using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Models
{
    public static class Session
    {
        public static User ?CurrentUser { get; set; }
        private static List<Event> registeredEvents = new List<Event>();
        public static Order? order { get; set; }

        public static void clear()
        {
            CurrentUser = null;
        }

        public static void setUser(User user)
        {
            CurrentUser = user;

        }
        public static User getUser()
        {
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

        public static void addRegisteredEvent(Event eventItem)
        {
            registeredEvents.Add(eventItem);
        }

        public static void removeRegisteredEventById(String eventId)
        {
            registeredEvents.RemoveAll(e => e.EventId == eventId);
        }

        public static void SetOrder(Order newOrder)
        {
            order = newOrder;
        }
        public static Order? GetOrder()
        {
            return order;
        }
    }
}
