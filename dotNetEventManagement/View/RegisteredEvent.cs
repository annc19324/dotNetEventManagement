using dotNetEventManagement.Controllers;
using dotNetEventManagement.Models;
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
    public partial class RegisteredEvent : Form
    {
        private User user;
        private EventController eventController;
        public RegisteredEvent(User user)
        {
            InitializeComponent();
            this.user = Session.CurrentUser;
            lblFullname.Text = user.Fullname;
            eventController = new EventController();

            showAllEvents();
        }

        private void showAllEvents()
        {
            BindingList<Event> registeredEvents = new BindingList<Event>(eventController.GetRegisteredEventsByUserId(user.UserId));
            dgvRegisteredEventList.DataSource = registeredEvents;
        }

        private void btnUserHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHome(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void btnCancelEvent_Click(object sender, EventArgs e)
        {
            int selectedRow = dgvRegisteredEventList.SelectedCells[0].RowIndex;
            if (selectedRow == -1)
            {
                MessageBox.Show("vui lòng chọn một sự kiện", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string eventId = dgvRegisteredEventList.Rows[selectedRow].Cells["EventId"].Value.ToString();
            int userId = user.UserId; // Giả sử `user.UserId` là ID người dùng hiện tại

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy đăng ký sự kiện này?",
                                                  "Xác nhận hủy đăng ký",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                bool isCancelled = eventController.CancelRegistration(userId, eventId);

                if (isCancelled)
                {
                    dgvRegisteredEventList.Rows.RemoveAt(selectedRow);
                    MessageBox.Show("Đã hủy đăng ký sự kiện thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi hủy đăng ký sự kiện. Vui lòng thử lại.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            new PayBillView(Session.CurrentUser).ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(key) || key == "nhập mã sự kiện hoặc tên sự kiện cần tìm ở đây")
            {
                MessageBox.Show("Hãy nhập mã sự kiện hoặc tên sự kiện cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showAllEvents();
                return;
            }
            List<Event> filteredEvents = eventController.GetRegisteredEventsByUserId(user.UserId)
        .Where(e => e.EventId.ToLower().Contains(key) || e.EventName.ToLower().Contains(key))
        .ToList();

            if (filteredEvents.Count > 0)
            {
                // Cập nhật lại dữ liệu cho DataGridView
                BindingList<Event> bindingList = new BindingList<Event>(filteredEvents);
                dgvRegisteredEventList.DataSource = bindingList;
            }
            else
            {
                MessageBox.Show($"Không có thông tin về '{key}'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showAllEvents();
        }
    }
}
