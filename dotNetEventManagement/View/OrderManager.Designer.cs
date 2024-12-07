namespace dotNetEventManagement.View
{
    partial class OrderManager
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
            btnThem = new Button();
            cmbStatus = new ComboBox();
            dateTimeOrder = new DateTimePicker();
            txtPrice = new TextBox();
            txtEventName = new TextBox();
            txtEventId = new TextBox();
            txtFullName = new TextBox();
            txtUserId = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnThanhToan = new Button();
            btnCapNhat = new Button();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            label9 = new Label();
            txtTimKiem = new TextBox();
            dataGridViewOrderManager = new DataGridView();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderManager).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 55);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem6 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(846, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem7, toolStripMenuItem5 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(74, 20);
            toolStripMenuItem1.Text = "Trang Chủ";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(207, 22);
            toolStripMenuItem2.Text = "Quản Lý Sự Kiện";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(207, 22);
            toolStripMenuItem3.Text = "Quản Lý Tài Khoản";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(207, 22);
            toolStripMenuItem7.Text = "Quản Lý Người Tham Gia";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(207, 22);
            toolStripMenuItem5.Text = "Đăng Xuât";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4 });
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(55, 20);
            toolStripMenuItem6.Text = "Admin";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(143, 22);
            toolStripMenuItem4.Text = "Trang Admin";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 18);
            label1.Name = "label1";
            label1.Size = new Size(255, 37);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Đơn Hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(cmbStatus);
            panel2.Controls.Add(dateTimeOrder);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtEventName);
            panel2.Controls.Add(txtEventId);
            panel2.Controls.Add(txtFullName);
            panel2.Controls.Add(txtUserId);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(8, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 373);
            panel2.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(177, 332);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 332);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Sẵn Sàng", "Chờ" });
            cmbStatus.Location = new Point(114, 198);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 13;
            // 
            // dateTimeOrder
            // 
            dateTimeOrder.Location = new Point(114, 160);
            dateTimeOrder.Name = "dateTimeOrder";
            dateTimeOrder.Size = new Size(166, 23);
            dateTimeOrder.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(114, 239);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 11;
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(126, 119);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(100, 23);
            txtEventName.TabIndex = 10;
            // 
            // txtEventId
            // 
            txtEventId.Location = new Point(126, 90);
            txtEventId.Name = "txtEventId";
            txtEventId.Size = new Size(100, 23);
            txtEventId.TabIndex = 9;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(126, 57);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(126, 23);
            txtFullName.TabIndex = 8;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(127, 21);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(124, 23);
            txtUserId.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 239);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 6;
            label8.Text = "Giá :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 198);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 5;
            label7.Text = "Trạng Thái:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 166);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 4;
            label6.Text = "Ngày Thanh Toán:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 127);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 3;
            label5.Text = "Tên Sự Kiện:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 96);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 2;
            label4.Text = "Mã Sự Kiện:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 65);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên Người Tham Gia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 24);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã Người Tham Gia:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnThanhToan);
            panel3.Controls.Add(btnCapNhat);
            panel3.Controls.Add(btnLamMoi);
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtTimKiem);
            panel3.Controls.Add(dataGridViewOrderManager);
            panel3.Location = new Point(297, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(552, 370);
            panel3.TabIndex = 2;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(115, 334);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(83, 23);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(13, 334);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(474, 49);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(393, 49);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(209, 15);
            label9.Name = "label9";
            label9.Size = new Size(161, 21);
            label9.TabIndex = 2;
            label9.Text = "Thông tin đơn hàng";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(210, 49);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(160, 23);
            txtTimKiem.TabIndex = 1;
            // 
            // dataGridViewOrderManager
            // 
            dataGridViewOrderManager.AllowUserToAddRows = false;
            dataGridViewOrderManager.AllowUserToDeleteRows = false;
            dataGridViewOrderManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderManager.Location = new Point(3, 87);
            dataGridViewOrderManager.Name = "dataGridViewOrderManager";
            dataGridViewOrderManager.ReadOnly = true;
            dataGridViewOrderManager.Size = new Size(546, 241);
            dataGridViewOrderManager.TabIndex = 0;
            dataGridViewOrderManager.CellClick += dataGridViewOrderManager_CellClick;
            // 
            // OrderManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrderManager";
            Text = "OrderManager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderManager).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtEventId;
        private TextBox txtFullName;
        private TextBox txtUserId;
        private ComboBox cmbStatus;
        private DateTimePicker dateTimeOrder;
        private TextBox txtPrice;
        private TextBox txtEventName;
        private Button btnThem;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private Label label9;
        private TextBox txtTimKiem;
        private DataGridView dataGridViewOrderManager;
        private Button btnThanhToan;
        private Button btnCapNhat;
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