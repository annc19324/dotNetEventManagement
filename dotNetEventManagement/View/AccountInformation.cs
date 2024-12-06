using dotNetEventManagement.Controllers;
using dotNetEventManagement.Models;
//using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AccountInformation : Form
    {
        private User user;
        private UserController userController;
        public AccountInformation(User user)
        {
            InitializeComponent();
            this.user = Session.CurrentUser;
            userController = new UserController();
            lockTxt(false);
            lblFullname.Text = Session.CurrentUser.Fullname;
            txtUsername.Text = Session.CurrentUser.Username;
            txtFullname.Text = Session.CurrentUser.Fullname;
            txtMail.Text = Session.CurrentUser.Mail;
            txtPhone.Text = Session.CurrentUser.Phone;
            dtpDateOfBirth.Value = Session.CurrentUser.DateOfBirth;
        }

        private void lockTxt(bool a)
        {
            txtFullname.Enabled = a;
            txtUsername.Enabled = a;
            txtMail.Enabled = a;
            txtPhone.Enabled = a;
            dtpDateOfBirth.Enabled = a;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lockTxt(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string fullname = txtFullname.Text;
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string mail = txtMail.Text;
            string phone = txtPhone.Text;
            DialogResult confirm = MessageBox.Show("bạn có chắc chắn muốn thay đổi thông tin?", "thông báo xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (userController.changeInformation(user.UserId, username, fullname, dateOfBirth, mail, phone))
                {
                    MessageBox.Show("cập nhật thông tin người dùng thành công!", "thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    User updateUser = new User(user.UserId, username, fullname, user.Password, dateOfBirth, mail, phone, user.Role);
                    Session.setUser(updateUser);
                    lblFullname.Text = fullname;
                    lockTxt(false);
                }
                else
                {
                    MessageBox.Show("cập nhật thông tin người dùng thất bại!", "lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void AccountInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
