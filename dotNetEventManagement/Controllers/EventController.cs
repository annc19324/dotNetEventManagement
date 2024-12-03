using dotNetEventManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Controllers
{
    public class EventController
    {
        private readonly Connect dbConnect;

        public EventController()
        {
            dbConnect = new Connect();
        }

        public void AddEvent(Event ev)
        {
            string sql = "INSERT INTO Events(EventId, EventName, StartDate, EndDate, Location, Description, Status, Price) VALUES(@EventId, @EventName, @StartDate, @EndDate, @Location, @Description, @Status, @Price)";
            try
            {
                using (SqlConnection conn = dbConnect.ConnectSQL())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EventId", ev.EventId);
                    cmd.Parameters.AddWithValue("@EventName", ev.EventName);
                    cmd.Parameters.AddWithValue("@StartDate", ev.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", ev.EndDate);
                    cmd.Parameters.AddWithValue("@Location", ev.Location);
                    cmd.Parameters.AddWithValue("@Description", ev.Description);
                    cmd.Parameters.AddWithValue("@Status", ev.Status);
                    cmd.Parameters.AddWithValue("@Price", ev.Price);

                    conn.Open();
                    int rowsInserted = cmd.ExecuteNonQuery();
                    if (rowsInserted > 0)
                        Console.WriteLine("Thêm sự kiện thành công!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Lỗi thêm sự kiện: {e.Message}");
            }
        }

        public void UpdateEvent(Event ev)
        {
            string sql = "UPDATE Events SET EventName = @EventName, StartDate = @StartDate, EndDate = @EndDate, Location = @Location, Description = @Description, Status = @Status, Price = @Price WHERE EventId = @EventId";
            try
            {
                using (SqlConnection conn = dbConnect.ConnectSQL())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EventName", ev.EventName);
                    cmd.Parameters.AddWithValue("@StartDate", ev.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", ev.EndDate);
                    cmd.Parameters.AddWithValue("@Location", ev.Location);
                    cmd.Parameters.AddWithValue("@Description", ev.Description);
                    cmd.Parameters.AddWithValue("@Status", ev.Status);
                    cmd.Parameters.AddWithValue("@Price", ev.Price);
                    cmd.Parameters.AddWithValue("@EventId", ev.EventId);

                    conn.Open();
                    int rowsUpdated = cmd.ExecuteNonQuery();
                    if (rowsUpdated > 0)
                        Console.WriteLine("Cập nhật sự kiện thành công!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Lỗi cập nhật sự kiện: {e.Message}");
            }
        }

        public void DeleteEvent(string eventId)
        {
            string sql = "DELETE FROM Events WHERE EventId = @EventId";
            try
            {
                using (SqlConnection conn = dbConnect.ConnectSQL())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EventId", eventId);

                    conn.Open();
                    int rowsDeleted = cmd.ExecuteNonQuery();
                    if (rowsDeleted > 0)
                        Console.WriteLine("Xóa sự kiện thành công!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Lỗi xóa sự kiện: {e.Message}");
            }
        }

        public List<Event> SearchEvents(string keyword)
        {
            List<Event> events = new List<Event>();
            string sql = "SELECT * FROM Events WHERE EventName LIKE @Keyword";
            try
            {
                using (SqlConnection conn = dbConnect.ConnectSQL())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            events.Add(new Event
                            {
                                EventId = reader["EventId"].ToString(),
                                EventName = reader["EventName"].ToString(),
                                StartDate = reader["StartDate"].ToString(),
                                EndDate = reader["EndDate"].ToString(),
                                Location = reader["Location"].ToString(),
                                Description = reader["Description"].ToString(),
                                Status = reader["Status"].ToString(),
                                Price = Convert.ToDouble(reader["Price"])
                            });
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Lỗi tìm kiếm sự kiện: {e.Message}");
            }

            return events;
        }

        public bool RegisterEvent(int userId, string fullName, string eventId, string eventName)
        {
            if (IsEventRegistered(userId, eventId))
            {
                return false;
            }

            string sql = "INSERT INTO Attendees (UserId, FullName, EventId, EventName, Status) VALUES (@UserId, @FullName, @EventId, @EventName, @Status)";
            try
            {
                using (SqlConnection conn = dbConnect.ConnectSQL())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@EventId", eventId);
                    cmd.Parameters.AddWithValue("@EventName", eventName);
                    cmd.Parameters.AddWithValue("@Status", "Đã đăng ký");

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Lỗi đăng ký sự kiện: {e.Message}");
                return false;
            }
        }

        public bool IsEventRegistered(int userId, string eventId)
        {
            string sql = "SELECT COUNT(*) FROM Attendees WHERE UserId = @UserId AND EventId = @EventId";
            try
            {
                using (SqlConnection conn = dbConnect.ConnectSQL())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@EventId", eventId);

                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Lỗi kiểm tra sự kiện: {e.Message}");
                return false;
            }
        }
    }
}
