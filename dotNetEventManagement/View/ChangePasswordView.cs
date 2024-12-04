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
    public partial class ChangePasswordView : Form
    {
        private User user;
        public ChangePasswordView(User user)
        {
            InitializeComponent();
            this.user = Session.CurrentUser;

        }
    }
}
