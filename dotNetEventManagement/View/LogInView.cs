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
using static dotNetEventManagement.Controllers.UserController;

namespace dotNetEventManagement.View
{
    public partial class LogInView : Form
    {
        private UserController userController;

        public LogInView()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void LogInView_Load(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelLogInCenter();
        }

        private void LogInView_Resize(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelLogInCenter();
        }

        private void panelContainerCenter()
        {
            panelMain.Left = (this.ClientSize.Width - panelMain.Width) / 2;
            panelMain.Top = (this.ClientSize.Height - panelMain.Height) / 2;
        }

        private void lblHeaderCenter()
        {
            lblHeader.Left = (panelHeader.ClientSize.Width - lblHeader.Width) / 2;
            lblHeader.Top = (panelHeader.ClientSize.Height - lblHeader.Height) / 2;
        }

        private void panelLogInCenter()
        {
            panelLogIn.Left = (panelContainer.ClientSize.Width - panelLogIn.Width) / 2;
            panelLogIn.Top = (panelContainer.ClientSize.Height - panelLogIn.Height) / 2;
        }

        private void ClearE()
        {
            lblUsernameE.Text = "";
            lblPasswordE.Text = "";
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool foundE = false;
            ClearE();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username))
            {
                lblUsernameE.Text = "tên người dùng không được để trống";
                foundE = true;
            }
            if (String.IsNullOrEmpty(password))
            {
                lblPasswordE.Text = "mật khẩu không được để trống";
                foundE = true;
            }

            if (foundE)
            {
                return;
            }
            bool checkUsername = userController.checkUsernameExist(username);
            if (!checkUsername) {
                lblUsernameE.Text = "Tên người dùng không tồn tại";
                return;
            }

            User user = userController.CheckLogin(username, password);
            if (user == null)
            {
                lblPasswordE.Text = "Sai mật khẩu!";
                return;
            }

            Session.CurrentUser = user;
            if (user.Role.Equals("admin"))
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
            else if (user.Role.Equals("user"))
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


        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new SignUpView();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();

        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new ForgetPassword();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void leakOrHidePassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '•')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }
    }
}
