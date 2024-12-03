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
            label2 = new Label();
            panelContainer = new Panel();
            panelHome = new Panel();
            panelNavigation = new Panel();
            btnLogOut = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelHeader = new Panel();
            lblMenu = new Label();
            lblFullname = new Label();
            panelMain.SuspendLayout();
            pnlSlideMenu.SuspendLayout();
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
            pnlSlideMenu.Controls.Add(label2);
            pnlSlideMenu.Location = new Point(0, 0);
            pnlSlideMenu.Name = "pnlSlideMenu";
            pnlSlideMenu.Size = new Size(0, 450);
            pnlSlideMenu.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label2.Location = new Point(141, 6);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 0, 0, 0);
            label2.Size = new Size(54, 46);
            label2.TabIndex = 0;
            label2.Text = "✕";
            label2.Click += label2_Click;
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
            panelNavigation.BackColor = Color.WhiteSmoke;
            panelNavigation.Controls.Add(btnLogOut);
            panelNavigation.Controls.Add(button3);
            panelNavigation.Controls.Add(button2);
            panelNavigation.Controls.Add(button1);
            panelNavigation.Location = new Point(150, 52);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(499, 285);
            panelNavigation.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 13.8F);
            btnLogOut.Location = new Point(56, 211);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(384, 41);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Đăng xuất";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F);
            button3.Location = new Point(56, 153);
            button3.Name = "button3";
            button3.Size = new Size(384, 41);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.Location = new Point(56, 95);
            button2.Name = "button2";
            button2.Size = new Size(384, 41);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.Location = new Point(56, 37);
            button1.Name = "button1";
            button1.Size = new Size(384, 41);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblMenu);
            panelHeader.Controls.Add(lblFullname);
            panelHeader.Location = new Point(3, 10);
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
            lblFullname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullname.Location = new Point(564, 15);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(0, 31);
            lblFullname.TabIndex = 1;
            // 
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Name = "UserHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserHome";
            Load += UserHome_Load;
            Resize += UserHome_Resize;
            panelMain.ResumeLayout(false);
            pnlSlideMenu.ResumeLayout(false);
            pnlSlideMenu.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelHome.ResumeLayout(false);
            panelNavigation.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel pnlSlideMenu;
        private Panel panelHeader;
        private Label lblFullname;
        private Label lblMenu;
        private Label label2;
        private Panel panelContainer;
        private Panel panelHome;
        private Panel panelNavigation;
        private Button btnLogOut;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}