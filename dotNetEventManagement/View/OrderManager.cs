using dotNetEventManagement.Controllers;
using dotNetEventManagement.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class OrderManager : Form
    {
        private OrderController orderController = new OrderController();
        public OrderManager()
        {
            InitializeComponent();
            LoadOrder();
        }
        private void LoadOrder()
        {
            List<Order> order = orderController.GetOrders();
            dataGridViewOrderManager.DataSource = order;
        }
        public void ClearText()
        {
            txtEventId.Clear();
            txtEventName.Clear();
            txtFullName.Clear();
            txtPrice.Clear();
            txtTimKiem.Clear();
            txtUserId.Clear();
            cmbStatus.SelectedIndex = -1;
            dateTimeOrder.Value = DateTime.Now;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword=txtTimKiem.Text;
                List<Order> orders = orderController.SearchOrder(keyword);
                dataGridViewOrderManager.DataSource= orders;
                ClearText();
            }
            catch (Exception ex) {
                MessageBox.Show($"Lỗi khi tìm kiếm đơn hàng: {ex.Message}");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = int.Parse(txtUserId.Text);
                string username = txtFullName.Text;
                string eventid = txtEventId.Text;
                string eventName = txtEventName.Text;
                DateTime dateorder = dateTimeOrder.Value;
                string status = cmbStatus.Text;
                double price = Double.Parse(txtPrice.Text);

                Order order = new Order
                {
                    OrderId = 0,
                    UserId = userid,
                    EventId = eventid,
                    FullName = username,
                    EventName = eventName,
                    TotalPrice = price,
                    OrderDate = dateorder,
                    PaymentStatus = status
                };

                orderController.AddOrder(order);

                LoadOrder();

                ClearText();
                MessageBox.Show("Thêm đơn hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm đơn hàng: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOrderManager.CurrentRow != null)
                {
                    // Lấy chỉ số hàng được chọn
                    int selectedRow = dataGridViewOrderManager.CurrentRow.Index;

                    // Lấy giá trị OrderId từ cột đầu tiên
                    int orderId = (int)dataGridViewOrderManager.Rows[selectedRow].Cells[0].Value;

                    // Thực hiện hành động xóa
                    bool deleteOrder = orderController.DeleteOrder(orderId);
                    if (deleteOrder)
                    {
                        MessageBox.Show($"Xóa đơn hàng thành công!!");
                    }
                    else
                    {
                        MessageBox.Show($"Xóa đơn hàng thất bại!!");
                    }
                    LoadOrder();

                    ClearText();
                }
                else
                {
                    MessageBox.Show($"Chọn đơn hàng để xóa!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa đơn hàng: {ex.Message}");
            }

        }

        private void dataGridViewOrderManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtEventId.Text = dataGridViewOrderManager.Rows[r].Cells["EventId"].Value.ToString();
                txtEventName.Text = dataGridViewOrderManager.Rows[r].Cells["EventName"].Value.ToString();
                txtFullName.Text = dataGridViewOrderManager.Rows[r].Cells["FullName"].Value.ToString();
                txtPrice.Text = dataGridViewOrderManager.Rows[r].Cells["TotalPrice"].Value.ToString();
                txtUserId.Text = dataGridViewOrderManager.Rows[r].Cells["UserId"].Value.ToString();
                if (dataGridViewOrderManager.Rows[r].Cells["OrderDate"].Value is DateTime orderDate)
                {
                    dateTimeOrder.Value = orderDate;
                }
                cmbStatus.Text = dataGridViewOrderManager.Rows[r].Cells["PaymentStatus"].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadOrder();

            ClearText();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOrderManager.CurrentRow != null)
                {
                    // Lấy chỉ số hàng được chọn
                    int selectedRow = dataGridViewOrderManager.CurrentRow.Index;

                    // Lấy giá trị OrderId từ cột đầu tiên
                    int orderId = (int)dataGridViewOrderManager.Rows[selectedRow].Cells[0].Value;

                    int userid = int.Parse(txtUserId.Text);
                    string username = txtFullName.Text;
                    string eventid = txtEventId.Text;
                    string eventName = txtEventName.Text;
                    DateTime dateorder = dateTimeOrder.Value;
                    string status = cmbStatus.Text;
                    double price = Double.Parse(txtPrice.Text);

                    Order order = new Order
                    {
                        OrderId = orderId,
                        UserId = userid,
                        EventId = eventid,
                        FullName = username,
                        EventName = eventName,
                        TotalPrice = price,
                        OrderDate = dateorder,
                        PaymentStatus = status
                    };

                    orderController.UpdateOrder(order);

                    LoadOrder();

                    ClearText();
                    MessageBox.Show($"Cập nhật đơn hàng thành công!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa đơn hàng: {ex.Message}");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOrderManager.CurrentRow != null)
                {
                    // Lấy chỉ số hàng được chọn
                    int selectedRow = dataGridViewOrderManager.CurrentRow.Index;

                    // Lấy giá trị OrderId từ cột đầu tiên
                    int orderId = (int)dataGridViewOrderManager.Rows[selectedRow].Cells[0].Value;

                    orderController.PayBill(orderId);

                    LoadOrder();

                    ClearText();

                    MessageBox.Show($" Đã thanh toán đơn thành công!");

                }
                else
                {
                    MessageBox.Show($"Chọn đơn hàng cần thanh toán!");
                }
            }catch (Exception ex) {
                 MessageBox.Show($"Lỗi khi thanh toán đơn hàng: {ex.Message}");

            }
        }
    }
}
