namespace dotNetEventManagement.View
{
    partial class ForgetPassword
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
            panelChangePassword = new Panel();
            btnChangePassword = new Button();
            btnBack = new Button();
            btnSendCode = new Button();
            txtNewPassword = new TextBox();
            txtEnterCode = new TextBox();
            txtMail = new TextBox();
            txtUsername = new TextBox();
            lblNewPasswordE = new Label();
            lblEnterCodeE = new Label();
            lblMailE = new Label();
            lblUsernameE = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelHeader = new Panel();
            lblHeader = new Label();
            leakOrHide = new Label();
            panelMain.SuspendLayout();
            panelContainer.SuspendLayout();
            panelChangePassword.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelContainer);
            panelMain.Controls.Add(panelHeader);
            panelMain.Location = new Point(0, 1);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(876, 512);
            panelMain.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panelChangePassword);
            panelContainer.Location = new Point(12, 93);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(855, 406);
            panelContainer.TabIndex = 1;
            // 
            // panelChangePassword
            // 
            panelChangePassword.Controls.Add(leakOrHide);
            panelChangePassword.Controls.Add(btnChangePassword);
            panelChangePassword.Controls.Add(btnBack);
            panelChangePassword.Controls.Add(btnSendCode);
            panelChangePassword.Controls.Add(txtNewPassword);
            panelChangePassword.Controls.Add(txtEnterCode);
            panelChangePassword.Controls.Add(txtMail);
            panelChangePassword.Controls.Add(txtUsername);
            panelChangePassword.Controls.Add(lblNewPasswordE);
            panelChangePassword.Controls.Add(lblEnterCodeE);
            panelChangePassword.Controls.Add(lblMailE);
            panelChangePassword.Controls.Add(lblUsernameE);
            panelChangePassword.Controls.Add(label5);
            panelChangePassword.Controls.Add(label4);
            panelChangePassword.Controls.Add(label3);
            panelChangePassword.Controls.Add(label2);
            panelChangePassword.Location = new Point(57, 22);
            panelChangePassword.Name = "panelChangePassword";
            panelChangePassword.Size = new Size(730, 351);
            panelChangePassword.TabIndex = 0;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.DeepSkyBlue;
            btnChangePassword.Font = new Font("Segoe UI", 13.8F);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(443, 298);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(197, 38);
            btnChangePassword.TabIndex = 14;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DeepSkyBlue;
            btnBack.Font = new Font("Segoe UI", 13.8F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(81, 298);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 38);
            btnBack.TabIndex = 13;
            btnBack.Text = "Trở lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSendCode
            // 
            btnSendCode.BackColor = Color.DeepSkyBlue;
            btnSendCode.Font = new Font("Segoe UI", 13.8F);
            btnSendCode.ForeColor = Color.White;
            btnSendCode.Location = new Point(501, 143);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(139, 38);
            btnSendCode.TabIndex = 12;
            btnSendCode.Text = "Gửi mã";
            btnSendCode.UseVisualStyleBackColor = false;
            btnSendCode.Click += btnSendCode_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 13.8F);
            txtNewPassword.Location = new Point(273, 207);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '•';
            txtNewPassword.Size = new Size(367, 38);
            txtNewPassword.TabIndex = 11;
            // 
            // txtEnterCode
            // 
            txtEnterCode.Font = new Font("Segoe UI", 13.8F);
            txtEnterCode.Location = new Point(273, 143);
            txtEnterCode.Name = "txtEnterCode";
            txtEnterCode.Size = new Size(219, 38);
            txtEnterCode.TabIndex = 10;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 13.8F);
            txtMail.Location = new Point(273, 79);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(364, 38);
            txtMail.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.8F);
            txtUsername.Location = new Point(276, 15);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(364, 38);
            txtUsername.TabIndex = 8;
            // 
            // lblNewPasswordE
            // 
            lblNewPasswordE.AutoSize = true;
            lblNewPasswordE.ForeColor = Color.Gold;
            lblNewPasswordE.Location = new Point(276, 248);
            lblNewPasswordE.Name = "lblNewPasswordE";
            lblNewPasswordE.Size = new Size(0, 20);
            lblNewPasswordE.TabIndex = 7;
            // 
            // lblEnterCodeE
            // 
            lblEnterCodeE.AutoSize = true;
            lblEnterCodeE.ForeColor = Color.Gold;
            lblEnterCodeE.Location = new Point(276, 184);
            lblEnterCodeE.Name = "lblEnterCodeE";
            lblEnterCodeE.Size = new Size(0, 20);
            lblEnterCodeE.TabIndex = 6;
            // 
            // lblMailE
            // 
            lblMailE.AutoSize = true;
            lblMailE.ForeColor = Color.Gold;
            lblMailE.Location = new Point(276, 120);
            lblMailE.Name = "lblMailE";
            lblMailE.Size = new Size(0, 20);
            lblMailE.TabIndex = 5;
            // 
            // lblUsernameE
            // 
            lblUsernameE.AutoSize = true;
            lblUsernameE.ForeColor = Color.Gold;
            lblUsernameE.Location = new Point(276, 56);
            lblUsernameE.Name = "lblUsernameE";
            lblUsernameE.Size = new Size(0, 20);
            lblUsernameE.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(81, 207);
            label5.Name = "label5";
            label5.Size = new Size(166, 31);
            label5.TabIndex = 3;
            label5.Text = "mật khẩu mới: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(81, 150);
            label4.Name = "label4";
            label4.Size = new Size(154, 31);
            label4.TabIndex = 2;
            label4.Text = "mã xác nhận: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(81, 82);
            label3.Name = "label3";
            label3.Size = new Size(70, 31);
            label3.TabIndex = 1;
            label3.Text = "Mail: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(81, 18);
            label2.Name = "label2";
            label2.Size = new Size(120, 31);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản: ";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Location = new Point(12, 11);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(855, 76);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(346, 21);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(233, 41);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Quên mật khẩu";
            // 
            // leakOrHide
            // 
            leakOrHide.AutoSize = true;
            leakOrHide.BackColor = Color.White;
            leakOrHide.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leakOrHide.ForeColor = Color.Black;
            leakOrHide.Location = new Point(594, 210);
            leakOrHide.Name = "leakOrHide";
            leakOrHide.Size = new Size(46, 31);
            leakOrHide.TabIndex = 15;
            leakOrHide.Text = "👁";
            leakOrHide.Click += leakOrHide_Click;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(879, 512);
            Controls.Add(panelMain);
            ForeColor = Color.Gold;
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgetPassword";
            Load += ForgetPassword_Load;
            Resize += ForgetPassword_Resize;
            panelMain.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelChangePassword.ResumeLayout(false);
            panelChangePassword.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelContainer;
        private Panel panelChangePassword;
        private Button btnChangePassword;
        private Button btnBack;
        private Button btnSendCode;
        private TextBox txtNewPassword;
        private TextBox txtEnterCode;
        private TextBox txtMail;
        private TextBox txtUsername;
        private Label lblNewPasswordE;
        private Label lblEnterCodeE;
        private Label lblMailE;
        private Label lblUsernameE;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panelHeader;
        private Label lblHeader;
        private Label leakOrHide;
    }
}