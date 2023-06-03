using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kebele_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login_page login_Page = new login_page();
            login_Page.Show();
            Application.Run();

            //Application.Run(new AdminPanelForm());
            //Application.Run(new Test());
            //Application.Run(new UserDashboard(1));

        }
    }
}
