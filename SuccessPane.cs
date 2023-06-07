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
    public partial class SuccessPane : Form
    {
        string email;
        private string connectionString = "server=localhost;uid=root;pwd=root;database=kebele_management_system";
        public SuccessPane(string email)
        {
            this.email = email;
            InitializeComponent();
            registerationID_lbl.Text = getID(email).ToString();
            
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        int getID(string email)
        {
            int id =-1;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM waiting WHERE email = @email";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                         id = reader.GetInt32(reader.GetOrdinal("id"));
                    }
                    reader.Close();
                }
            }
            return id;
        }
    }
}
