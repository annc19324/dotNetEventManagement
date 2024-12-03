using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string Status { get; set; }

        // Constructor mặc định
        public Attendee() { }

        // Constructor có tham số
        public Attendee(int attendeeId, int userId, string fullName, string eventId, string eventName, string status)
        {
            AttendeeId = attendeeId;
            UserId = userId;
            FullName = fullName;
            EventId = eventId;
            EventName = eventName;
            Status = status;
        }

        // Ghi đè phương thức ToString
        public override string ToString()
        {
            return $"Attendee {{ AttendeeId = {AttendeeId}, UserId = {UserId}, EventId = '{EventId}', Status = '{Status}' }}";
        }
    }

}
