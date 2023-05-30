using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Wpf.Toolkit;

namespace Kebele_Management_System
{
    public partial class RegestarationForm : Form
    {
        public RegestarationForm()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Validator v = new Validator();
            bool allValid = true;
            if (v.isEmptyText("sdfdsf"))
            {
                errorProvider.SetError(firstName_TB, "Empty form please re wirte bithc");
            }
        }
    }
}
