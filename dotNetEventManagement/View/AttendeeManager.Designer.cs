namespace dotNetEventManagement.View
{
    partial class AttendeeManager
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            label1 = new Label();
            panel2 = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cmbStatus = new ComboBox();
            txtEventId = new TextBox();
            txtEventName = new TextBox();
            txtUserId = new TextBox();
            txtUserName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dataGridViewAttendee = new DataGridView();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendee).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 101);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem6 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(906, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem7, toolStripMenuItem5 });
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
            toolStripMenuItem3.Text = "Quản Lý Tài Khoản";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(257, 26);
            toolStripMenuItem7.Text = "Quản Lý Người Tham Gia";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(257, 26);
            toolStripMenuItem5.Text = "Đăng Xuât";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4 });
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(67, 24);
            toolStripMenuItem6.Text = "Admin";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(177, 26);
            toolStripMenuItem4.Text = "Trang Admin";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 28);
            label1.Name = "label1";
            label1.Size = new Size(416, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Người Tham gia";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(cmbStatus);
            panel2.Controls.Add(txtEventId);
            panel2.Controls.Add(txtEventName);
            panel2.Controls.Add(txtUserId);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 117);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 265);
            panel2.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(701, 205);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(413, 205);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(137, 205);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Đã Đăng Ký", "Chờ" });
            cmbStatus.Location = new Point(209, 137);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(131, 28);
            cmbStatus.TabIndex = 9;
            // 
            // txtEventId
            // 
            txtEventId.Location = new Point(562, 83);
            txtEventId.Margin = new Padding(3, 4, 3, 4);
            txtEventId.Name = "txtEventId";
            txtEventId.Size = new Size(114, 27);
            txtEventId.TabIndex = 8;
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(562, 25);
            txtEventName.Margin = new Padding(3, 4, 3, 4);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(114, 27);
            txtEventName.TabIndex = 7;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(208, 85);
            txtUserId.Margin = new Padding(3, 4, 3, 4);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(114, 27);
            txtUserId.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(209, 27);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(114, 27);
            txtUserName.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 136);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 4;
            label6.Text = "Trạng Thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 87);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 3;
            label5.Text = "Mã Sự Kiện:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 35);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 2;
            label4.Text = "Tên Sự Kiện:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 79);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã Người Tham Gia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 29);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên Người Tham Gia:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewAttendee);
            panel3.Location = new Point(3, 380);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(909, 273);
            panel3.TabIndex = 2;
            // 
            // dataGridViewAttendee
            // 
            dataGridViewAttendee.AllowUserToAddRows = false;
            dataGridViewAttendee.AllowUserToDeleteRows = false;
            dataGridViewAttendee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendee.Location = new Point(91, 0);
            dataGridViewAttendee.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAttendee.Name = "dataGridViewAttendee";
            dataGridViewAttendee.ReadOnly = true;
            dataGridViewAttendee.RowHeadersWidth = 51;
            dataGridViewAttendee.Size = new Size(735, 269);
            dataGridViewAttendee.TabIndex = 0;
            dataGridViewAttendee.CellClick += dataGridViewAttendee_CellClick;
            // 
            // AttendeeManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 655);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AttendeeManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AttendeeManager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cmbStatus;
        private TextBox txtEventId;
        private TextBox txtEventName;
        private TextBox txtUserId;
        private TextBox txtUserName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private DataGridView dataGridViewAttendee;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}