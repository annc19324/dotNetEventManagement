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
    public partial class RegisteredEvent : Form
    {
        private User user;
        private EventController eventController;
        private bool isOpeningMenu = false;
        private const int menuWidth = 260;
        public RegisteredEvent(User user)
        {
            InitializeComponent();
            this.user = Session.CurrentUser;
            lblFullname.Text = user.Fullname;
            eventController = new EventController();
            showAllEvents();
        }

        private void showAllEvents()
        {
            BindingList<Event> registeredEvents = new BindingList<Event>(eventController.GetRegisteredEventsByUserId(user.UserId));
            dgvRegisteredEventList.DataSource = registeredEvents;
        }

        private void btnUserHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHome(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void btnCancelEvent_Click(object sender, EventArgs e)
        {
            if (dgvRegisteredEventList.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sự kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedRow = dgvRegisteredEventList.SelectedCells[0].RowIndex;

            if (selectedRow < 0 || selectedRow >= dgvRegisteredEventList.Rows.Count)
            {
                MessageBox.Show("Lỗi: chỉ mục hàng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? eventId = dgvRegisteredEventList.Rows[selectedRow].Cells["EventId"].Value.ToString();
            int userId = user.UserId;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy đăng ký sự kiện này?",
                                                  "Xác nhận hủy đăng ký",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                bool isCancelled = eventController.CancelRegistration(userId, eventId);

                if (isCancelled)
                {
                    dgvRegisteredEventList.Rows.RemoveAt(selectedRow);
                    Session.removeRegisteredEventById(eventId);
                    MessageBox.Show("Đã hủy đăng ký sự kiện thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi hủy đăng ký sự kiện. Vui lòng thử lại.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            int selectedRow = dgvRegisteredEventList.SelectedRows.Count > 0 ? dgvRegisteredEventList.SelectedRows[0].Index : -1;

            if (selectedRow == -1)
            {
                MessageBox.Show("Vui lòng chọn một sự kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userId = user.UserId;
            string? eventId = dgvRegisteredEventList.Rows[selectedRow].Cells[0].Value.ToString();

            // Tìm đơn hàng trong cơ sở dữ liệu
            OrderController orderController = new OrderController();
            Order order = orderController.GetOrderByUserIdAndEventId(userId, eventId);

            if (order != null)
            {
                new PayBillView(order).ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy đơn hàng cho sự kiện đã chọn! Có thể bạn đã bị admin xóa đơn hàng, vui lòng hủy sự kiện và đăng ký lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(key) || key == "nhập mã sự kiện hoặc tên sự kiện cần tìm ở đây")
            {
                MessageBox.Show("Hãy nhập mã sự kiện hoặc tên sự kiện cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showAllEvents();
                return;
            }
            List<Event> filteredEvents = eventController.GetRegisteredEventsByUserId(user.UserId)
        .Where(e => e.EventId.ToLower().Contains(key) || e.EventName.ToLower().Contains(key))
        .ToList();

            if (filteredEvents.Count > 0)
            {
                // Cập nhật lại dữ liệu cho DataGridView
                BindingList<Event> bindingList = new BindingList<Event>(filteredEvents);
                dgvRegisteredEventList.DataSource = bindingList;
            }
            else
            {
                MessageBox.Show($"Không có thông tin về '{key}'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvRegisteredEventList.CurrentCell = null;
            showAllEvents();
        }

        private void RegisteredEvent_Load(object sender, EventArgs e)
        {

        }

        private void RegisteredEvent_Click(object sender, EventArgs e)
        {

        }

        private void RegisteredEvent_Shown(object sender, EventArgs e)
        {
            txtSearch.Focus();
            dgvRegisteredEventList.CurrentCell = null;

        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHome(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void labelEventList_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EventList(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void labelRegisteredEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisteredEvent(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void labelAccountInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountInformation(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HelpView(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void labelChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePasswordView(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn có chắc muốn đăng xuất?", "xác nhận đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Session.clear();
                new LogInView().ShowDialog();
                this.Close();
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            OpenMenu();
        }

        private void RegisteredEvent_Resize(object sender, EventArgs e)
        {

        }

        private void panelContainer_Click(object sender, EventArgs e)
        {
            if (isOpeningMenu)
            {
                CloseMenu();
            }
        }


        //them moi
        private void OpenMenu()
        {
            panelContainer.BringToFront();
            panelHome.SendToBack();
            panelContainer.BackColor = Color.LightGray;
            panelHome.Enabled = false;
            pnlSlideMenu.BringToFront();
            pnlSlideMenu.BackColor = Color.DarkGray;

            isOpeningMenu = true;

            new Thread(() =>
            {
                for (int i = 0; i <= menuWidth; i += 20)
                {
                    this.Invoke((Action)(() =>
                    {
                        pnlSlideMenu.Size = new Size(i, pnlSlideMenu.Height);
                    }));
                    Thread.Sleep(10);
                }
            }).Start();
        }

        private void CloseMenu()
        {
            panelHome.BringToFront();
            panelContainer.SendToBack();
            //panelContainer.BackColor = Color.Transparent;
            panelHome.Enabled = true;

            isOpeningMenu = false;

            panelContainer.Visible = true;

            new Thread(() =>
            {
                for (int i = menuWidth; i >= 0; i -= 20)
                {
                    this.Invoke((Action)(() =>
                    {
                        pnlSlideMenu.Size = new Size(i, pnlSlideMenu.Height);
                    }));
                    Thread.Sleep(10);
                }
            }).Start();
        }


    }
}
