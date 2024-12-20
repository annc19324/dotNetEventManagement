﻿namespace dotNetEventManagement.View
{
    partial class SignUpView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            panelContainer = new Panel();
            panelSignUp = new Panel();
            LeakOrHideConfirm = new Label();
            LeakOrHidePassword = new Label();
            lblCodeE = new Label();
            btnSignUp = new Button();
            label8 = new Label();
            btnSendCode = new Button();
            txtEnterCode = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            lblPhoneE = new Label();
            lblMailE = new Label();
            lblDateOfBirthE = new Label();
            lblConfirmPasswordE = new Label();
            lblPasswordE = new Label();
            lblFullNameE = new Label();
            lblUsernameE = new Label();
            btnBackToLogIn = new Button();
            txtPhone = new TextBox();
            txtConfirmPassword = new TextBox();
            txtMail = new TextBox();
            txtPassword = new TextBox();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelHeader = new Panel();
            lblHeader = new Label();
            panelMain.SuspendLayout();
            panelContainer.SuspendLayout();
            panelSignUp.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.Controls.Add(panelContainer);
            panelMain.Controls.Add(panelHeader);
            panelMain.Location = new Point(0, -12);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(890, 750);
            panelMain.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panelSignUp);
            panelContainer.Location = new Point(12, 114);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(866, 633);
            panelContainer.TabIndex = 1;
            // 
            // panelSignUp
            // 
            panelSignUp.Controls.Add(LeakOrHideConfirm);
            panelSignUp.Controls.Add(LeakOrHidePassword);
            panelSignUp.Controls.Add(lblCodeE);
            panelSignUp.Controls.Add(btnSignUp);
            panelSignUp.Controls.Add(label8);
            panelSignUp.Controls.Add(btnSendCode);
            panelSignUp.Controls.Add(txtEnterCode);
            panelSignUp.Controls.Add(dtpDateOfBirth);
            panelSignUp.Controls.Add(lblPhoneE);
            panelSignUp.Controls.Add(lblMailE);
            panelSignUp.Controls.Add(lblDateOfBirthE);
            panelSignUp.Controls.Add(lblConfirmPasswordE);
            panelSignUp.Controls.Add(lblPasswordE);
            panelSignUp.Controls.Add(lblFullNameE);
            panelSignUp.Controls.Add(lblUsernameE);
            panelSignUp.Controls.Add(btnBackToLogIn);
            panelSignUp.Controls.Add(txtPhone);
            panelSignUp.Controls.Add(txtConfirmPassword);
            panelSignUp.Controls.Add(txtMail);
            panelSignUp.Controls.Add(txtPassword);
            panelSignUp.Controls.Add(txtFullname);
            panelSignUp.Controls.Add(txtUsername);
            panelSignUp.Controls.Add(label7);
            panelSignUp.Controls.Add(label6);
            panelSignUp.Controls.Add(label5);
            panelSignUp.Controls.Add(label4);
            panelSignUp.Controls.Add(label3);
            panelSignUp.Controls.Add(label2);
            panelSignUp.Controls.Add(label1);
            panelSignUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            panelSignUp.ForeColor = Color.Gold;
            panelSignUp.Location = new Point(38, 20);
            panelSignUp.Name = "panelSignUp";
            panelSignUp.Size = new Size(789, 604);
            panelSignUp.TabIndex = 0;
            // 
            // LeakOrHideConfirm
            // 
            LeakOrHideConfirm.AutoSize = true;
            LeakOrHideConfirm.BackColor = Color.White;
            LeakOrHideConfirm.ForeColor = Color.Black;
            LeakOrHideConfirm.Location = new Point(693, 210);
            LeakOrHideConfirm.Name = "LeakOrHideConfirm";
            LeakOrHideConfirm.Size = new Size(47, 31);
            LeakOrHideConfirm.TabIndex = 28;
            LeakOrHideConfirm.Text = "👁";
            LeakOrHideConfirm.Click += LeakOrHideConfirm_Click;
            // 
            // LeakOrHidePassword
            // 
            LeakOrHidePassword.AutoSize = true;
            LeakOrHidePassword.BackColor = Color.White;
            LeakOrHidePassword.ForeColor = Color.Black;
            LeakOrHidePassword.Location = new Point(693, 146);
            LeakOrHidePassword.Name = "LeakOrHidePassword";
            LeakOrHidePassword.Size = new Size(47, 31);
            LeakOrHidePassword.TabIndex = 27;
            LeakOrHidePassword.Text = "👁";
            LeakOrHidePassword.Click += LeakOrHidePassword_Click;
            // 
            // lblCodeE
            // 
            lblCodeE.AutoSize = true;
            lblCodeE.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodeE.ForeColor = Color.Gold;
            lblCodeE.Location = new Point(287, 440);
            lblCodeE.Name = "lblCodeE";
            lblCodeE.Size = new Size(0, 20);
            lblCodeE.TabIndex = 26;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DeepSkyBlue;
            btnSignUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(435, 538);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(305, 45);
            btnSignUp.TabIndex = 14;
            btnSignUp.Text = "Đăng ký tài khoản";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(54, 402);
            label8.Name = "label8";
            label8.Size = new Size(220, 31);
            label8.TabIndex = 25;
            label8.Text = "Nhập mã xác thực: ";
            // 
            // btnSendCode
            // 
            btnSendCode.BackColor = Color.DeepSkyBlue;
            btnSendCode.ForeColor = Color.White;
            btnSendCode.Location = new Point(595, 398);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(145, 38);
            btnSendCode.TabIndex = 24;
            btnSendCode.Text = "Gửi mã";
            btnSendCode.UseVisualStyleBackColor = false;
            btnSendCode.Click += btnSendCode_Click;
            // 
            // txtEnterCode
            // 
            txtEnterCode.Location = new Point(284, 399);
            txtEnterCode.Name = "txtEnterCode";
            txtEnterCode.Size = new Size(305, 38);
            txtEnterCode.TabIndex = 23;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(284, 274);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(456, 38);
            dtpDateOfBirth.TabIndex = 11;
            // 
            // lblPhoneE
            // 
            lblPhoneE.AutoSize = true;
            lblPhoneE.Font = new Font("Segoe UI", 9F);
            lblPhoneE.ForeColor = Color.Gold;
            lblPhoneE.Location = new Point(287, 506);
            lblPhoneE.Name = "lblPhoneE";
            lblPhoneE.Size = new Size(0, 20);
            lblPhoneE.TabIndex = 22;
            // 
            // lblMailE
            // 
            lblMailE.AutoSize = true;
            lblMailE.Font = new Font("Segoe UI", 9F);
            lblMailE.ForeColor = Color.Gold;
            lblMailE.Location = new Point(284, 376);
            lblMailE.Name = "lblMailE";
            lblMailE.Size = new Size(0, 20);
            lblMailE.TabIndex = 21;
            // 
            // lblDateOfBirthE
            // 
            lblDateOfBirthE.AutoSize = true;
            lblDateOfBirthE.Font = new Font("Segoe UI", 9F);
            lblDateOfBirthE.ForeColor = Color.Gold;
            lblDateOfBirthE.Location = new Point(284, 312);
            lblDateOfBirthE.Name = "lblDateOfBirthE";
            lblDateOfBirthE.Size = new Size(0, 20);
            lblDateOfBirthE.TabIndex = 20;
            // 
            // lblConfirmPasswordE
            // 
            lblConfirmPasswordE.AutoSize = true;
            lblConfirmPasswordE.Font = new Font("Segoe UI", 9F);
            lblConfirmPasswordE.ForeColor = Color.Gold;
            lblConfirmPasswordE.Location = new Point(284, 248);
            lblConfirmPasswordE.Name = "lblConfirmPasswordE";
            lblConfirmPasswordE.Size = new Size(0, 20);
            lblConfirmPasswordE.TabIndex = 19;
            // 
            // lblPasswordE
            // 
            lblPasswordE.AutoSize = true;
            lblPasswordE.Font = new Font("Segoe UI", 9F);
            lblPasswordE.ForeColor = Color.Gold;
            lblPasswordE.Location = new Point(284, 184);
            lblPasswordE.Name = "lblPasswordE";
            lblPasswordE.Size = new Size(0, 20);
            lblPasswordE.TabIndex = 18;
            // 
            // lblFullNameE
            // 
            lblFullNameE.AutoSize = true;
            lblFullNameE.Font = new Font("Segoe UI", 9F);
            lblFullNameE.ForeColor = Color.Gold;
            lblFullNameE.Location = new Point(284, 120);
            lblFullNameE.Name = "lblFullNameE";
            lblFullNameE.Size = new Size(0, 20);
            lblFullNameE.TabIndex = 17;
            // 
            // lblUsernameE
            // 
            lblUsernameE.AutoSize = true;
            lblUsernameE.Font = new Font("Segoe UI", 9F);
            lblUsernameE.ForeColor = Color.Gold;
            lblUsernameE.Location = new Point(284, 56);
            lblUsernameE.Name = "lblUsernameE";
            lblUsernameE.Size = new Size(0, 20);
            lblUsernameE.TabIndex = 16;
            // 
            // btnBackToLogIn
            // 
            btnBackToLogIn.BackColor = Color.DeepSkyBlue;
            btnBackToLogIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnBackToLogIn.ForeColor = Color.White;
            btnBackToLogIn.Location = new Point(54, 538);
            btnBackToLogIn.Name = "btnBackToLogIn";
            btnBackToLogIn.Size = new Size(321, 45);
            btnBackToLogIn.TabIndex = 15;
            btnBackToLogIn.Text = "Đã có tài khoản?";
            btnBackToLogIn.UseVisualStyleBackColor = false;
            btnBackToLogIn.Click += btnBackToLogIn_Click;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPhone.Location = new Point(284, 465);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(456, 38);
            txtPhone.TabIndex = 13;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtConfirmPassword.Location = new Point(284, 207);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(456, 38);
            txtConfirmPassword.TabIndex = 10;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtMail.Location = new Point(284, 335);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(456, 38);
            txtMail.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(284, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(456, 38);
            txtPassword.TabIndex = 9;
            // 
            // txtFullname
            // 
            txtFullname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtFullname.Location = new Point(284, 79);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(456, 38);
            txtFullname.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtUsername.Location = new Point(284, 15);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(456, 38);
            txtUsername.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(54, 468);
            label7.Name = "label7";
            label7.Size = new Size(169, 31);
            label7.TabIndex = 6;
            label7.Text = "Số điện thoại: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(54, 338);
            label6.Name = "label6";
            label6.Size = new Size(74, 31);
            label6.TabIndex = 5;
            label6.Text = "Mail: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(54, 274);
            label5.Name = "label5";
            label5.Size = new Size(133, 31);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(54, 210);
            label4.Name = "label4";
            label4.Size = new Size(223, 31);
            label4.TabIndex = 3;
            label4.Text = "Nhập lại mật khẩu: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 146);
            label3.Name = "label3";
            label3.Size = new Size(128, 31);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 82);
            label2.Name = "label2";
            label2.Size = new Size(99, 31);
            label2.TabIndex = 1;
            label2.Text = "Họ tên: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 18);
            label1.Name = "label1";
            label1.Size = new Size(195, 31);
            label1.TabIndex = 0;
            label1.Text = "Tên người dùng: ";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Location = new Point(12, 12);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(866, 96);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(323, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(208, 62);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Đăng ký";
            // 
            // SignUpView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(890, 738);
            Controls.Add(panelMain);
            Name = "SignUpView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpView";
            Load += SignUpView_Load;
            Resize += SignUpView_Resize;
            panelMain.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelSignUp.ResumeLayout(false);
            panelSignUp.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelContainer;
        private Panel panelSignUp;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelHeader;
        private Label lblHeader;
        private Label lblFullNameE;
        private Label lblUsernameE;
        private Button btnBackToLogIn;
        private Button btnSignUp;
        private TextBox txtPhone;
        private TextBox txtConfirmPassword;
        private TextBox txtMail;
        private TextBox txtPassword;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private Label lblPhoneE;
        private Label lblMailE;
        private Label lblDateOfBirthE;
        private Label lblConfirmPasswordE;
        private Label lblPasswordE;
        private DateTimePicker dtpDateOfBirth;
        private Button btnSendCode;
        private TextBox txtEnterCode;
        private Label label8;
        private Label lblCodeE;
        private Label LeakOrHideConfirm;
        private Label LeakOrHidePassword;
    }
}