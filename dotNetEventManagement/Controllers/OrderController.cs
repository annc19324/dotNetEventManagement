using dotNetEventManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Controllers
{
    public class OrderController
    {
        private string connectionString;

        public OrderController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool CancelOrder(int userId, string eventId)
        {
            string query = "DELETE FROM Orders WHERE UserId = @UserId AND EventId = @EventId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@EventId", eventId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + rowsAffected);
                return rowsAffected > 0;
            }
        }

        public bool AddOrderForAttendee(int userId, string eventId)
        {
            string query = @"
            INSERT INTO Orders (UserId, FullName, EventId, EventName, TotalPrice, OrderDate, PaymentStatus)
            SELECT 
                a.UserId, 
                COALESCE(a.FullName, u.FullName) AS FullName,
                e.EventId, 
                e.EventName, 
                e.Price, 
                GETDATE(), 
                'Chờ'
            FROM Attendees a
            JOIN Events e ON a.EventId = e.EventId
            JOIN Users u ON a.UserId = u.UserId
            WHERE a.UserId = @UserId AND a.EventId = @EventId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@EventId", eventId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool AddOrder(Order order)
        {
            string query = @"
            INSERT INTO Orders (UserId, FullName, EventId, EventName, TotalPrice, OrderDate, PaymentStatus) 
            VALUES (@UserId, @FullName, @EventId, @EventName, @TotalPrice, @OrderDate, @PaymentStatus)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", order.UserId);
                cmd.Parameters.AddWithValue("@FullName", order.FullName);
                cmd.Parameters.AddWithValue("@EventId", order.EventId);
                cmd.Parameters.AddWithValue("@EventName", order.EventName);
                cmd.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@PaymentStatus", order.PaymentStatus);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdatePaymentStatus(int orderId, string paymentStatus)
        {
            string query = "UPDATE Orders SET PaymentStatus = @PaymentStatus WHERE OrderId = @OrderId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                cmd.Parameters.AddWithValue("@OrderId", orderId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            string query = "SELECT * FROM Orders";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderId = reader.GetInt32("OrderId"),
                            UserId = reader.GetInt32("UserId"),
                            FullName = reader.GetString("FullName"), 
                            EventId = reader.GetString("EventId"),
                            EventName = reader.GetString("EventName"),
                            TotalPrice = reader.GetDouble("TotalPrice"),
                            OrderDate = reader.GetDateTime("OrderDate"),
                            PaymentStatus = reader.GetString("PaymentStatus")
                        });
                    }
                }
            }

            return orders;
        }
    }
}
