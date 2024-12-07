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
    public partial class UserHome : Form
    {
        private User user;
        private bool isOpeningMenu = false;
        private const int menuWidth = 260;
        public UserHome(User user)
        {
            InitializeComponent();

            this.user = Session.CurrentUser;
            lblFullname.Text = Session.CurrentUser.Fullname;


        }

        private void OpenMenu()
        {
            panelContainer.BringToFront();
            panelHome.SendToBack();
            panelHome.Enabled = false;
            pnlSlideMenu.BringToFront();
            pnlSlideMenu.BackColor = SystemColors.MenuHighlight;
            panelContainer.BackColor = SystemColors.GradientActiveCaption;
            panelHeader.BackColor = SystemColors.GradientActiveCaption;


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
            panelHome.Enabled = true;
            panelContainer.BackColor = Color.Transparent;
            panelHeader.BackColor = Color.Transparent;
            pnlSlideMenu.BackColor= SystemColors.GradientActiveCaption;

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

        private void label1_Click(object sender, EventArgs e)
        {
            OpenMenu();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelHomeCenter();
            panelNavigationCenter();


            panelHeader.Width = panelMain.Width;
            panelContainer.Height = panelMain.Height - panelHeader.Height;
            panelContainer.Width = panelMain.Width;
            pnlSlideMenu.Height = panelMain.Height;
            panelHome.Width = panelContainer.Width;
            panelHome.Height = panelContainer.Height;

        }

        private void UserHome_Resize(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelHomeCenter();
            panelNavigationCenter();

            panelHeader.Width = panelMain.Width;
            panelContainer.Height = panelMain.Height - panelHeader.Height;
            panelContainer.Width = panelMain.Width;
            pnlSlideMenu.Height = panelMain.Height;
            panelHome.Width = panelContainer.Width;
            panelHome.Height = panelContainer.Height;

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
            //panelHome.Left = (panelContainer.ClientSize.Width - panelHome.Width) / 2;
            //panelHome.Top = (panelContainer.ClientSize.Height - panelHome.Height) / 2;
            panelHome.Width = panelContainer.Width;
            panelHome.Height = panelContainer.Height;
            panelHome.Left = 0;
            panelHome.Top = 0;

        }

        private void panelNavigationCenter()
        {
            panelNavigation.Left = (panelHome.ClientSize.Width - panelNavigation.Width) / 2;
            panelNavigation.Top = (panelHome.ClientSize.Height - panelNavigation.Height) / 2;
        }

        private void panelContainer_Click(object sender, EventArgs e)
        {
            if (isOpeningMenu)
            {
                CloseMenu();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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

        private void btnInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountInformation(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void btnEventList_Click(object sender, EventArgs e)
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

        private void btnRegisteredEvent_Click(object sender, EventArgs e)
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
