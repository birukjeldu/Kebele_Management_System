using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kebele_Management_System
{
    public partial class RegisteredUsers : Form
    {
        string connstring = "server=localhost;uid=root;pwd=root;database=kebele_management_system";
        public RegisteredUsers()
        {
            InitializeComponent();
            DisplayTableData();
        }
        private void DisplayTableData()
        {
            try
            {
                string query = "SELECT * FROM users"; // Replace "YourTableName" with the actual name of your table

                using (MySqlConnection connection = new MySqlConnection(connstring))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            registeredDataGridView.DataSource = dataTable; // dataGridView is the name of your DataGridView control
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
