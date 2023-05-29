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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
            loadForm(new Dashboard());
            dashboardLabel.ForeColor = SystemColors.Highlight;
        }

        public void loadForm(object Form)
        {
            if(this.mainpane.Controls.Count > 0)
            {
                this.mainpane.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpane.Controls.Add(f);
            this.mainpane.Tag = f;
            f.Show();
        }

        private void dashboardLabel_Click(object sender, EventArgs e)
        {
            loadForm(new Dashboard());
            dashboardLabel.ForeColor = SystemColors.Highlight;
        }
    }
}
