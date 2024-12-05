namespace dotNetEventManagement.View
{
    partial class PayBillView
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
            label14 = new Label();
            panel3 = new Panel();
            btnPayLater = new Button();
            btnPayNow = new Button();
            panel2 = new Panel();
            labelPrice = new Label();
            labelOrderDate = new Label();
            labelEventName = new Label();
            labelEventId = new Label();
            labelFullname = new Label();
            labelUserId = new Label();
            labelOrderId = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label_Id = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 431);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label14);
            panel4.Location = new Point(6, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(618, 42);
            panel4.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(237, 1);
            label14.Name = "label14";
            label14.Size = new Size(133, 41);
            label14.TabIndex = 0;
            label14.Text = "Hóa đơn";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPayLater);
            panel3.Controls.Add(btnPayNow);
            panel3.Location = new Point(3, 377);
            panel3.Name = "panel3";
            panel3.Size = new Size(621, 47);
            panel3.TabIndex = 1;
            // 
            // btnPayLater
            // 
            btnPayLater.Font = new Font("Segoe UI", 13.8F);
            btnPayLater.Location = new Point(3, 3);
            btnPayLater.Name = "btnPayLater";
            btnPayLater.Size = new Size(214, 42);
            btnPayLater.TabIndex = 1;
            btnPayLater.Text = "thanh toán sau";
            btnPayLater.UseVisualStyleBackColor = true;
            btnPayLater.Click += btnPayLater_Click;
            // 
            // btnPayNow
            // 
            btnPayNow.Font = new Font("Segoe UI", 13.8F);
            btnPayNow.Location = new Point(372, 3);
            btnPayNow.Name = "btnPayNow";
            btnPayNow.Size = new Size(246, 42);
            btnPayNow.TabIndex = 0;
            btnPayNow.Text = "thanh toán ngay";
            btnPayNow.UseVisualStyleBackColor = true;
            btnPayNow.Click += btnPayNow_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelPrice);
            panel2.Controls.Add(labelOrderDate);
            panel2.Controls.Add(labelEventName);
            panel2.Controls.Add(labelEventId);
            panel2.Controls.Add(labelFullname);
            panel2.Controls.Add(labelUserId);
            panel2.Controls.Add(labelOrderId);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label_Id);
            panel2.Location = new Point(3, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 320);
            panel2.TabIndex = 0;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 13.8F);
            labelPrice.Location = new Point(224, 277);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(0, 31);
            labelPrice.TabIndex = 13;
            // 
            // labelOrderDate
            // 
            labelOrderDate.AutoSize = true;
            labelOrderDate.Font = new Font("Segoe UI", 13.8F);
            labelOrderDate.Location = new Point(224, 236);
            labelOrderDate.Name = "labelOrderDate";
            labelOrderDate.Size = new Size(0, 31);
            labelOrderDate.TabIndex = 12;
            // 
            // labelEventName
            // 
            labelEventName.AutoSize = true;
            labelEventName.Font = new Font("Segoe UI", 13.8F);
            labelEventName.Location = new Point(224, 187);
            labelEventName.Name = "labelEventName";
            labelEventName.Size = new Size(0, 31);
            labelEventName.TabIndex = 11;
            // 
            // labelEventId
            // 
            labelEventId.AutoSize = true;
            labelEventId.Font = new Font("Segoe UI", 13.8F);
            labelEventId.Location = new Point(224, 144);
            labelEventId.Name = "labelEventId";
            labelEventId.Size = new Size(0, 31);
            labelEventId.TabIndex = 10;
            // 
            // labelFullname
            // 
            labelFullname.AutoSize = true;
            labelFullname.Font = new Font("Segoe UI", 13.8F);
            labelFullname.Location = new Point(224, 100);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(0, 31);
            labelFullname.TabIndex = 9;
            // 
            // labelUserId
            // 
            labelUserId.AutoSize = true;
            labelUserId.Font = new Font("Segoe UI", 13.8F);
            labelUserId.Location = new Point(224, 54);
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new Size(0, 31);
            labelUserId.TabIndex = 8;
            // 
            // labelOrderId
            // 
            labelOrderId.AutoSize = true;
            labelOrderId.Font = new Font("Segoe UI", 13.8F);
            labelOrderId.Location = new Point(224, 12);
            labelOrderId.Name = "labelOrderId";
            labelOrderId.Size = new Size(0, 31);
            labelOrderId.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(25, 280);
            label7.Name = "label7";
            label7.Size = new Size(88, 31);
            label7.TabIndex = 6;
            label7.Text = "Giá vé: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(25, 239);
            label6.Name = "label6";
            label6.Size = new Size(166, 31);
            label6.TabIndex = 5;
            label6.Text = "Ngày đăng ký: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(25, 190);
            label5.Name = "label5";
            label5.Size = new Size(138, 31);
            label5.TabIndex = 4;
            label5.Text = "Tên sự kiện: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(25, 147);
            label4.Name = "label4";
            label4.Size = new Size(136, 31);
            label4.TabIndex = 3;
            label4.Text = "Mã sự kiện: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(25, 103);
            label3.Name = "label3";
            label3.Size = new Size(99, 31);
            label3.TabIndex = 2;
            label3.Text = "Họ tên : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(25, 57);
            label2.Name = "label2";
            label2.Size = new Size(172, 31);
            label2.TabIndex = 1;
            label2.Text = "Id người dùng: ";
            // 
            // label_Id
            // 
            label_Id.AutoSize = true;
            label_Id.Font = new Font("Segoe UI", 13.8F);
            label_Id.Location = new Point(25, 15);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(149, 31);
            label_Id.TabIndex = 0;
            label_Id.Text = "Mã hóa đơn: ";
            // 
            // PayBillView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 455);
            Controls.Add(panel1);
            Name = "PayBillView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayBillView";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnPayLater;
        private Button btnPayNow;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label_Id;
        private Label label7;
        private Label label6;
        private Label labelPrice;
        private Label labelOrderDate;
        private Label labelEventName;
        private Label labelEventId;
        private Label labelFullname;
        private Label labelUserId;
        private Label labelOrderId;
        private Panel panel4;
        private Label label14;
    }
}