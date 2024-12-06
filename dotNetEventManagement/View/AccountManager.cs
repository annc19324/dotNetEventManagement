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
using System.Xml.Serialization;

namespace dotNetEventManagement.View
{
    public partial class AccountManager : Form
    {
        private UserController userController = new UserController();
        public AccountManager()
        {
            InitializeComponent();
            LoadUserAcoount();
        }
        private void LoadUserAcoount()
        {
            List<User> users = userController.GetAllUser();
            foreach (var user in users)
            {
                user.Password = new string('*', user.Password.Length);
            }
            dataGridViewUserAccount.DataSource = users;
        }
        public void ClearText()
        {
            txtNameAccount.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string taiKhoan = txtNameAccount.Text;
                string matKhau = txtPassword.Text;
                string ten = txtUserName.Text;
                string role = cmbRole.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(ten))
                {
                    MessageBox.Show("Nhập thiếu!!");
                }
                else
                {
                    User user = new User(0, taiKhoan, ten, matKhau, role);
                    if (userController.AddUserAccount(user))
                    {
                        MessageBox.Show("Thêm thành công!!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ClearText();
            LoadUserAcoount();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridViewUserAccount.SelectedCells[0].RowIndex;

            // Kiểm tra nếu không có dòng nào được chọn
            if (selectedRow == -1)
            {
                MessageBox.Show("Chọn 1 tài khoản để Sửa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ dòng được chọn
            DataGridViewRow row = dataGridViewUserAccount.Rows[selectedRow];
            int userId = Convert.ToInt32(row.Cells["UserId"].Value); // Giả sử cột đầu tiên là UserId

            // Lấy dữ liệu từ các TextBox và ComboBox
            string taiKhoan = txtNameAccount.Text;
            string matKhau = txtPassword.Text; // Lấy mật khẩu từ TextBox
            string ten = txtUserName.Text;
            string role = cmbRole.SelectedItem?.ToString(); // Kiểm tra nếu có giá trị trong ComboBox

            // Tạo đối tượng User mới
            User user = new User(userId, taiKhoan, ten, matKhau, role);

            // Cập nhật thông tin người dùng
            if (userController.UpdateUserAccount(user))
            {
                MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi sửa tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearText();
            LoadUserAcoount();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridViewUserAccount.SelectedCells[0].RowIndex;

            // Kiểm tra nếu không có dòng nào được chọn
            if (selectedRow == -1)
            {
                MessageBox.Show("Chọn 1 tài khoản để xóa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ dòng được chọn
            DataGridViewRow row = dataGridViewUserAccount.Rows[selectedRow];
            int userId = Convert.ToInt32(row.Cells["UserId"].Value); // Giả sử cột đầu tiên là UserId

            // Gọi phương thức xóa người dùng
            bool isDeleted = userController.DeleteUser(userId);

            // Hiển thị thông báo thành công hoặc thất bại
            if (isDeleted)
            {
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearText();
            LoadUserAcoount();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearText();
            LoadUserAcoount();

        }

        private void dataGridViewUserAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu mà người dùng đã nhấp vào
                DataGridViewRow row = dataGridViewUserAccount.Rows[e.RowIndex];

                // Lấy các giá trị của các cột trong dòng này
                string userId = row.Cells["UserId"].Value.ToString();
                string username = row.Cells["Username"].Value.ToString();
                string fullName = row.Cells["Fullname"].Value.ToString();
                string password = row.Cells["Password"].Value.ToString();
                string role = row.Cells["Role"].Value.ToString();

                // Giả sử bạn có các TextBox để hiển thị thông tin

                txtUserName.Text = fullName;
                txtNameAccount.Text = username;
                txtPassword.Text = password;
                cmbRole.SelectedItem = role; // Đặt giá trị cho ComboBox
            }

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            new AdminHome().ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            new EventManager().ShowDialog();
            this.Close();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new OrderManager().ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new LogInView().ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            new AttendeeManager().ShowDialog();
            this.Close();
        }
    }
}
