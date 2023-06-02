using Kebele_Management_System.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kebele_Management_System
{
    
    public
        partial class UserDashboard : Form
    {
        private int userId;
        public UserDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            UC_Home home = new UC_Home();
            addUserControl(home);
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        
        private void IdButton_Click(object sender, EventArgs e)
        {
            UC_Id uC = new UC_Id();
            addUserControl(uC);
        }

        private void birthButton_Click(object sender, EventArgs e)
        {
            UC_BirthCert birth = new UC_BirthCert();
            addUserControl(birth);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home();
            addUserControl(home);
        }
    }
}
