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
    public partial class EventList : Form
    {
        private User user;
        private EventController eventController;
        private bool isOpeningMenu = false;
        private const int menuWidth = 260;
        public EventList(User user)
        {
            InitializeComponent();
            this.user = Session.CurrentUser;
            lblFullname.Text = user.Fullname;
            eventController = new EventController();

            dgvEventList.DataSource = new BindingList<Event>();
            ShowAllEvents();

        }

        private void labelRegisteredEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisteredEvent(Session.CurrentUser).ShowDialog();
            this.Close();
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
            new UserHome(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void labelAccountInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHome(Session.CurrentUser).ShowDialog();
            this.Close();
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHome(Session.CurrentUser).ShowDialog();
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

        private void panelContainerCenter()
        {
            //panelMain.Left = (this.ClientSize.Width - panelMain.Width) / 2;
            //panelMain.Top = (this.ClientSize.Height - panelMain.Height) / 2;
            panelMain.Left = 0;
            panelMain.Top = 0;
            panelMain.Width = this.ClientSize.Width;
            panelMain.Height = this.ClientSize.Height;
            panelContainer.Left = panelMain.Left;
            panelContainer.Top = panelHeader.Bottom;
            panelContainer.Width = this.ClientSize.Width;
            panelContainer.Height = this.ClientSize.Height - panelHeader.Height;
        }

        private void lblHeaderCenter()
        {
            lblFullname.Left = (panelHeader.ClientSize.Width - lblFullname.Width) / 2;
            lblFullname.Top = (panelHeader.ClientSize.Height - lblFullname.Height) / 2;
        }

        private void panelHomeCenter()
        {
            panelHome.Width = panelContainer.Width;
            panelHome.Height = panelContainer.Height;
            panelHome.Left = 0;
            panelHome.Top = 0;

        }

        private void panelContentCenter()
        {
            panelContent.Left = (panelHome.ClientSize.Width - panelContent.Width) / 2;
            panelContent.Top = (panelHome.ClientSize.Height - panelContent.Height) / 2;
        }

        //ket thuc them moi



        private void EventList_Load(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelHomeCenter();
            panelContentCenter();
            panelHeader.Width = panelMain.Width;
            panelContainer.Height = panelMain.Height - panelHeader.Height;
            panelContainer.Width = panelMain.Width;
            pnlSlideMenu.Height = panelMain.Height;

        }

        private void EventList_Resize(object sender, EventArgs e)
        {
            panelContainerCenter();
            lblHeaderCenter();
            panelHomeCenter();
            panelContentCenter();
            panelHeader.Width = panelMain.Width;
            panelContainer.Height = panelMain.Height - panelHeader.Height;
            panelContainer.Width = panelMain.Width;
            pnlSlideMenu.Height = panelMain.Height;
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            OpenMenu();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void panelContainer_Click(object sender, EventArgs e)
        {
            if (isOpeningMenu)
            {
                CloseMenu();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //ShowAllEvents();
            var events = eventController.GetAllEvents();
            dgvEventList.DataSource = events;
        }

        private void btnRegistEvent_Click(object sender, EventArgs e)
        {
            int selectedRow = dgvEventList.SelectedCells[0].RowIndex;
            if (selectedRow == -1)
            {
                MessageBox.Show("Chọn ít nhất 1 sự kiện muốn tham gia để đăng ký!");
                return;
            }

            string eventId = dgvEventList.Rows[selectedRow].Cells[0].Value.ToString();
            string eventName = dgvEventList.Rows[selectedRow].Cells[1].Value.ToString();
            string startDate = dgvEventList.Rows[selectedRow].Cells[2].Value.ToString();
            string endDate = dgvEventList.Rows[selectedRow].Cells[3].Value.ToString();
            string location = dgvEventList.Rows[selectedRow].Cells[4].Value.ToString();
            string description = dgvEventList.Rows[selectedRow].Cells[5].Value.ToString();
            string status = dgvEventList.Rows[selectedRow].Cells[6].Value.ToString();
            string priceString = dgvEventList.Rows[selectedRow].Cells[7].Value.ToString();

            double price = 0;
            bool isPriceValid = double.TryParse(priceString, out price);

            if (!isPriceValid)
            {
                MessageBox.Show("Giá trị của sự kiện không hợp lệ!");
                return;
            }

            bool isRegistered = eventController.RegisterEvent(Session.getUser().UserId, Session.getUser().Fullname, eventId, eventName);
            if (isRegistered)
            {
                Event eventDetail = new Event(eventId, eventName, startDate, endDate, location, description, status, price);
                Session.AddRegisteredEvent(eventDetail);

                OrderController orderController = new OrderController();
                bool isOrderAdded = orderController.AddOrderForAttendee(Session.getUser().UserId, eventId);

                if (isOrderAdded)
                {
                    MessageBox.Show("Đăng ký và tạo đơn hàng thành công!");
                }
            }
            else
            {
                MessageBox.Show("Sự kiện này có thể đã được đăng ký và không thể tạo đơn hàng!");
            }
        }


        private void ShowAllEvents()
        {
            List<Event> eList = eventController.GetAllEvents();
            var model = (BindingList<Event>)dgvEventList.DataSource;
            model.Clear();

            foreach (var eventItem in eList)
            {
                model.Add(eventItem);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            var events = eventController.SearchEvents(keyword);
            dgvEventList.DataSource = events;
        }
    }
}
