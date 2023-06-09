using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kebele_Management_System
{
    public partial class Dashboard : Form
    {
        private string connectionString = "server=localhost;uid=root;pwd=root;database=kebele_management_system";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // LoadChartData();
            approvedUsers_lbl.Text = GetTotalUsersCount().ToString();
            waitinUser_lbl.Text = GetWaitingUsersCount().ToString();
            totalUser_lbl.Text = (GetTotalUsersCount() + GetWaitingUsersCount()).ToString();
            birthCardVerified_lbl.Text = GetVerifiedUsersCount().ToString();
            totalAdmin_lbl.Text = GetTotalAdminsCount().ToString();
            DisplayUsersByRegion();
        }

        public int GetTotalUsersCount()
        {
            int totalUsersCount = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM users";

                using ( MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        totalUsersCount = Convert.ToInt32(result);
                    }
                }
            }

            return totalUsersCount;
        }
        

        public int GetWaitingUsersCount()
        {
            int approvedUsersCount = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM waiting";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        approvedUsersCount = Convert.ToInt32(result);
                    }
                }
            }

            return approvedUsersCount;
        }

        public int GetVerifiedUsersCount()
        {
            int verifiedUsersCount = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM users WHERE birthcardverification = 'true'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        verifiedUsersCount = Convert.ToInt32(result);
                    }
                }
            }

            return verifiedUsersCount;
        }

        public int GetTotalAdminsCount()
        {
            int totalAdminsCount = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM admin";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        totalAdminsCount = Convert.ToInt32(result);
                    }
                }
            }

            return totalAdminsCount;
        }

        //Graph
        private void DisplayUsersByRegion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT region, COUNT(*) as TotalUsers FROM users GROUP BY region";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string region = reader.GetString("region");
                            int totalUsers = reader.GetInt32("TotalUsers");

                            // Add the data point to the chart
                            myChart.Series["UsersByRegion"].Points.AddXY(region, totalUsers);
                        }
                    }
                }
            }
            myChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 12f, FontStyle.Regular);

        }



    }
}
