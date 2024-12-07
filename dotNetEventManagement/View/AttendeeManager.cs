using dotNetEventManagement.Controllers;
using dotNetEventManagement.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AttendeeManager : Form
    {
        private AttendeeController attendeeController = new AttendeeController();
        public AttendeeManager()
        {
            InitializeComponent();
            LoadAttendee();
        }
        private void LoadAttendee()
        {
            List<Attendee> attendees = attendeeController.GetAttendee();
            dataGridViewAttendee.DataSource = attendees;
        }
        public void ClearText()
        {
            txtEventId.Clear();
            txtEventName.Clear();
            txtUserId.Clear();
            txtUserName.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserId.Text) ||
                   string.IsNullOrEmpty(txtUserName.Text) ||
                   string.IsNullOrEmpty(txtEventId.Text) ||
                   string.IsNullOrEmpty(txtEventName.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId;
                if (!int.TryParse(txtUserId.Text, out userId))
                {
                    MessageBox.Show("UserId phải là số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fullName = txtUserName.Text;
                string eventId = txtEventId.Text;
                string eventName = txtEventName.Text;
                string status = cmbStatus.SelectedItem?.ToString() ?? "Không xác định";

                // Tạo đối tượng Attendee
                Attendee attendee = new Attendee(0, userId, fullName, eventId, eventName, status);

                // Thêm attendee thông qua controller

                attendeeController.AddAttendee(attendee);

                // Hiển thị lại danh sách các sự kiện và xóa trường nhập liệu
                LoadAttendee();
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm : {ex.Message}");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAttendee.CurrentRow != null)
                {
                    // Lấy chỉ số hàng được chọn
                    int selectedRow = dataGridViewAttendee.CurrentRow.Index;

                    // Lấy giá trị OrderId từ cột đầu tiên
                    int attendeeId = (int)dataGridViewAttendee.Rows[selectedRow].Cells[0].Value;
                    int userId = int.Parse(txtUserId.Text);
                    string fullName = txtUserName.Text;
                    string eventId = txtEventId.Text;
                    string eventName = txtEventName.Text;
                    string status = cmbStatus.SelectedItem?.ToString() ?? "Không xác định";
                    Attendee attendee = new Attendee(attendeeId, userId, fullName, eventId, eventName, status);

                    // Thực hiện hành động xóa
                    bool updateAttendee = attendeeController.UpdateAttendee(attendee);
                    if (updateAttendee)
                    {
                        MessageBox.Show($"Sửa thành công!!");
                    }
                    else
                    {
                        MessageBox.Show($"Sửa thất bại!!");
                    }
                    LoadAttendee();

                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa : {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridViewAttendee.CurrentRow != null)
                {
                    int selectedRow = dataGridViewAttendee.CurrentRow.Index;
                    int attendeeId = Convert.ToInt32(dataGridViewAttendee.Rows[selectedRow].Cells[0].Value);
                    int userId;
                    if (!int.TryParse(txtUserId.Text, out userId))
                    {
                        MessageBox.Show("UserId phải là số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string fullName = txtUserName.Text;
                    string eventId = txtEventId.Text;
                    string eventName = txtEventName.Text;
                    string status = cmbStatus.SelectedItem?.ToString() ?? "Không xác định";

                    if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(eventId) || string.IsNullOrEmpty(eventName))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Attendee attendee = new Attendee(attendeeId, userId, fullName, eventId, eventName, status);

                    // Sử dụng attendee.UserId
                    bool deleteAttendee = attendeeController.DeleteAttendeeAndOrders(attendee, attendee.UserId);
                    if (deleteAttendee)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadAttendee();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Không có hàng nào được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridViewAttendee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtUserId.Text = dataGridViewAttendee.Rows[r].Cells["UserId"].Value.ToString();
                txtUserName.Text = dataGridViewAttendee.Rows[r].Cells["FullName"].Value.ToString();
                txtEventId.Text = dataGridViewAttendee.Rows[r].Cells["EventId"].Value.ToString();
                txtEventName.Text = dataGridViewAttendee.Rows[r].Cells["EventName"].Value.ToString();
                cmbStatus.Text = dataGridViewAttendee.Rows[r].Cells["Status"].Value.ToString();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            var newWindowState = new EventManager();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            var newWindowState = new AccountManager();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

            this.Hide();
            var newWindowState = new LogInView();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
 
            this.Hide();
            var newWindowState = new AdminHome();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

            this.Hide();
            var newWindowState = new OrderManager();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }
    }
}
