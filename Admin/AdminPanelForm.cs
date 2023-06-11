using System;
using System.Drawing;
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
            registeredLabel.ForeColor = SystemColors.ActiveCaptionText;
            waitingLabel.ForeColor = SystemColors.ActiveCaptionText;
            settingLabel.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void registeredLabel_Click(object sender, EventArgs e)
        {
            loadForm(new RegisteredUsers());
            registeredLabel.ForeColor = SystemColors.Highlight;
            dashboardLabel.ForeColor = SystemColors.ActiveCaptionText;
            waitingLabel.ForeColor = SystemColors.ActiveCaptionText;
            settingLabel.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void waaitingLabel_Click(object sender, EventArgs e)
        {
            loadForm(new WaitingList());
            waitingLabel.ForeColor = SystemColors.Highlight;
            registeredLabel.ForeColor = SystemColors.ActiveCaptionText;
            dashboardLabel.ForeColor = SystemColors.ActiveCaptionText;
            settingLabel.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void settingLabel_Click(object sender, EventArgs e)
        {
            loadForm(new AdminSetting());
            settingLabel.ForeColor = SystemColors.Highlight;
            waitingLabel.ForeColor = SystemColors.ActiveCaptionText;
            registeredLabel.ForeColor = SystemColors.ActiveCaptionText;
            dashboardLabel.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login_page login = new login_page();
            //login.Owner = null;
            //login.Show();
            this.Close();
        }

        private void AdminPanelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
