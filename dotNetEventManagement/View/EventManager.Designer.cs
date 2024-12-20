﻿namespace dotNetEventManagement.View
{
    partial class EventManager
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
            label1 = new Label();
            panel2 = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtGiaVe = new TextBox();
            cmbTrangThai = new ComboBox();
            txtMoTa = new TextBox();
            txtDiaDiem = new TextBox();
            txtTen = new TextBox();
            txtMa = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dateTimeKetThuc = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimeBatDau = new DateTimePicker();
            panel3 = new Panel();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label10 = new Label();
            dataGridViewEvents = new DataGridView();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 34);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Sự Kiện";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtGiaVe);
            panel2.Controls.Add(cmbTrangThai);
            panel2.Controls.Add(txtMoTa);
            panel2.Controls.Add(txtDiaDiem);
            panel2.Controls.Add(txtTen);
            panel2.Controls.Add(txtMa);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dateTimeKetThuc);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateTimeBatDau);
            panel2.Location = new Point(1, 103);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 552);
            panel2.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(256, 509);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(143, 507);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 507);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Location = new Point(143, 441);
            txtGiaVe.Margin = new Padding(3, 4, 3, 4);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(199, 27);
            txtGiaVe.TabIndex = 15;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Items.AddRange(new object[] { "Hoạt Động", "Hết Hạn" });
            cmbTrangThai.Location = new Point(145, 399);
            cmbTrangThai.Margin = new Padding(3, 4, 3, 4);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(197, 28);
            cmbTrangThai.TabIndex = 14;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(143, 321);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(199, 63);
            txtMoTa.TabIndex = 13;
            // 
            // txtDiaDiem
            // 
            txtDiaDiem.Location = new Point(143, 267);
            txtDiaDiem.Margin = new Padding(3, 4, 3, 4);
            txtDiaDiem.Name = "txtDiaDiem";
            txtDiaDiem.Size = new Size(199, 27);
            txtDiaDiem.TabIndex = 12;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(145, 99);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(197, 27);
            txtTen.TabIndex = 11;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(144, 39);
            txtMa.Margin = new Padding(3, 4, 3, 4);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(198, 27);
            txtMa.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 448);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 9;
            label9.Text = "Giá vé:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 399);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 8;
            label8.Text = "Trạng Thái:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 321);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 7;
            label7.Text = "Mô tả:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 274);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 6;
            label6.Text = "Địa Điểm:";
            // 
            // dateTimeKetThuc
            // 
            dateTimeKetThuc.Location = new Point(143, 207);
            dateTimeKetThuc.Margin = new Padding(3, 4, 3, 4);
            dateTimeKetThuc.Name = "dateTimeKetThuc";
            dateTimeKetThuc.Size = new Size(199, 27);
            dateTimeKetThuc.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 212);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 4;
            label5.Text = "Ngày Kết Thúc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 155);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày Bắt Đầu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 99);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhập Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 39);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập Mã:";
            // 
            // dateTimeBatDau
            // 
            dateTimeBatDau.Location = new Point(144, 155);
            dateTimeBatDau.Margin = new Padding(3, 4, 3, 4);
            dateTimeBatDau.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimeBatDau.Name = "dateTimeBatDau";
            dateTimeBatDau.Size = new Size(198, 27);
            dateTimeBatDau.TabIndex = 0;
            dateTimeBatDau.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLamMoi);
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(txtTimKiem);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(dataGridViewEvents);
            panel3.Location = new Point(367, 105);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(744, 549);
            panel3.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnLamMoi.Location = new Point(602, 86);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(138, 40);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnTimKiem.Location = new Point(463, 85);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(133, 42);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtTimKiem.Location = new Point(3, 88);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(454, 38);
            txtTimKiem.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(254, 37);
            label10.Name = "label10";
            label10.Size = new Size(265, 41);
            label10.TabIndex = 1;
            label10.Text = "Thông tin sự kiện";
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.AllowUserToAddRows = false;
            dataGridViewEvents.AllowUserToDeleteRows = false;
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEvents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(3, 135);
            dataGridViewEvents.Margin = new Padding(3, 4, 3, 4);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.ReadOnly = true;
            dataGridViewEvents.RowHeadersWidth = 51;
            dataGridViewEvents.Size = new Size(737, 401);
            dataGridViewEvents.TabIndex = 0;
            dataGridViewEvents.CellClick += dataGridViewEvents_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem6 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1110, 30);
            menuStrip1.TabIndex = 3;
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
            toolStripMenuItem2.Text = "Quản Lý Hóa Đơn";
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
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // EventManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 656);
            Controls.Add(menuStrip1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EventManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventManager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DateTimePicker dateTimeBatDau;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimeKetThuc;
        private Label label5;
        private Label label9;
        private Label label8;
        private ComboBox cmbTrangThai;
        private TextBox txtMoTa;
        private TextBox txtDiaDiem;
        private TextBox txtTen;
        private TextBox txtMa;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtGiaVe;
        private Panel panel3;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label10;
        private DataGridView dataGridViewEvents;
        private Button btnLamMoi;
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