using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string EventId { get; set; }
        public string FullName { get; set; }
        public string EventName { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string PaymentStatus { get; set; }

        // Constructor không tham số
        public Order()
        {
        }

        // Constructor có tham số
        public Order(int orderId, int userId, string fullName, string eventId, string eventName, decimal totalPrice, DateTime orderDate, string paymentStatus)
        {
            OrderId = orderId;
            UserId = userId;
            EventId = eventId;
            FullName = fullName;
            EventName = eventName;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
            PaymentStatus = paymentStatus;
        }
    }

}
