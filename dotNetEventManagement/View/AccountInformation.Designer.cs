namespace dotNetEventManagement.View
{
    partial class AccountInformation
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
            dtpDateOfBirth = new DateTimePicker();
            labelPhoneE = new Label();
            labelMailE = new Label();
            labelDateOfBirthE = new Label();
            labelFullnameE = new Label();
            labelUsernameE = new Label();
            txtPhone = new TextBox();
            txtMail = new TextBox();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            btnSave = new Button();
            btnEdit = new Button();
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
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            panelMain.Location = new Point(12, 50);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(874, 572);
            panelMain.TabIndex = 2;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.None;
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Controls.Add(panelHome);
            panelContainer.Location = new Point(3, 67);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(868, 433);
            panelContainer.TabIndex = 2;
            panelContainer.Click += panelContainer_Click;
            // 
            // panelHome
            // 
            panelHome.Anchor = AnchorStyles.None;
            panelHome.BackColor = Color.Transparent;
            panelHome.Controls.Add(panelContent);
            panelHome.Location = new Point(7, 13);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(858, 410);
            panelHome.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.None;
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(dtpDateOfBirth);
            panelContent.Controls.Add(labelPhoneE);
            panelContent.Controls.Add(labelMailE);
            panelContent.Controls.Add(labelDateOfBirthE);
            panelContent.Controls.Add(labelFullnameE);
            panelContent.Controls.Add(labelUsernameE);
            panelContent.Controls.Add(txtPhone);
            panelContent.Controls.Add(txtMail);
            panelContent.Controls.Add(txtFullname);
            panelContent.Controls.Add(txtUsername);
            panelContent.Controls.Add(label6);
            panelContent.Controls.Add(label5);
            panelContent.Controls.Add(label4);
            panelContent.Controls.Add(label3);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(panel1);
            panelContent.Location = new Point(39, -6);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(783, 423);
            panelContent.TabIndex = 0;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Location = new Point(238, 234);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(539, 34);
            dtpDateOfBirth.TabIndex = 16;
            // 
            // labelPhoneE
            // 
            labelPhoneE.AutoSize = true;
            labelPhoneE.ForeColor = Color.Red;
            labelPhoneE.Location = new Point(238, 390);
            labelPhoneE.Name = "labelPhoneE";
            labelPhoneE.Size = new Size(0, 20);
            labelPhoneE.TabIndex = 15;
            // 
            // labelMailE
            // 
            labelMailE.AutoSize = true;
            labelMailE.ForeColor = Color.Red;
            labelMailE.Location = new Point(238, 330);
            labelMailE.Name = "labelMailE";
            labelMailE.Size = new Size(0, 20);
            labelMailE.TabIndex = 14;
            // 
            // labelDateOfBirthE
            // 
            labelDateOfBirthE.AutoSize = true;
            labelDateOfBirthE.ForeColor = Color.Red;
            labelDateOfBirthE.Location = new Point(238, 269);
            labelDateOfBirthE.Name = "labelDateOfBirthE";
            labelDateOfBirthE.Size = new Size(0, 20);
            labelDateOfBirthE.TabIndex = 13;
            // 
            // labelFullnameE
            // 
            labelFullnameE.AutoSize = true;
            labelFullnameE.ForeColor = Color.Red;
            labelFullnameE.Location = new Point(238, 209);
            labelFullnameE.Name = "labelFullnameE";
            labelFullnameE.Size = new Size(0, 20);
            labelFullnameE.TabIndex = 12;
            // 
            // labelUsernameE
            // 
            labelUsernameE.AutoSize = true;
            labelUsernameE.ForeColor = Color.Red;
            labelUsernameE.Location = new Point(238, 149);
            labelUsernameE.Name = "labelUsernameE";
            labelUsernameE.Size = new Size(0, 20);
            labelUsernameE.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPhone.Location = new Point(238, 353);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(539, 34);
            txtPhone.TabIndex = 10;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtMail.Location = new Point(238, 292);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(539, 34);
            txtMail.TabIndex = 9;
            // 
            // txtFullname
            // 
            txtFullname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtFullname.Location = new Point(238, 172);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(539, 34);
            txtFullname.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtUsername.Location = new Point(238, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(539, 34);
            txtUsername.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(39, 356);
            label6.Name = "label6";
            label6.Size = new Size(149, 28);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 295);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 4;
            label5.Text = "Mail: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 239);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 175);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 2;
            label3.Text = "Họ tên: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 113);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên người dùng: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 97);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnEdit);
            panel3.Location = new Point(512, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 47);
            panel3.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DeepSkyBlue;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(143, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 41);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DeepSkyBlue;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(3, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(134, 41);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Chỉnh sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(503, 89);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 24);
            label1.Name = "label1";
            label1.Size = new Size(362, 54);
            label1.TabIndex = 0;
            label1.Text = "Thông tin cá nhân";
            // 
            // pnlSlideMenu
            // 
            pnlSlideMenu.Controls.Add(panelMenu);
            pnlSlideMenu.Location = new Point(0, 0);
            pnlSlideMenu.Name = "pnlSlideMenu";
            pnlSlideMenu.Size = new Size(0, 520);
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
            panelMenu.Size = new Size(268, 592);
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
            labelLogOut.Click += labelLogOut_Click;
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
            labelClose.Click += labelClose_Click;
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
            labelChangePassword.Click += labelChangePassword_Click;
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
            labelHelp.Click += labelHelp_Click;
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
            labelAccountInformation.Click += labelAccountInformation_Click;
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
            labelRegisteredEvent.Click += labelRegisteredEvent_Click;
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
            labelEventList.Click += labelEventList_Click;
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
            labelHome.Click += labelHome_Click;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblMenu);
            panelHeader.Controls.Add(lblFullname);
            panelHeader.Location = new Point(3, -1);
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
            lblMenu.Click += lblMenu_Click;
            // 
            // lblFullname
            // 
            lblFullname.Anchor = AnchorStyles.None;
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullname.ForeColor = Color.White;
            lblFullname.Location = new Point(582, 12);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(0, 31);
            lblFullname.TabIndex = 1;
            // 
            // AccountInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(898, 634);
            Controls.Add(panelMain);
            Name = "AccountInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountInformation";
            Load += AccountInformation_Load;
            Resize += AccountInformation_Resize;
            panelMain.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelHome.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel3;
        private Button btnSave;
        private Button btnEdit;
        private Panel panel2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label labelPhoneE;
        private Label labelMailE;
        private Label labelDateOfBirthE;
        private Label labelFullnameE;
        private Label labelUsernameE;
        private TextBox txtPhone;
        private TextBox txtMail;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private DateTimePicker dtpDateOfBirth;
    }
}