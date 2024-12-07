using dotNetEventManagement.Controllers;
using Microsoft.Data.SqlClient;
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
        private Connect dbConnect=new Connect();
        public AdminHome()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            // Chuỗi kết nối
            

            // Câu truy vấn
            string sql = "SELECT OrderDate, COUNT(*) AS So_Luong FROM [Orders] GROUP BY OrderDate";

            // Kết nối cơ sở dữ liệu
            using (SqlConnection cons = dbConnect.ConnectSQL())
            {
                // Đổ dữ liệu vào DataTable
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, cons);
                sqlDataAdapter.Fill(dataTable);

                // Gắn dữ liệu vào DataGridView
                dataGridView1.DataSource = dataTable;

                // Định dạng tiêu đề cột (nếu cần)
                dataGridView1.Columns[0].HeaderText = "Ngày Đặt Hàng";
                dataGridView1.Columns[1].HeaderText = "Số Lượng";

                // Tùy chỉnh giao diện DataGridView (nếu cần)
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false; // Không cho thêm hàng mới
                dataGridView1.ReadOnly = true; // Chỉ đọc dữ liệu
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var newWindowState = new EventManager();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new AccountManager();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var newWindowState = new OrderManager();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new LogInView();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new AttendeeManager();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindowState = new EventManager();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var newWindowState = new OrderManager();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var newWindowState = new AccountManager();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            var newWindowState = new AttendeeManager();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var newWindowState = new LogInView();
            if (this.WindowState == FormWindowState.Maximized)
            {
                newWindowState.WindowState = FormWindowState.Maximized;
            }
            newWindowState.ShowDialog();
            this.Close();
        }
    }
}
