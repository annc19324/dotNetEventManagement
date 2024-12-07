namespace dotNetEventManagement.View
{
    partial class UserHome
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
            panelContainer = new Panel();
            panelHome = new Panel();
            panelNavigation = new Panel();
            btnLogOut = new Button();
            btnInformation = new Button();
            btnRegisteredEvent = new Button();
            btnEventList = new Button();
            panelHeader = new Panel();
            lblMenu = new Label();
            lblFullname = new Label();
            panelMain.SuspendLayout();
            pnlSlideMenu.SuspendLayout();
            panelMenu.SuspendLayout();
            panelContainer.SuspendLayout();
            panelHome.SuspendLayout();
            panelNavigation.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.BackColor = Color.Transparent;
            panelMain.Controls.Add(pnlSlideMenu);
            panelMain.Controls.Add(panelContainer);
            panelMain.Controls.Add(panelHeader);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 450);
            panelMain.TabIndex = 0;
            // 
            // pnlSlideMenu
            // 
            pnlSlideMenu.Controls.Add(panelMenu);
            pnlSlideMenu.Location = new Point(-2, 0);
            pnlSlideMenu.Name = "pnlSlideMenu";
            pnlSlideMenu.Size = new Size(0, 450);
            pnlSlideMenu.TabIndex = 2;
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
            panelMenu.Size = new Size(250, 442);
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
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.None;
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Controls.Add(panelHome);
            panelContainer.Location = new Point(0, 69);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 381);
            panelContainer.TabIndex = 2;
            panelContainer.Click += panelContainer_Click;
            // 
            // panelHome
            // 
            panelHome.Anchor = AnchorStyles.None;
            panelHome.BackColor = Color.Transparent;
            panelHome.Controls.Add(panelNavigation);
            panelHome.Location = new Point(0, 0);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(800, 381);
            panelHome.TabIndex = 0;
            // 
            // panelNavigation
            // 
            panelNavigation.Anchor = AnchorStyles.None;
            panelNavigation.BackColor = Color.Transparent;
            panelNavigation.Controls.Add(btnLogOut);
            panelNavigation.Controls.Add(btnInformation);
            panelNavigation.Controls.Add(btnRegisteredEvent);
            panelNavigation.Controls.Add(btnEventList);
            panelNavigation.Location = new Point(148, 32);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(499, 285);
            panelNavigation.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.DeepSkyBlue;
            btnLogOut.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(56, 211);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(384, 41);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Đăng xuất";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnInformation
            // 
            btnInformation.BackColor = Color.DeepSkyBlue;
            btnInformation.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnInformation.ForeColor = Color.White;
            btnInformation.Location = new Point(56, 153);
            btnInformation.Name = "btnInformation";
            btnInformation.Size = new Size(384, 41);
            btnInformation.TabIndex = 2;
            btnInformation.Text = "Thông tin tài khoản";
            btnInformation.UseVisualStyleBackColor = false;
            btnInformation.Click += btnInformation_Click;
            // 
            // btnRegisteredEvent
            // 
            btnRegisteredEvent.BackColor = Color.DeepSkyBlue;
            btnRegisteredEvent.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnRegisteredEvent.ForeColor = Color.White;
            btnRegisteredEvent.Location = new Point(56, 95);
            btnRegisteredEvent.Name = "btnRegisteredEvent";
            btnRegisteredEvent.Size = new Size(384, 41);
            btnRegisteredEvent.TabIndex = 1;
            btnRegisteredEvent.Text = "Sự kiện đã đăng ký";
            btnRegisteredEvent.UseVisualStyleBackColor = false;
            btnRegisteredEvent.Click += btnRegisteredEvent_Click;
            // 
            // btnEventList
            // 
            btnEventList.BackColor = Color.DeepSkyBlue;
            btnEventList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEventList.ForeColor = Color.White;
            btnEventList.Location = new Point(56, 37);
            btnEventList.Name = "btnEventList";
            btnEventList.Size = new Size(384, 41);
            btnEventList.TabIndex = 0;
            btnEventList.Text = "Đăng ký sự kiện mới";
            btnEventList.UseVisualStyleBackColor = false;
            btnEventList.Click += btnEventList_Click;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblMenu);
            panelHeader.Controls.Add(lblFullname);
            panelHeader.Location = new Point(3, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(793, 52);
            panelHeader.TabIndex = 0;
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
            lblMenu.Click += label1_Click;
            // 
            // lblFullname
            // 
            lblFullname.Anchor = AnchorStyles.None;
            lblFullname.AutoSize = true;
            lblFullname.BackColor = Color.Transparent;
            lblFullname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullname.ForeColor = Color.White;
            lblFullname.Location = new Point(89, 11);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(0, 31);
            lblFullname.TabIndex = 1;
            // 
            // UserHome
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            ForeColor = Color.Black;
            Name = "UserHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserHome";
            Load += UserHome_Load;
            Resize += UserHome_Resize;
            panelMain.ResumeLayout(false);
            pnlSlideMenu.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelHome.ResumeLayout(false);
            panelNavigation.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelHeader;
        private Label lblFullname;
        private Label lblMenu;
        private Panel panelContainer;
        private Panel panelHome;
        private Panel panelNavigation;
        private Button btnLogOut;
        private Button btnInformation;
        private Button btnRegisteredEvent;
        private Button btnEventList;
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
    }
}