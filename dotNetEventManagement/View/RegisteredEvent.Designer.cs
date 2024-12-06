namespace dotNetEventManagement.View
{
    partial class RegisteredEvent
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
            panel2 = new Panel();
            panel4 = new Panel();
            dgvRegisteredEventList = new DataGridView();
            btnUserHome = new Button();
            btnShowBill = new Button();
            btnCancelEvent = new Button();
            panel5 = new Panel();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel3 = new Panel();
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
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredEventList).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
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
            panelMain.Location = new Point(12, 12);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1238, 668);
            panelMain.TabIndex = 2;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.None;
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Controls.Add(panelHome);
            panelContainer.Location = new Point(0, 64);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1238, 575);
            panelContainer.TabIndex = 2;
            panelContainer.Click += panelContainer_Click;
            // 
            // panelHome
            // 
            panelHome.Anchor = AnchorStyles.None;
            panelHome.BackColor = Color.Transparent;
            panelHome.Controls.Add(panelContent);
            panelHome.Location = new Point(7, 6);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1219, 551);
            panelHome.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.None;
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(panel2);
            panelContent.Location = new Point(9, 5);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1188, 528);
            panelContent.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(25, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1138, 523);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvRegisteredEventList);
            panel4.Controls.Add(btnUserHome);
            panel4.Controls.Add(btnShowBill);
            panel4.Controls.Add(btnCancelEvent);
            panel4.Location = new Point(6, 129);
            panel4.Name = "panel4";
            panel4.Size = new Size(1129, 380);
            panel4.TabIndex = 2;
            // 
            // dgvRegisteredEventList
            // 
            dgvRegisteredEventList.AllowUserToAddRows = false;
            dgvRegisteredEventList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegisteredEventList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegisteredEventList.Location = new Point(3, 19);
            dgvRegisteredEventList.MultiSelect = false;
            dgvRegisteredEventList.Name = "dgvRegisteredEventList";
            dgvRegisteredEventList.ReadOnly = true;
            dgvRegisteredEventList.RowHeadersWidth = 51;
            dgvRegisteredEventList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegisteredEventList.Size = new Size(1123, 286);
            dgvRegisteredEventList.TabIndex = 0;
            // 
            // btnUserHome
            // 
            btnUserHome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserHome.Location = new Point(325, 311);
            btnUserHome.Name = "btnUserHome";
            btnUserHome.Size = new Size(249, 47);
            btnUserHome.TabIndex = 5;
            btnUserHome.Text = "Trang chủ";
            btnUserHome.UseVisualStyleBackColor = true;
            btnUserHome.Click += btnUserHome_Click;
            // 
            // btnShowBill
            // 
            btnShowBill.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowBill.Location = new Point(865, 311);
            btnShowBill.Name = "btnShowBill";
            btnShowBill.Size = new Size(244, 47);
            btnShowBill.TabIndex = 2;
            btnShowBill.Text = "Thanh toán hóa đơn";
            btnShowBill.UseVisualStyleBackColor = true;
            btnShowBill.Click += btnShowBill_Click;
            // 
            // btnCancelEvent
            // 
            btnCancelEvent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelEvent.Location = new Point(580, 311);
            btnCancelEvent.Name = "btnCancelEvent";
            btnCancelEvent.Size = new Size(279, 47);
            btnCancelEvent.TabIndex = 4;
            btnCancelEvent.Text = "Hủy sự kiện";
            btnCancelEvent.UseVisualStyleBackColor = true;
            btnCancelEvent.Click += btnCancelEvent_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRefresh);
            panel5.Controls.Add(btnSearch);
            panel5.Controls.Add(txtSearch);
            panel5.Location = new Point(3, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(1132, 53);
            panel5.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(1061, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(72, 46);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "⟳";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(868, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(187, 47);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(859, 43);
            txtSearch.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1132, 49);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(418, 8);
            label1.Name = "label1";
            label1.Size = new Size(287, 41);
            label1.TabIndex = 0;
            label1.Text = "Sự kiện đã đăng ký";
            // 
            // pnlSlideMenu
            // 
            pnlSlideMenu.Controls.Add(panelMenu);
            pnlSlideMenu.Location = new Point(0, 0);
            pnlSlideMenu.Name = "pnlSlideMenu";
            pnlSlideMenu.Size = new Size(0, 594);
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
            panelMenu.Size = new Size(261, 592);
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
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1238, 52);
            panelHeader.TabIndex = 3;
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
            lblFullname.Location = new Point(1019, 11);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(0, 31);
            lblFullname.TabIndex = 1;
            // 
            // RegisteredEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 692);
            Controls.Add(panelMain);
            Name = "RegisteredEvent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisteredEvent";
            Load += RegisteredEvent_Load;
            Shown += RegisteredEvent_Shown;
            Click += RegisteredEvent_Click;
            Resize += RegisteredEvent_Resize;
            panelMain.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelHome.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegisteredEventList).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel2;
        private Panel panel5;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel4;
        private Button btnShowBill;
        private Button btnCancelEvent;
        private DataGridView dgvRegisteredEventList;
        private Panel panel3;
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
        private Button btnUserHome;
    }
}