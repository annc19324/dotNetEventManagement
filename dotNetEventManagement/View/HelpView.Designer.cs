namespace dotNetEventManagement.View
{
    partial class HelpView
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
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            panelHeader = new Panel();
            lblFullname = new Label();
            panelMain.SuspendLayout();
            panelContainer.SuspendLayout();
            panelHome.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.BackColor = Color.Transparent;
            panelMain.Controls.Add(panelContainer);
            panelMain.Controls.Add(panelHeader);
            panelMain.Location = new Point(7, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(871, 562);
            panelMain.TabIndex = 4;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.None;
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Controls.Add(panelHome);
            panelContainer.Location = new Point(5, 67);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(860, 492);
            panelContainer.TabIndex = 2;
            // 
            // panelHome
            // 
            panelHome.Controls.Add(button1);
            panelHome.Controls.Add(linkLabel1);
            panelHome.Controls.Add(label1);
            panelHome.Location = new Point(105, 89);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(661, 322);
            panelHome.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(407, 269);
            button1.Name = "button1";
            button1.Size = new Size(254, 50);
            button1.TabIndex = 3;
            button1.Text = "Trở lại trang chủ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkVisited = true;
            linkLabel1.Location = new Point(3, 46);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 41);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Facebook";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(434, 46);
            label1.TabIndex = 0;
            label1.Text = "Hỗ trợ vui lòng liên hệ qua: ";
            label1.Click += label1_Click;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblFullname);
            panelHeader.Location = new Point(3, 8);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(868, 53);
            panelHeader.TabIndex = 1;
            // 
            // lblFullname
            // 
            lblFullname.Anchor = AnchorStyles.None;
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullname.ForeColor = Color.White;
            lblFullname.Location = new Point(364, 10);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(115, 31);
            lblFullname.TabIndex = 1;
            lblFullname.Text = "tài khoản";
            // 
            // HelpView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(884, 572);
            Controls.Add(panelMain);
            Name = "HelpView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpView";
            panelMain.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelContainer;
        private Panel panelHeader;
        private Label lblFullname;
        private LinkLabel linkLabel1;
        private Label label1;
        private Panel panelHome;
        private Button button1;
    }
}