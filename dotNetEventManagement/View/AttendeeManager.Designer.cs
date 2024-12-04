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
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendee).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 76);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 21);
            label1.Name = "label1";
            label1.Size = new Size(333, 37);
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
            panel2.Location = new Point(3, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 199);
            panel2.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(613, 154);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(361, 154);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(120, 154);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Đã Đăng Ký", "Chờ" });
            cmbStatus.Location = new Point(183, 103);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(115, 23);
            cmbStatus.TabIndex = 9;
            // 
            // txtEventId
            // 
            txtEventId.Location = new Point(492, 62);
            txtEventId.Name = "txtEventId";
            txtEventId.Size = new Size(100, 23);
            txtEventId.TabIndex = 8;
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(492, 19);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(100, 23);
            txtEventName.TabIndex = 7;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(182, 64);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(100, 23);
            txtUserId.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(183, 20);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 102);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 4;
            label6.Text = "Trạng Thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 65);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 3;
            label5.Text = "Mã Sự Kiện:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 26);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 2;
            label4.Text = "Tên Sự Kiện:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 59);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 1;
            label3.Text = "Mã Người Tham Gia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 22);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên Người Tham Gia:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewAttendee);
            panel3.Location = new Point(3, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(795, 205);
            panel3.TabIndex = 2;
            // 
            // dataGridViewAttendee
            // 
            dataGridViewAttendee.AllowUserToAddRows = false;
            dataGridViewAttendee.AllowUserToDeleteRows = false;
            dataGridViewAttendee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendee.Location = new Point(80, 0);
            dataGridViewAttendee.Name = "dataGridViewAttendee";
            dataGridViewAttendee.ReadOnly = true;
            dataGridViewAttendee.Size = new Size(643, 202);
            dataGridViewAttendee.TabIndex = 0;
            dataGridViewAttendee.CellClick += dataGridViewAttendee_CellClick;
            // 
            // AttendeeManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AttendeeManager";
            Text = "AttendeeManager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}