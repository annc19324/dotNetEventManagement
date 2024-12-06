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
    public partial class ChangePasswordView : Form
    {
        private User user;
        private UserController userController;
        public ChangePasswordView(User user)
        {
            InitializeComponent();
            this.user = Session.CurrentUser;
            userController = new UserController();

        }

        private void btnUserHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHome(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirm = txtConfirmPassword.Text;


            DialogResult result = MessageBox.Show("bạn có chắc chắn muốn thay đổi mật khẩu?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (userController.changeNewPassword(user.UserId, oldPassword, newPassword))
                {
                    DialogResult LogOut = MessageBox.Show("cập nhật mật khẩu mới thành công, bạn có muốn đăng nhập lại?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == LogOut)
                    {
                        labelOldPasswordE.Text = "";
                        Session.clear();
                        this.Hide();
                        new LogInView().ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    labelOldPasswordE.Text = "mật khẩu cũ không chính xác";
                }
            }
        }
    }
}
