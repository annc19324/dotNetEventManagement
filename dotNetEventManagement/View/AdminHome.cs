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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new EventManager().ShowDialog();
            this.Close();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new AccountManager().ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new OrderManager().ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new LogInView().ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            new AttendeeManager().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EventManager().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new OrderManager().ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AccountManager().ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AttendeeManager().ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new LogInView().ShowDialog();
            this.Close();
        }
    }
}
