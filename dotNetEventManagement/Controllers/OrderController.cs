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
        private readonly Connect dbConnect;

        public OrderController()
        {
            dbConnect = new Connect();
        }

        public bool CancelOrder(int userId, string eventId)
        {
            string query = "DELETE FROM Orders WHERE UserId = @UserId AND EventId = @EventId";

            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@EventId", eventId);


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

            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@EventId", eventId);

                
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool AddOrder(Order order)
        {
            string query = @"
            INSERT INTO Orders (UserId, FullName, EventId, EventName, TotalPrice, OrderDate, PaymentStatus) 
            VALUES (@UserId, @FullName, @EventId, @EventName, @TotalPrice, @OrderDate, @PaymentStatus)";

            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", order.UserId);
                cmd.Parameters.AddWithValue("@FullName", order.FullName);
                cmd.Parameters.AddWithValue("@EventId", order.EventId);
                cmd.Parameters.AddWithValue("@EventName", order.EventName);
                cmd.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@PaymentStatus", order.PaymentStatus);


                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdatePaymentStatus(int orderId, string paymentStatus)
        {
            string query = "UPDATE Orders SET PaymentStatus = @PaymentStatus WHERE OrderId = @OrderId";

            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                cmd.Parameters.AddWithValue("@OrderId", orderId);

                
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public List<Order> SearchOrder(string keyword)
        {
            List<Order> orders = new List<Order>();
            string sql = "SELECT * FROM Orders WHERE FullName LIKE @Keyword";

            using (SqlConnection connection = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderId = reader.GetInt32(reader.GetOrdinal("OrderId")),
                            UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                            FullName = reader.GetString(reader.GetOrdinal("FullName")),
                            EventId = reader.GetString(reader.GetOrdinal("EventId")),
                            EventName = reader.GetString(reader.GetOrdinal("EventName")),
                            TotalPrice = Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("TotalPrice"))),
                            OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate")),
                            PaymentStatus = reader.GetString(reader.GetOrdinal("PaymentStatus"))
                        });
                    }
                }
            }

            return orders;
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            string query = "SELECT * FROM Orders";

            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                
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
                            TotalPrice = Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("TotalPrice"))),
                            OrderDate = reader.GetDateTime("OrderDate"),
                            PaymentStatus = reader.GetString("PaymentStatus")
                        });
                    }
                }
            }

            return orders;
        }
        public bool UpdateOrder(Order order)
        {
            if (!IsEventIdExists(order.EventId))
            {
                Console.WriteLine("EventId không tồn tại trong bảng Events.");
                return false;
            }

            string query = @"
                        UPDATE Orders 
                        SET UserId = @UserId, FullName = @FullName, EventId = @EventId, EventName = @EventName, 
                        TotalPrice = @TotalPrice, OrderDate = @OrderDate, PaymentStatus = @PaymentStatus 
                        WHERE OrderId = @OrderId;";

            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", order.UserId);
                cmd.Parameters.AddWithValue("@FullName", order.FullName);
                cmd.Parameters.AddWithValue("@EventId", order.EventId);
                cmd.Parameters.AddWithValue("@EventName", order.EventName);
                cmd.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@PaymentStatus", order.PaymentStatus);
                cmd.Parameters.AddWithValue("@OrderId", order.OrderId);

                
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Kiểm tra xem EventId có tồn tại hay không
        public bool IsEventIdExists(string eventId)
        {
            string query = "SELECT 1 FROM Events WHERE EventId = @EventId";
            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EventId", eventId);
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        // Xóa đơn hàng theo OrderId
        public bool DeleteOrder(int orderId)
        {
            string query = "DELETE FROM Orders WHERE OrderId = @OrderId";
            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@OrderId", orderId);
                
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Thanh toán hóa đơn
        public bool PayBill(int orderId)
        {
            string query = "UPDATE Orders SET PaymentStatus = @PaymentStatus WHERE OrderId = @OrderId";
            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PaymentStatus", "Đã thanh toán");
                cmd.Parameters.AddWithValue("@OrderId", orderId);
               
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Lấy đơn hàng theo UserId và EventId
        public Order GetOrderByUserIdAndEventId(int userId, string eventId)
        {
            string query = "SELECT * FROM Orders WHERE UserId = @UserId AND EventId = @EventId";
            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@EventId", eventId);
                

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Order
                        {
                            OrderId = reader.GetInt32(reader.GetOrdinal("OrderId")),
                            UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                            FullName = reader.GetString(reader.GetOrdinal("FullName")),
                            EventId = reader.GetString(reader.GetOrdinal("EventId")),
                            EventName = reader.GetString(reader.GetOrdinal("EventName")),
                            TotalPrice = reader.GetDouble(reader.GetOrdinal("TotalPrice")),
                            OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate")),
                            PaymentStatus = reader.GetString(reader.GetOrdinal("PaymentStatus"))
                        };
                    }
                }
            }
            return null;
        }
    }
}
