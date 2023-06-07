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
    public partial class AdminLogin : Form
    {
        string connstring = "server=localhost;uid=root;pwd=root;database=kebele_management_system";
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
       
            this.Close();
        }

        private void adminLogin_btn_Click(object sender, EventArgs e)
        {
            int userId = Login(adminEmail_TB.Text, adminPassword_TB.Text);
            if (userId != -1)
            {
                email_error.Text = "";
                AdminPanelForm adminPanelForm = new AdminPanelForm();
                //adminPanelForm.Owner = null;

                adminPanelForm.Show();
                this.Close();

            }
            else
            {
                email_error.Text = "Invalid email or password";
                email_error.ForeColor = Color.Red;
            }
        }

        public int Login(string email, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connstring))
                {
                    connection.Open();

                    string query = "SELECT id FROM admin WHERE email = @email AND password = @password";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Login successful
                                int userId = reader.GetInt32(0); // Get the ID value from the first column
                                //Console.WriteLine("Login successful. User ID: " + userId);
                                return userId;
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            // Login failed
            //Console.WriteLine("Login failed. Invalid email or password.");

            return -1;
        }
    }
}
