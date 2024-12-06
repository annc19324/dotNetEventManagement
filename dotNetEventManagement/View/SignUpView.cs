using dotNetEventManagement.Controllers;
using dotNetEventManagement.Models;
//using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetEventManagement.View
{
    public partial class SignUpView : Form
    {
        private string verificationCode;
        private User user;
        private UserController userController;
        public SignUpView()
        {
            InitializeComponent();
            user = new User();
            userController = new UserController();
        }

        private void SignUpView_Load(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelLogInCenter();

        }

        private void btnBackToLogIn_Click(object sender, EventArgs e)
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
            panelSignUp.Left = (panelContainer.ClientSize.Width - panelSignUp.Width) / 2;
            panelSignUp.Top = (panelContainer.ClientSize.Height - panelSignUp.Height) / 2;
        }

        private void SignUpView_Resize(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelLogInCenter();
        }

        private void ClearE()
        {
            lblUsernameE.Text = "";
            lblFullNameE.Text = "";
            lblPasswordE.Text = "";
            lblConfirmPasswordE.Text = "";
            lblDateOfBirthE.Text = "";
            lblMailE.Text = "";
            lblPhoneE.Text = "";
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool foundE = false;
            ClearE();
            lblCodeE.Text = "";
            string username = txtUsername.Text;
            string fullname = txtFullname.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string mail = txtMail.Text;
            string phone = txtPhone.Text;
            int age = DateTime.Now.Year - dateOfBirth.Year;
            string enterCode = txtEnterCode.Text.Trim();

            if (string.IsNullOrEmpty(enterCode))
            {
                lblCodeE.Text = "mã xác thực không được để trống!";
                foundE = true;
            }
            else if (enterCode != verificationCode)
            {
                lblCodeE.Text = "mã xác thực không chính xác, vui lòng gửi lại!";
                foundE = true;
            }

            if (age < 16)
            {
                lblDateOfBirthE.Text = "trên 16 tuổi mới được đăng ký!";
                foundE = true;
            }

            if (string.IsNullOrEmpty(username))
            {
                lblUsernameE.Text = "tên người dùng không được để trống"!;
                foundE = true;
            }
            else if (username.Length < 6)
            {
                lblUsernameE.Text = "tên người dùng chứa ít nhất 6 kí tự!";
                foundE = true;
            }
            else if (!Regex.IsMatch(username, "^[a-zA-Z0-9]+$"))
            {
                lblUsernameE.Text = "tên người dùng chỉ được chứa a-z, A-Z, 0-9!";
                foundE = true;
            }

            if (string.IsNullOrEmpty(fullname))
            {
                lblFullNameE.Text = "tên đầy đủ không được để trống!";
                foundE = true;
            }
            else if (fullname.Length < 6)
            {
                lblUsernameE.Text = "họ tên người dùng chứa ít nhất 6 kí tự!";
                foundE = true;
            }
            else if (!Regex.IsMatch(fullname, @"^[a-zA-Z\u00C0-\u1EF9]+(?: [a-zA-Z\u00C0-\u1EF9]+)*$"))
            {
                lblFullNameE.Text = "tên đầy đủ chỉ được chứa a-z, A-Z và khoảng trắng";
                foundE = true;
            }


            if (string.IsNullOrEmpty(password))
            {
                lblPasswordE.Text = "mật khẩu không được để trống";
                foundE = true;
            }
            else if (password.Length < 8)
            {
                lblPasswordE.Text = "mật khẩu chứa ít nhất 8 kí tự!";
                foundE = true;
            }
            else if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$"))
            {
                lblPasswordE.Text = "mật khẩu chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 chữ số và 1 ít tự đặc biệt!";
                foundE = true;
            }


            if (string.IsNullOrEmpty(confirmPassword))
            {
                lblConfirmPasswordE.Text = "xác nhận mật khẩu không được để trống";
                foundE = true;
            }
            else if (!password.Equals(confirmPassword))
            {
                lblConfirmPasswordE.Text = "xác nhận mật khẩu không khớp với mật khẩu đã nhập!";
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

            if (string.IsNullOrEmpty(phone))
            {
                lblPhoneE.Text = "số điện thoại không được để trống!";
                foundE = true;
            }
            else if (!Regex.IsMatch(phone, @"^(\+84|0)(3|5|7|8|9)\d{8}$"))
            {
                lblPhoneE.Text = "số điện thoại không hợp lệ!";
                foundE = true;
            }


            if (foundE)
            {
                return;
            }


            user = new User(username, fullname, password, dateOfBirth, mail, phone);
            if (userController.addAccount(user))
            {
                MessageBox.Show("Đăng ký tài khoản " + user.Username + " thành công!");
                this.Hide();
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
                MessageBox.Show("đăng ký thất bại!");
            }


        }
        //tao ma xac thuc
        private string GenerateVerificationCode()
        {
            Random rand = new Random();
            //string code = rand.Next(0, 1000000).ToString();
            // lay so ngau nhien tu 0 den 999999
            int number = rand.Next(0, 1000000);
            // dam bao co 6 chu so, bo sung so 0 neu chua du 6 chu so
            string code = number.ToString("D6");
            return code;
        }

        //asynchronously: bat dong bo
        private async void btnSendCode_Click(object sender, EventArgs e)
        {
            String mail = txtMail.Text.Trim();
            if (string.IsNullOrEmpty(mail))
            {
                MessageBox.Show("vui lòng nhập mail để gửi mã xác nhận!");
                return;
            }
            lblCodeE.Text = "mã xác thực đang được gửi đến mail " + mail + ".";
            verificationCode = GenerateVerificationCode();
            await SendVerificationMail(mail, verificationCode);
            lblCodeE.Text = "mã xác thực đã được gửi đến " + mail + ".";
        }
        //gmzf qeya ldmv hxig
        //javaeventmanagement
        private async Task SendVerificationMail(string mail, string code)
        {
            try
            {
                SmtpClient sc = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("javaeventmanagement@gmail.com", "gmzf qeya ldmv hxig"), // Cập nhật thông tin tài khoản email
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
    }
}
