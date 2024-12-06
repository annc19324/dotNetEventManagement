using dotNetEventManagement.Controllers;
using dotNetEventManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetEventManagement.View
{
    public partial class ChangePasswordView : Form
    {
        private User user;
        private UserController userController;
        private bool isOpeningMenu = false;
        private const int menuWidth = 260;
        public ChangePasswordView(User user)
        {
            InitializeComponent();
            this.user = Session.CurrentUser;
            userController = new UserController();
            lblFullname.Text = user.Fullname;

        }

        private void btnUserHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHome(Session.CurrentUser).ShowDialog();
            this.Close();
        }
        private void clearE()
        {
            labelOldPasswordE.Text = string.Empty;
            labelNewPasswordE.Text = string.Empty;
            labelConfirmPasswordE.Text = string.Empty;
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            clearE();
            bool foundE = false;
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirm = txtConfirmPassword.Text;
            if (string.IsNullOrEmpty(oldPassword))
            {
                labelOldPasswordE.Text = "mật khẩu không được để trống";
                foundE = true;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                labelNewPasswordE.Text = "mật khẩu không được để trống";
                foundE = true;
            }
            else if (newPassword.Length < 8)
            {
                labelNewPasswordE.Text = "mật khẩu chứa ít nhất 8 kí tự!";
                foundE = true;
            }
            else if (!Regex.IsMatch(confirm, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$"))
            {
                labelConfirmPasswordE.Text = "mật khẩu chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 chữ số và 1 ít tự đặc biệt!";
                foundE = true;
            }
            if (string.IsNullOrEmpty(confirm))
            {
                labelConfirmPasswordE.Text = "mật khẩu không được để trống";
                foundE = true;
            }
            else if (confirm != newPassword)
            {
                labelConfirmPasswordE.Text = "xác nhận mật khẩu không trùng khớp với mật khẩu mới!";
                foundE = true;
            }

            if (foundE)
            {
                return;
            }

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

        private void lblMenu_Click(object sender, EventArgs e)
        {
            OpenMenu();
        }

        private void ChangePasswordView_Load(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelHomeCenter();
            panelContentCenter();
            panelHeader.Width = panelMain.Width;
            panelContainer.Height = panelMain.Height - panelHeader.Height;
            panelContainer.Width = panelMain.Width;
            pnlSlideMenu.Height = panelMain.Height;
        }

        private void ChangePasswordView_Resize(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelHomeCenter();
            panelContentCenter();
            panelHeader.Width = panelMain.Width;
            panelContainer.Height = panelMain.Height - panelHeader.Height;
            panelContainer.Width = panelMain.Width;
            pnlSlideMenu.Height = panelMain.Height;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new UserHome(Session.CurrentUser);
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void labelEventList_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new EventList(Session.CurrentUser);
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void labelRegisteredEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new RegisteredEvent(Session.CurrentUser);
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void labelAccountInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new AccountInformation(Session.CurrentUser);
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new HelpView(Session.CurrentUser);
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void labelChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new ChangePasswordView(Session.CurrentUser);
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn có chắc muốn đăng xuất?", "xác nhận đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Session.clear();
                new LogInView().ShowDialog();
                this.Close();
            }
        }

        private void panelContainer_Click(object sender, EventArgs e)
        {
            if (isOpeningMenu)
            {
                CloseMenu();
            }
        }

        //them moi
        private void OpenMenu()
        {
            panelContainer.BringToFront();
            panelHome.SendToBack();
            panelContainer.BackColor = Color.LightGray;
            panelHome.Enabled = false;
            pnlSlideMenu.BringToFront();
            pnlSlideMenu.BackColor = Color.DarkGray;

            isOpeningMenu = true;

            new Thread(() =>
            {
                for (int i = 0; i <= menuWidth; i += 20)
                {
                    this.Invoke((Action)(() =>
                    {
                        pnlSlideMenu.Size = new Size(i, pnlSlideMenu.Height);
                    }));
                    Thread.Sleep(10);
                }
            }).Start();
        }

        private void CloseMenu()
        {
            panelHome.BringToFront();
            panelContainer.SendToBack();
            //panelContainer.BackColor = Color.Transparent;
            panelHome.Enabled = true;

            isOpeningMenu = false;

            panelContainer.Visible = true;

            new Thread(() =>
            {
                for (int i = menuWidth; i >= 0; i -= 20)
                {
                    this.Invoke((Action)(() =>
                    {
                        pnlSlideMenu.Size = new Size(i, pnlSlideMenu.Height);
                    }));
                    Thread.Sleep(10);
                }
            }).Start();
        }

        private void panelContainerCenter()
        {
            //panelMain.Left = (this.ClientSize.Width - panelMain.Width) / 2;
            //panelMain.Top = (this.ClientSize.Height - panelMain.Height) / 2;
            panelMain.Left = 0;
            panelMain.Top = 0;
            panelMain.Width = this.ClientSize.Width;
            panelMain.Height = this.ClientSize.Height;
            panelContainer.Left = panelMain.Left;
            panelContainer.Top = panelHeader.Bottom;
            panelContainer.Width = this.ClientSize.Width;
            panelContainer.Height = this.ClientSize.Height - panelHeader.Height;
        }

        private void lblHeaderCenter()
        {
            lblFullname.Left = (panelHeader.ClientSize.Width - lblFullname.Width) / 2;
            lblFullname.Top = (panelHeader.ClientSize.Height - lblFullname.Height) / 2;
        }

        private void panelHomeCenter()
        {
            panelHome.Width = panelContainer.Width;
            panelHome.Height = panelContainer.Height;
            panelHome.Left = 0;
            panelHome.Top = 0;

        }

        private void panelContentCenter()
        {
            panelContent.Left = (panelHome.ClientSize.Width - panelContent.Width) / 2;
            panelContent.Top = (panelHome.ClientSize.Height - panelContent.Height) / 2;
        }
    }
}
