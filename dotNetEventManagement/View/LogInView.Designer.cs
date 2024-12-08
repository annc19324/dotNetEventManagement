namespace dotNetEventManagement.View
{
    partial class LogInView
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
            panelLogIn = new Panel();
            leakOrHidePassword = new Label();
            lblForgetPassword = new Label();
            btnSignUp = new Button();
            btnLogIn = new Button();
            lblPasswordE = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblUsernameE = new Label();
            label3 = new Label();
            label2 = new Label();
            panelHeader = new Panel();
            lblHeader = new Label();
            panelMain.SuspendLayout();
            panelContainer.SuspendLayout();
            panelLogIn.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelContainer);
            panelMain.Controls.Add(panelHeader);
            panelMain.Location = new Point(2, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(796, 449);
            panelMain.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panelLogIn);
            panelContainer.Location = new Point(10, 89);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(776, 347);
            panelContainer.TabIndex = 1;
            // 
            // panelLogIn
            // 
            panelLogIn.Controls.Add(leakOrHidePassword);
            panelLogIn.Controls.Add(lblForgetPassword);
            panelLogIn.Controls.Add(btnSignUp);
            panelLogIn.Controls.Add(btnLogIn);
            panelLogIn.Controls.Add(lblPasswordE);
            panelLogIn.Controls.Add(txtPassword);
            panelLogIn.Controls.Add(txtUsername);
            panelLogIn.Controls.Add(lblUsernameE);
            panelLogIn.Controls.Add(label3);
            panelLogIn.Controls.Add(label2);
            panelLogIn.Location = new Point(118, 22);
            panelLogIn.Name = "panelLogIn";
            panelLogIn.Size = new Size(557, 309);
            panelLogIn.TabIndex = 0;
            // 
            // leakOrHidePassword
            // 
            leakOrHidePassword.AutoSize = true;
            leakOrHidePassword.BackColor = Color.White;
            leakOrHidePassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leakOrHidePassword.ForeColor = Color.Black;
            leakOrHidePassword.Location = new Point(468, 116);
            leakOrHidePassword.Name = "leakOrHidePassword";
            leakOrHidePassword.Size = new Size(46, 31);
            leakOrHidePassword.TabIndex = 9;
            leakOrHidePassword.Text = "👁";
            leakOrHidePassword.Click += leakOrHidePassword_Click;
            // 
            // lblForgetPassword
            // 
            lblForgetPassword.AutoSize = true;
            lblForgetPassword.ForeColor = Color.White;
            lblForgetPassword.Location = new Point(401, 238);
            lblForgetPassword.Name = "lblForgetPassword";
            lblForgetPassword.Size = new Size(116, 20);
            lblForgetPassword.TabIndex = 8;
            lblForgetPassword.Text = "Quên mật khẩu?";
            lblForgetPassword.Click += lblForgetPassword_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DeepSkyBlue;
            btnSignUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(307, 177);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(210, 46);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DeepSkyBlue;
            btnLogIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(47, 177);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(208, 46);
            btnLogIn.TabIndex = 6;
            btnLogIn.Text = "Đăng nhập";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblPasswordE
            // 
            lblPasswordE.AutoSize = true;
            lblPasswordE.ForeColor = Color.Gold;
            lblPasswordE.Location = new Point(182, 154);
            lblPasswordE.Name = "lblPasswordE";
            lblPasswordE.Size = new Size(0, 20);
            lblPasswordE.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(182, 113);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(335, 38);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtUsername.Location = new Point(182, 49);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(335, 38);
            txtUsername.TabIndex = 3;
            // 
            // lblUsernameE
            // 
            lblUsernameE.AutoSize = true;
            lblUsernameE.ForeColor = Color.Gold;
            lblUsernameE.Location = new Point(182, 90);
            lblUsernameE.Name = "lblUsernameE";
            lblUsernameE.Size = new Size(0, 20);
            lblUsernameE.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(47, 116);
            label3.Name = "label3";
            label3.Size = new Size(128, 31);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 52);
            label2.Name = "label2";
            label2.Size = new Size(129, 31);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản: ";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Location = new Point(10, 10);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(776, 73);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(261, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(230, 54);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Đăng nhập";
            // 
            // LogInView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            ForeColor = Color.Gold;
            Name = "LogInView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInView";
            Load += LogInView_Load;
            Resize += LogInView_Resize;
            panelMain.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelLogIn.ResumeLayout(false);
            panelLogIn.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelContainer;
        private Panel panelLogIn;
        private Panel panelHeader;
        private Label lblHeader;
        private Label lblForgetPassword;
        private Button btnSignUp;
        private Button btnLogIn;
        private Label lblPasswordE;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblUsernameE;
        private Label label3;
        private Label label2;
        private Label leakOrHidePassword;
    }
}