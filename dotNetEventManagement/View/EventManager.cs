using dotNetEventManagement.Controllers;
using dotNetEventManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetEventManagement.View
{
    public partial class EventManager : Form
    {

        private EventController eventcontroller = new EventController();


        public EventManager()
        {
            InitializeComponent();
            LoadEvents();

        }
        private void LoadEvents()
        {
            List<Event> events = eventcontroller.GetAllEvents();
            dataGridViewEvents.DataSource = events;
        }


        public void clearText()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtDiaDiem.Clear();
            txtMoTa.Clear();
            txtGiaVe.Clear();
            dateTimeBatDau.Value = DateTime.Now;
            dateTimeKetThuc.Value = DateTime.Now;
            cmbTrangThai.SelectedIndex = -1;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            { // Lấy dữ liệu từ các điều khiển nhập liệu
                string eventId = txtMa.Text;
                string eventName = txtTen.Text;
                DateTime startDate = dateTimeBatDau.Value;
                DateTime endDate = dateTimeKetThuc.Value;
                string location = txtDiaDiem.Text;
                string description = txtMoTa.Text;
                string status = cmbTrangThai.Text;
                double price = double.Parse(txtGiaVe.Text);
                // Tạo đối tượng
                Event newEvent = new Event
                {
                    EventId = eventId,
                    EventName = eventName,
                    StartDate = startDate.ToString("dd-MM-yyyy"),
                    EndDate = endDate.ToString("dd-MM-yyyy"),
                    Location = location,
                    Description = description,
                    Status = status,
                    Price = price
                };
                // Gọi phương thức AddEvent để thêm sự kiện vào cơ sở dữ liệu
                eventcontroller.AddEvent(newEvent);
                // Làm mới DataGridView để hiển thị sự kiện mới
                LoadEvents();
                // Xóa nội dung các điều khiển nhập liệu
                clearText();
                MessageBox.Show("Thêm sự kiện thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sự kiện: {ex.Message}");
            }
        }

        private void dataGridViewEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex; if (r >= 0)
            {
                txtMa.Text = dataGridViewEvents.Rows[r].Cells["EventId"].Value.ToString();
                txtTen.Text = dataGridViewEvents.Rows[r].Cells["EventName"].Value.ToString();
                txtDiaDiem.Text = dataGridViewEvents.Rows[r].Cells["Location"].Value.ToString();
                txtMoTa.Text = dataGridViewEvents.Rows[r].Cells["Description"].Value.ToString();
                dateTimeBatDau.Value = DateTime.Parse(dataGridViewEvents.Rows[r].Cells["StartDate"].Value.ToString());
                dateTimeKetThuc.Value = DateTime.Parse(dataGridViewEvents.Rows[r].Cells["EndDate"].Value.ToString());
                cmbTrangThai.Text = dataGridViewEvents.Rows[r].Cells["Status"].Value.ToString();
                txtGiaVe.Text = dataGridViewEvents.Rows[r].Cells["Price"].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            LoadEvents();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            { // Lấy dữ liệu từ các điều khiển nhập liệu
                string eventId = txtMa.Text;
                string eventName = txtTen.Text;
                DateTime startDate = dateTimeBatDau.Value;
                DateTime endDate = dateTimeKetThuc.Value;
                string location = txtDiaDiem.Text;
                string description = txtMoTa.Text;
                string status = cmbTrangThai.Text;
                double price = double.Parse(txtGiaVe.Text);
                // Tạo đối tượng Event
                Event updatedEvent = new Event
                {
                    EventId = eventId,
                    EventName = eventName,
                    StartDate = startDate.ToString("dd-MM-yyyy"),
                    EndDate = endDate.ToString("dd-MM-yyyy"),
                    Location = location,
                    Description = description,
                    Status = status,
                    Price = price
                };
                // Gọi phương thức UpdateEvent để cập nhật sự kiện trong cơ sở dữ liệu
                eventcontroller.UpdateEvent(updatedEvent);
                // Làm mới DataGridView để hiển thị sự kiện cập nhật
                LoadEvents();
                // Xóa nội dung các điều khiển nhập l
                clearText();
                MessageBox.Show("Cập nhật sự kiện thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sự kiện: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            { // Lấy EventId từ TextBox
                string eventId = txtMa.Text;
                // Kiểm tra nếu EventId rỗng
                if (string.IsNullOrEmpty(eventId))
                {
                    MessageBox.Show("Vui lòng chọn sự kiện để xóa.");
                    return;
                }
                // Gọi phương thức DeleteEvent để xóa sự kiện
                eventcontroller.DeleteEvent(eventId);
                // Làm mới DataGridView để hiển thị danh sách sự kiện mới nhất
                LoadEvents();
                // Xóa nội dung các điều khiển nhập liệu
                clearText();
                MessageBox.Show("Xóa sự kiện thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sự kiện: {ex.Message}");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            { // Lấy từ khóa tìm kiếm từ TextBox
                string keyword = txtTimKiem.Text;
                // Gọi phương thức SearchEvents để tìm kiếm sự kiện
                List<Event> searchResults = eventcontroller.SearchEvents(keyword);
                // Hiển thị kết quả tìm kiếm trên
                dataGridViewEvents.DataSource = searchResults;
                // Xóa nội dung các điều khiển nhập liệu
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm sự kiện: {ex.Message}");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new OrderManager().ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new AccountManager().ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            new AttendeeManager().ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new LogInView().ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new AdminHome().ShowDialog();
            this.Close();
        }
    }
}
