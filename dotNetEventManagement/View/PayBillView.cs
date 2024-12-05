using dotNetEventManagement.Controllers;
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
    public partial class PayBillView : Form
    {
        private Order order;
        private User user;
        private OrderController orderController;
        public PayBillView(Order order)
        {
            InitializeComponent();
            this.user = Session.CurrentUser;
            orderController = new OrderController();

            labelOrderId.Text = order.OrderId.ToString();
            labelUserId.Text = order.UserId.ToString();
            labelFullname.Text = order.FullName?.ToString() ?? "chưa có tên";
            labelEventId.Text = order.EventId?.ToString();
            labelEventName.Text = order.EventName?.ToString();
            labelOrderDate.Text = order.OrderDate.ToString();
            labelPrice.Text = order.TotalPrice.ToString();

        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(labelOrderId.Text);
            string fullname = labelFullname.Text;
            string eventId = labelEventId.Text;
            bool isUpdateBill = orderController.PayBill(orderId);
            if (isUpdateBill) {
                MessageBox.Show("Thanh toán hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("có lỗi khi thanh toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPayLater_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
