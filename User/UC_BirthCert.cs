﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kebele_Management_System.User
{
    public partial class UC_BirthCert : UserControl
    {
        Users.RegisteredUser signedUser;
        public UC_BirthCert(Users.RegisteredUser signedUser)
        {
            InitializeComponent();
            this.signedUser = signedUser;
            label1.Text = this.signedUser.Email;
        }

        
    }
}