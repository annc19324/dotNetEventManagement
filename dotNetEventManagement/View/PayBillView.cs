using dotNetEventManagement.Controllers;
using dotNetEventManagement.Models;
using OfficeOpenXml;
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
            this.order = Session.order;

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
            bool paid = orderController.PayBill(orderId);
            if (paid)
            {
                bool isUpdateBill = orderController.UpdatePaymentStatus(orderId, "Đã thanh toán");
                if (isUpdateBill)
                {
                    MessageBox.Show("Thanh toán hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExportToExcel(Session.order);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("bạn đã thanh toán hóa đơn này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("bạn đã thanh toán hóa đơn này! Đóng hóa đơn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void btnPayLater_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportToExcel(Order order)
        {
            if (order == null)
            {
                MessageBox.Show("Thông tin đơn hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
            string directoryPath = Path.Combine(projectRoot, "AllBills");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, "Bills.xlsx");

            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;

            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets.FirstOrDefault() ?? package.Workbook.Worksheets.Add("Hóa đơn");

                if (!fileExists)
                {
                    worksheet.Cells[1, 2].Value = "Mã hóa đơn";
                    worksheet.Cells[1, 3].Value = "Tên khách hàng";
                    worksheet.Cells[1, 4].Value = "Mã sự kiện";
                    worksheet.Cells[1, 5].Value = "Tên sự kiện";
                    worksheet.Cells[1, 6].Value = "Ngày đặt";
                    worksheet.Cells[1, 7].Value = "Tổng tiền";
                }

                int lastRow = worksheet.Dimension?.End.Row ?? 1;

                worksheet.Cells[lastRow + 1, 2].Value = order.OrderId.ToString();
                worksheet.Cells[lastRow + 1, 3].Value = order.FullName;
                worksheet.Cells[lastRow + 1, 4].Value = order.EventId?.ToString() ?? "Không có dữ liệu";
                worksheet.Cells[lastRow + 1, 5].Value = order.EventName ?? "Không có dữ liệu";
                worksheet.Cells[lastRow + 1, 6].Value = order.OrderDate.ToString("dd/MM/yyyy");
                worksheet.Cells[lastRow + 1, 7].Value = order.TotalPrice.ToString();

                package.Save();
                MessageBox.Show("Hóa đơn đã được thêm vào Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
