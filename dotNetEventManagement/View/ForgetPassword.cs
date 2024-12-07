using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using dotNetEventManagement.Controllers;
using dotNetEventManagement.Models;

namespace dotNetEventManagement.View
{
    public partial class ForgetPassword : Form
    {
        private string CodeForForgetPassword;
        private UserController userController;
        public ForgetPassword()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelChangePasswordCenter();
        }

        private void ForgetPassword_Resize(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelChangePasswordCenter();
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

        private void panelChangePasswordCenter()
        {
            panelChangePassword.Left = (panelContainer.ClientSize.Width - panelChangePassword.Width) / 2;
            panelChangePassword.Top = (panelContainer.ClientSize.Height - panelChangePassword.Height) / 2;
        }

        private string createCode()
        {
            Random random = new Random();
            int number = random.Next(0, 1000000);
            string code = number.ToString("D6");
            return code;
        }

        private async Task sendToMail(string mail, string code)
        {
            try
            {
                SmtpClient sc = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("javaeventmanagement@gmail.com", "gmzf qeya ldmv hxig"),
                    EnableSsl = true
                };

                //tao thong tin gui mail
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("javaeventmanagement@gmail.com", "Event Management"),
                    Subject = "dotNetEventManagement gửi mã xác thực",
                    Body = $"Mã xác thực của bạn là: {code}",
                    IsBodyHtml = false
                };

                //nguoi nhan
                mailMessage.To.Add(mail);
                //sc.Send(mailMessage);

                //gui mail bat dong bo
                await sc.SendMailAsync(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}");
            }
        }

        private async void btnSendCode_Click(object sender, EventArgs e)
        {
            String mail = txtMail.Text.Trim();
            if (string.IsNullOrEmpty(mail))
            {
                MessageBox.Show("vui lòng nhập mail để gửi mã xác nhận!");
                return;
            }
            lblEnterCodeE.Text = "mã xác thực đang được gửi đến mail " + mail + ".";
            CodeForForgetPassword = createCode();
            await sendToMail(mail, CodeForForgetPassword);
            lblEnterCodeE.Text = "mã xác thực đã được gửi đến " + mail + ".";
        }

        private void clearE()
        {
            lblUsernameE.Text = "";
            lblMailE.Text = "";
            lblEnterCodeE.Text = "";
            lblNewPasswordE.Text = "";
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string mail = txtMail.Text.Trim();
            string code = txtEnterCode.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            clearE();

            bool foundE = false;

            if (string.IsNullOrEmpty(username))
            {
                lblUsernameE.Text = "tên người dùng không được để trống"!;
                foundE = true;
            }

            if (string.IsNullOrEmpty(username))
            {
                lblUsernameE.Text = "tên người dùng không được để trống"!;
                foundE = true;
            }

            if (string.IsNullOrEmpty(mail))
            {
                lblMailE.Text = "mail không được để trống!";
                foundE = true;
            }
            else if (!Regex.IsMatch(mail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                lblMailE.Text = "mail không hợp lệ!";
                foundE = true;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                lblNewPasswordE.Text = "mật khẩu không được để trống";
                foundE = true;
            }
            else if (newPassword.Length < 8)
            {
                lblNewPasswordE.Text = "mật khẩu chứa ít nhất 8 kí tự!";
                foundE = true;
            }
            else if (!Regex.IsMatch(newPassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$"))
            {
                lblNewPasswordE.Text = "mật khẩu chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 chữ số và 1 ít tự đặc biệt!";
                foundE = true;
            }

            if (string.IsNullOrEmpty(code)) {
                lblEnterCodeE.Text = "mã xác thực không được để trống!";
                foundE = true;
            }else if (code != CodeForForgetPassword)
            {
                lblEnterCodeE.Text = "mã xác thực không chính xác, vui lòng gửi lại!";
                foundE=true;
            }


            if (foundE)
            {
                return;
            }

            if(userController.changePassword(username, newPassword, mail))
            {
                this.Hide();
                MessageBox.Show("Cập nhật mật khẩu thành công!");
                var newWindowState = new LogInView();
                if (this.WindowState == FormWindowState.Maximized)
                {
                    newWindowState.WindowState = FormWindowState.Maximized;
                }
                newWindowState.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("cập nhật mật khẩu thất bại, mail " + mail + " không có trong tài khoản " + username + "!");
            }

        }
    }
}
