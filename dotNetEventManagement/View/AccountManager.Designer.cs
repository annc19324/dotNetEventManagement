namespace dotNetEventManagement.View
{
    partial class AccountManager
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
            panel1 = new Panel();
            panel4 = new Panel();
            btnLamMoi = new Button();
            dataGridViewUserAccount = new DataGridView();
            label6 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            panel3 = new Panel();
            cmbRole = new ComboBox();
            label5 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            txtNameAccount = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserAccount).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 599);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLamMoi);
            panel4.Controls.Add(dataGridViewUserAccount);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(330, 103);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(610, 496);
            panel4.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(494, 79);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 31);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dataGridViewUserAccount
            // 
            dataGridViewUserAccount.AllowUserToAddRows = false;
            dataGridViewUserAccount.AllowUserToDeleteRows = false;
            dataGridViewUserAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserAccount.Location = new Point(3, 131);
            dataGridViewUserAccount.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUserAccount.Name = "dataGridViewUserAccount";
            dataGridViewUserAccount.ReadOnly = true;
            dataGridViewUserAccount.RowHeadersWidth = 51;
            dataGridViewUserAccount.Size = new Size(598, 361);
            dataGridViewUserAccount.TabIndex = 1;
            dataGridViewUserAccount.CellClick += dataGridViewUserAccount_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(189, 13);
            label6.Name = "label6";
            label6.Size = new Size(248, 37);
            label6.TabIndex = 0;
            label6.Text = "Thông tin tài khoản";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 97);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 28);
            label1.Name = "label1";
            label1.Size = new Size(314, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Tài Khoản";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem5 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(941, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem7, toolStripMenuItem4 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(89, 24);
            toolStripMenuItem1.Text = "Trang Chủ";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(257, 26);
            toolStripMenuItem2.Text = "Quản Lý Sự Kiện";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(257, 26);
            toolStripMenuItem3.Text = "Quản Lý Đơn Hàng";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(257, 26);
            toolStripMenuItem7.Text = "Quản Lý Người Tham Gia";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(257, 26);
            toolStripMenuItem4.Text = "Đăng Xuất";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem6 });
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(67, 24);
            toolStripMenuItem5.Text = "Admin";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(177, 26);
            toolStripMenuItem6.Text = "Trang Admin";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbRole);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtUserName);
            panel3.Controls.Add(txtNameAccount);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(1, 101);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 499);
            panel3.TabIndex = 1;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "admin", "user" });
            cmbRole.Location = new Point(133, 351);
            cmbRole.Margin = new Padding(3, 4, 3, 4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(138, 28);
            cmbRole.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 355);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 9;
            label5.Text = "Role:";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(225, 428);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(120, 428);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(13, 428);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(131, 240);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(179, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(133, 129);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(178, 27);
            txtUserName.TabIndex = 4;
            // 
            // txtNameAccount
            // 
            txtNameAccount.Location = new Point(131, 48);
            txtNameAccount.Margin = new Padding(3, 4, 3, 4);
            txtNameAccount.Name = "txtNameAccount";
            txtNameAccount.Size = new Size(179, 27);
            txtNameAccount.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 244);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 2;
            label4.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 133);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên Người Dùng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 48);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 0;
            label2.Text = "Tài Khoản:";
            // 
            // AccountManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 600);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountManager";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserAccount).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtNameAccount;
        private ComboBox cmbRole;
        private DataGridView dataGridViewUserAccount;
        private Label label6;
        private Button btnLamMoi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
    }
}