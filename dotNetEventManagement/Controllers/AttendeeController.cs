using dotNetEventManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Controllers
{
    public class AttendeeController
    {
        private Connect dbConnect;

        public AttendeeController()
        {
            dbConnect = new Connect();
        }

        // Thêm attendee dựa trên userId và eventId
        public bool AddAttendee(int userId, string eventId)
        {
            string query = @"
            INSERT INTO Attendees (UserId, EventId, FullName, EventName, [Status])
            SELECT u.UserId, e.EventId, u.FullName, e.EventName, 'Đã Đăng Ký'
            FROM Users u
            JOIN Events e ON e.EventId = @EventId
            WHERE u.UserId = @UserId;
        ";

            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EventId", eventId);
                cmd.Parameters.AddWithValue("@UserId", userId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Thêm attendee dựa trên đối tượng Attendee
        public bool AddAttendee(Attendee attendee)
        {
            string query = @"
            INSERT INTO Attendees (UserId, FullName, EventId, EventName, [Status])
            VALUES (@UserId, @FullName, @EventId, @EventName, @Status)
        ";

            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", attendee.UserId);
                cmd.Parameters.AddWithValue("@FullName", attendee.FullName);
                cmd.Parameters.AddWithValue("@EventId", attendee.EventId);
                cmd.Parameters.AddWithValue("@EventName", attendee.EventName);
                cmd.Parameters.AddWithValue("@Status", attendee.Status);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật attendee
        public bool UpdateAttendee(Attendee attendee)
        {
            string query = @"
            UPDATE Attendees
            SET UserId = @UserId, FullName = @FullName, EventId = @EventId, EventName = @EventName, [Status] = @Status
            WHERE AttendeeId = @AttendeeId
        ";

            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", attendee.UserId);
                cmd.Parameters.AddWithValue("@FullName", attendee.FullName);
                cmd.Parameters.AddWithValue("@EventId", attendee.EventId);
                cmd.Parameters.AddWithValue("@EventName", attendee.EventName);
                cmd.Parameters.AddWithValue("@Status", attendee.Status);
                cmd.Parameters.AddWithValue("@AttendeeId", attendee.AttendeeId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa attendee và các đơn hàng liên quan
        public bool DeleteAttendeeAndOrders(Attendee attendee, int userId)
        {
            string deleteOrdersSql = @"
            DELETE FROM Orders
            WHERE EventName = (
                SELECT EventName
                FROM Attendees
                WHERE AttendeeId = @AttendeeId AND UserId = @UserId
            )
        ";

            string deleteAttendeeSql = @"
            DELETE FROM Attendees
            WHERE AttendeeId = @AttendeeId AND UserId = @UserId
        ";

            using (SqlConnection conn = dbConnect.ConnectSQL())
            {
                
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Xóa đơn hàng
                    using (SqlCommand deleteOrdersCmd = new SqlCommand(deleteOrdersSql, conn, transaction))
                    {
                        deleteOrdersCmd.Parameters.AddWithValue("@AttendeeId", attendee.AttendeeId);
                        deleteOrdersCmd.Parameters.AddWithValue("@UserId", userId);
                        deleteOrdersCmd.ExecuteNonQuery();
                    }

                    // Xóa attendee
                    using (SqlCommand deleteAttendeeCmd = new SqlCommand(deleteAttendeeSql, conn, transaction))
                    {
                        deleteAttendeeCmd.Parameters.AddWithValue("@AttendeeId", attendee.AttendeeId);
                        deleteAttendeeCmd.Parameters.AddWithValue("@UserId", userId);
                        deleteAttendeeCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // Lấy danh sách attendee
        public List<Attendee> GetAttendee()
        {
            List<Attendee> attendees = new List<Attendee>();
            string query = "SELECT * FROM [Attendees]";

            using (SqlConnection conn = dbConnect.ConnectSQL())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    attendees.Add(new Attendee
                    {
                        AttendeeId = reader.GetInt32(reader.GetOrdinal("AttendeeId")),
                        UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                        FullName = reader.GetString(reader.GetOrdinal("FullName")),
                        EventId = reader.GetString(reader.GetOrdinal("EventId")),
                        EventName = reader.GetString(reader.GetOrdinal("EventName")),
                        Status = reader.GetString(reader.GetOrdinal("Status"))
                    });
                }
            }

            return attendees;
        }
    }
}
