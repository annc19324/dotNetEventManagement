﻿namespace dotNetEventManagement.View
{
    partial class ChangePasswordView
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
            panelHome = new Panel();
            panelContent = new Panel();
            panel3 = new Panel();
            btnChangePassword = new Button();
            btnUserHome = new Button();
            labelConfirmPasswordE = new Label();
            labelNewPassword = new Label();
            labelOldPasswordE = new Label();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pnlSlideMenu = new Panel();
            panelMenu = new Panel();
            labelLogOut = new Label();
            labelClose = new Label();
            labelChangePassword = new Label();
            labelHelp = new Label();
            labelAccountInformation = new Label();
            labelRegisteredEvent = new Label();
            labelEventList = new Label();
            labelHome = new Label();
            panelHeader = new Panel();
            lblMenu = new Label();
            lblFullname = new Label();
            panelMain.SuspendLayout();
            panelContainer.SuspendLayout();
            panelHome.SuspendLayout();
            panelContent.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlSlideMenu.SuspendLayout();
            panelMenu.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.BackColor = Color.Transparent;
            panelMain.Controls.Add(panelContainer);
            panelMain.Controls.Add(pnlSlideMenu);
            panelMain.Controls.Add(panelHeader);
            panelMain.Location = new Point(14, 12);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(871, 562);
            panelMain.TabIndex = 3;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.None;
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Controls.Add(panelHome);
            panelContainer.Location = new Point(3, 76);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(865, 473);
            panelContainer.TabIndex = 2;
            // 
            // panelHome
            // 
            panelHome.Anchor = AnchorStyles.None;
            panelHome.BackColor = Color.Transparent;
            panelHome.Controls.Add(panelContent);
            panelHome.Location = new Point(16, 16);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(826, 441);
            panelHome.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.None;
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(panel3);
            panelContent.Controls.Add(labelConfirmPasswordE);
            panelContent.Controls.Add(labelNewPassword);
            panelContent.Controls.Add(labelOldPasswordE);
            panelContent.Controls.Add(txtConfirmPassword);
            panelContent.Controls.Add(txtNewPassword);
            panelContent.Controls.Add(txtOldPassword);
            panelContent.Controls.Add(label6);
            panelContent.Controls.Add(label3);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(panel1);
            panelContent.Location = new Point(21, 37);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(783, 375);
            panelContent.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnChangePassword);
            panel3.Controls.Add(btnUserHome);
            panel3.Location = new Point(6, 297);
            panel3.Name = "panel3";
            panel3.Size = new Size(771, 65);
            panel3.TabIndex = 1;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Font = new Font("Segoe UI", 12F);
            btnChangePassword.Location = new Point(496, 3);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(272, 57);
            btnChangePassword.TabIndex = 1;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnUserHome
            // 
            btnUserHome.Font = new Font("Segoe UI", 12F);
            btnUserHome.Location = new Point(6, 3);
            btnUserHome.Name = "btnUserHome";
            btnUserHome.Size = new Size(229, 57);
            btnUserHome.TabIndex = 0;
            btnUserHome.Text = "Trở lại trang chủ";
            btnUserHome.UseVisualStyleBackColor = true;
            btnUserHome.Click += btnUserHome_Click;
            // 
            // labelConfirmPasswordE
            // 
            labelConfirmPasswordE.AutoSize = true;
            labelConfirmPasswordE.ForeColor = Color.Red;
            labelConfirmPasswordE.Location = new Point(238, 269);
            labelConfirmPasswordE.Name = "labelConfirmPasswordE";
            labelConfirmPasswordE.Size = new Size(0, 20);
            labelConfirmPasswordE.TabIndex = 15;
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.ForeColor = Color.Red;
            labelNewPassword.Location = new Point(238, 209);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(0, 20);
            labelNewPassword.TabIndex = 12;
            // 
            // labelOldPasswordE
            // 
            labelOldPasswordE.AutoSize = true;
            labelOldPasswordE.ForeColor = Color.Red;
            labelOldPasswordE.Location = new Point(238, 149);
            labelOldPasswordE.Name = "labelOldPasswordE";
            labelOldPasswordE.Size = new Size(0, 20);
            labelOldPasswordE.TabIndex = 11;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Location = new Point(238, 232);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(539, 34);
            txtConfirmPassword.TabIndex = 10;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F);
            txtNewPassword.Location = new Point(238, 172);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '•';
            txtNewPassword.Size = new Size(539, 34);
            txtNewPassword.TabIndex = 7;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Font = new Font("Segoe UI", 12F);
            txtOldPassword.Location = new Point(238, 110);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(539, 34);
            txtOldPassword.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(39, 235);
            label6.Name = "label6";
            label6.Size = new Size(186, 28);
            label6.TabIndex = 5;
            label6.Text = "Xác nhận mật khẩu: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(39, 175);
            label3.Name = "label3";
            label3.Size = new Size(142, 28);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu mới: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(40, 113);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu cũ";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 97);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 89);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 18);
            label1.Name = "label1";
            label1.Size = new Size(260, 54);
            label1.TabIndex = 0;
            label1.Text = "Đổi mật khẩu";
            // 
            // pnlSlideMenu
            // 
            pnlSlideMenu.Controls.Add(panelMenu);
            pnlSlideMenu.Location = new Point(0, 0);
            pnlSlideMenu.Name = "pnlSlideMenu";
            pnlSlideMenu.Size = new Size(0, 542);
            pnlSlideMenu.TabIndex = 1;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(labelLogOut);
            panelMenu.Controls.Add(labelClose);
            panelMenu.Controls.Add(labelChangePassword);
            panelMenu.Controls.Add(labelHelp);
            panelMenu.Controls.Add(labelAccountInformation);
            panelMenu.Controls.Add(labelRegisteredEvent);
            panelMenu.Controls.Add(labelEventList);
            panelMenu.Controls.Add(labelHome);
            panelMenu.Location = new Point(7, 5);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 592);
            panelMenu.TabIndex = 1;
            // 
            // labelLogOut
            // 
            labelLogOut.AutoSize = true;
            labelLogOut.Font = new Font("Segoe UI", 12F);
            labelLogOut.Location = new Point(12, 329);
            labelLogOut.Name = "labelLogOut";
            labelLogOut.Size = new Size(101, 28);
            labelLogOut.TabIndex = 6;
            labelLogOut.Text = "Đăng xuất";
            // 
            // labelClose
            // 
            labelClose.AutoSize = true;
            labelClose.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            labelClose.Location = new Point(199, 3);
            labelClose.Name = "labelClose";
            labelClose.Padding = new Padding(5, 0, 0, 0);
            labelClose.Size = new Size(54, 46);
            labelClose.TabIndex = 0;
            labelClose.Text = "✕";
            // 
            // labelChangePassword
            // 
            labelChangePassword.AutoSize = true;
            labelChangePassword.Font = new Font("Segoe UI", 12F);
            labelChangePassword.Location = new Point(12, 286);
            labelChangePassword.Name = "labelChangePassword";
            labelChangePassword.Size = new Size(129, 28);
            labelChangePassword.TabIndex = 5;
            labelChangePassword.Text = "Đổi mật khẩu";
            // 
            // labelHelp
            // 
            labelHelp.AutoSize = true;
            labelHelp.Font = new Font("Segoe UI", 12F);
            labelHelp.Location = new Point(12, 246);
            labelHelp.Name = "labelHelp";
            labelHelp.Size = new Size(84, 28);
            labelHelp.TabIndex = 4;
            labelHelp.Text = "Trợ giúp";
            // 
            // labelAccountInformation
            // 
            labelAccountInformation.AutoSize = true;
            labelAccountInformation.Font = new Font("Segoe UI", 12F);
            labelAccountInformation.Location = new Point(12, 203);
            labelAccountInformation.Name = "labelAccountInformation";
            labelAccountInformation.Size = new Size(182, 28);
            labelAccountInformation.TabIndex = 3;
            labelAccountInformation.Text = "Thông tin tài khoản";
            // 
            // labelRegisteredEvent
            // 
            labelRegisteredEvent.AutoSize = true;
            labelRegisteredEvent.Font = new Font("Segoe UI", 12F);
            labelRegisteredEvent.Location = new Point(12, 153);
            labelRegisteredEvent.Name = "labelRegisteredEvent";
            labelRegisteredEvent.Size = new Size(178, 28);
            labelRegisteredEvent.TabIndex = 2;
            labelRegisteredEvent.Text = "Sự kiện đã đăng ký";
            // 
            // labelEventList
            // 
            labelEventList.AutoSize = true;
            labelEventList.Font = new Font("Segoe UI", 12F);
            labelEventList.Location = new Point(12, 105);
            labelEventList.Name = "labelEventList";
            labelEventList.Size = new Size(167, 28);
            labelEventList.TabIndex = 1;
            labelEventList.Text = "Danh sách sự kiện";
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 12F);
            labelHome.Location = new Point(12, 59);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(96, 28);
            labelHome.TabIndex = 0;
            labelHome.Text = "Trang chủ";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblMenu);
            panelHeader.Controls.Add(lblFullname);
            panelHeader.Location = new Point(3, 8);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(868, 53);
            panelHeader.TabIndex = 1;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.Transparent;
            lblMenu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(0, -7);
            lblMenu.Margin = new Padding(0);
            lblMenu.Name = "lblMenu";
            lblMenu.Padding = new Padding(5, 0, 0, 5);
            lblMenu.Size = new Size(56, 59);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "≡";
            // 
            // lblFullname
            // 
            lblFullname.Anchor = AnchorStyles.None;
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullname.Location = new Point(374, 11);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(115, 31);
            lblFullname.TabIndex = 1;
            lblFullname.Text = "tài khoản";
            // 
            // ChangePasswordView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 586);
            Controls.Add(panelMain);
            Name = "ChangePasswordView";
            Text = "ChangePasswordView";
            panelMain.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelHome.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlSlideMenu.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelContainer;
        private Panel panelHome;
        private Panel panelContent;
        private Label labelConfirmPasswordE;
        private Label labelNewPassword;
        private Label labelOldPasswordE;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private TextBox txtOldPassword;
        private Label label6;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private Button btnChangePassword;
        private Button btnUserHome;
        private Panel panel2;
        private Label label1;
        private Panel pnlSlideMenu;
        private Panel panelMenu;
        private Label labelLogOut;
        private Label labelClose;
        private Label labelChangePassword;
        private Label labelHelp;
        private Label labelAccountInformation;
        private Label labelRegisteredEvent;
        private Label labelEventList;
        private Label labelHome;
        private Panel panelHeader;
        private Label lblMenu;
        private Label lblFullname;
    }
}