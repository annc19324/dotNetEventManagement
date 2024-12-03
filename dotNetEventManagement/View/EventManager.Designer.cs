namespace dotNetEventManagement.View
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 17);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
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
            panel2.Location = new Point(1, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 414);
            panel2.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(235, 381);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(125, 380);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(17, 380);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Location = new Point(125, 331);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(100, 23);
            txtGiaVe.TabIndex = 15;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Items.AddRange(new object[] { "Hoạt Động", "Hết Hạn" });
            cmbTrangThai.Location = new Point(127, 299);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(121, 23);
            cmbTrangThai.TabIndex = 14;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(125, 241);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(162, 48);
            txtMoTa.TabIndex = 13;
            // 
            // txtDiaDiem
            // 
            txtDiaDiem.Location = new Point(125, 200);
            txtDiaDiem.Name = "txtDiaDiem";
            txtDiaDiem.Size = new Size(100, 23);
            txtDiaDiem.TabIndex = 12;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(121, 71);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(100, 23);
            txtTen.TabIndex = 11;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(120, 31);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(118, 23);
            txtMa.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 331);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 9;
            label9.Text = "Giá vé:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 299);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 8;
            label8.Text = "Trạng Thái:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 241);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 7;
            label7.Text = "Mô tả:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 208);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 6;
            label6.Text = "Địa Điểm:";
            // 
            // dateTimeKetThuc
            // 
            dateTimeKetThuc.Location = new Point(125, 155);
            dateTimeKetThuc.Name = "dateTimeKetThuc";
            dateTimeKetThuc.Size = new Size(175, 23);
            dateTimeKetThuc.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 155);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày Kết Thúc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 116);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Ngày Bắt Đầu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 74);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Nhập Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 29);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập Mã:";
            // 
            // dateTimeBatDau
            // 
            dateTimeBatDau.Location = new Point(126, 116);
            dateTimeBatDau.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimeBatDau.Name = "dateTimeBatDau";
            dateTimeBatDau.Size = new Size(174, 23);
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
            panel3.Location = new Point(321, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(651, 412);
            panel3.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(553, 53);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(440, 53);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(239, 53);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(183, 23);
            txtTimKiem.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(235, 16);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 1;
            label10.Text = "Thông tin sự kiện";
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.AllowUserToAddRows = false;
            dataGridViewEvents.AllowUserToDeleteRows = false;
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(3, 130);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.ReadOnly = true;
            dataGridViewEvents.Size = new Size(645, 260);
            dataGridViewEvents.TabIndex = 0;
            dataGridViewEvents.CellClick += dataGridViewEvents_CellClick;
            // 
            // EventManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 492);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EventManager";
            Text = "EventManager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ResumeLayout(false);
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
    }
}