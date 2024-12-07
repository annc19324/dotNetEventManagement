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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetEventManagement.View
{
    public partial class AccountInformation : Form
    {
        private User user;
        private UserController userController;
        private bool isOpeningMenu = false;
        private const int menuWidth = 260;
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
            dtpDateOfBirth.Value = Session.CurrentUser.DateOfBirth ?? DateTime.Now;
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

        private void clearE()
        {
            labelUsernameE.Text = string.Empty;
            labelFullnameE.Text = string.Empty;
            labelDateOfBirthE.Text = string.Empty;
            labelMailE.Text = string.Empty;
            labelPhoneE.Text = string.Empty;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            clearE();
            bool foundE = false;
            string username = txtUsername.Text;
            string fullname = txtFullname.Text;
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string mail = txtMail.Text;
            string phone = txtPhone.Text;

            if (string.IsNullOrEmpty(username))
            {
                labelUsernameE.Text = "tên người dùng không được để trống"!;
                foundE = true;
            }
            else if (username.Length < 6)
            {
                labelUsernameE.Text = "tên người dùng chứa ít nhất 6 kí tự!";
                foundE = true;
            }
            else if (!Regex.IsMatch(username, "^[a-zA-Z0-9]+$"))
            {
                labelUsernameE.Text = "tên người dùng chỉ được chứa a-z, A-Z, 0-9!";
                foundE = true;
            }


            if (string.IsNullOrEmpty(fullname))
            {
                labelFullnameE.Text = "tên đầy đủ không được để trống!";
                foundE = true;
            }
            else if (fullname.Length < 6)
            {
                labelFullnameE.Text = "họ tên người dùng chứa ít nhất 6 kí tự!";
                foundE = true;
            }
            else if (!Regex.IsMatch(fullname, @"^[a-zA-Z\u00C0-\u1EF9]+(?: [a-zA-Z\u00C0-\u1EF9]+)*$"))
            {
                labelFullnameE.Text = "tên đầy đủ chỉ được chứa a-z, A-Z và khoảng trắng";
                foundE = true;
            }

            if (string.IsNullOrEmpty(mail))
            {
                labelMailE.Text = "mail không được để trống!";
                foundE = true;
            }
            else if (!Regex.IsMatch(mail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                labelMailE.Text = "mail không hợp lệ!";
                foundE = true;
            }

            if (string.IsNullOrEmpty(phone))
            {
                labelPhoneE.Text = "số điện thoại không được để trống!";
                foundE = true;
            }
            else if (!Regex.IsMatch(phone, @"^(\+84|0)(3|5|7|8|9)\d{8}$"))
            {
                labelPhoneE.Text = "số điện thoại không hợp lệ!";
                foundE = true;
            }

            int age = DateTime.Now.Year - dateOfBirth.Year;

            if (age < 16)
            {
                labelDateOfBirthE.Text = "bạn chưa đủ 16 tuổi, điều này vi phạm đăng ký";
                foundE = true;
            }

            if (foundE)
            {
                return;
            }

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
            panelContainerCenter();
            lblHeaderCenter();
            panelHomeCenter();
            panelContentCenter();
            panelHeader.Width = panelMain.Width;
            panelContainer.Height = panelMain.Height - panelHeader.Height;
            panelContainer.Width = panelMain.Width;
            pnlSlideMenu.Height = panelMain.Height;
        }

        private void AccountInformation_Resize(object sender, EventArgs e)
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

        private void panelContainer_Click(object sender, EventArgs e)
        {
            if (isOpeningMenu)
            {
                CloseMenu();
            }
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

        //ket thuc them moi

        //them moi
        private void OpenMenu()
        {
            panelContainer.BringToFront();
            panelHome.SendToBack();
            panelContainer.BackColor = SystemColors.GradientActiveCaption;
            panelHeader.BackColor = SystemColors.GradientActiveCaption;
            pnlSlideMenu.BackColor = SystemColors.MenuHighlight;

            panelHome.Enabled = false;
            pnlSlideMenu.BringToFront();

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
            panelContainer.BackColor = Color.Transparent;
            panelHeader.BackColor = Color.Transparent;
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

        private void lblMenu_Click(object sender, EventArgs e)
        {
            OpenMenu();
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
    }
}
