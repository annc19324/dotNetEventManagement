﻿using dotNetEventManagement.Models;
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
        public RegisteredEvent(User user)
        {
            InitializeComponent();
            this.user = Session.CurrentUser;

        }
    }
}
