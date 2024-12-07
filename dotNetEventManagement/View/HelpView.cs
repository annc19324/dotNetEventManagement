using dotNetEventManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetEventManagement.View
{
    public partial class HelpView : Form
    {
        private User user;
        public HelpView(User user)
        {
            InitializeComponent();
            this.user = Session.CurrentUser;
            lblFullname.Text = user.Fullname;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "https://www.facebook.com/hanaviet");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở liên kết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new UserHome(Session.CurrentUser);
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }
    }
}
