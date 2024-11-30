using dotNetEventManagement.Controllers;
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

            LoginStatus status = userController.CheckLogin(username, password);
            if (status == LoginStatus.UsernameNotFound)
            {
                lblUsernameE.Text = "tài khoản không tồn tại!";
                return;
            }
            else if (status == LoginStatus.PasswordNotFound)
            {
                lblPasswordE.Text = "sai mật khẩu!";
                lblForgetPassword.ForeColor = Color.Red;
                lblForgetPassword.Font = new Font("Sogoe UI", 10);
                return;
            }
            else if (status == LoginStatus.Admin)
            {
                this.Hide();
                new AdminHome().ShowDialog();
                this.Close();
            }
            else if (status == LoginStatus.User)
            {
                this.Hide();
                new UserHome().ShowDialog();
                this.Close();
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpView().ShowDialog();
            this.Close();

        }
    }
}
