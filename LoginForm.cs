using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kebele_Management_System
{
    public partial class login_page : Form
    {
        Validator v = new Validator();
        private string connstring = DB_Connection.connstring;
        public login_page()
        {
            InitializeComponent();
        }



        private void login_btn_Click(object sender, EventArgs e)
        {
            int userId = Login(email_TB.Text, password_TB.Text);
            if (userId != -1)
            {
                email_error.Text = "";
                UserDashboard userDashboard = new UserDashboard(userId);
                userDashboard.Owner = null;
                userDashboard.Show();
                this.Hide();




            }
            else
            {
                email_error.Text = "Invalid Credential!";
                email_error.ForeColor = Color.Red;
            }



        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            RegestarationForm reg = new RegestarationForm();
            reg.ShowDialog();
        }

        public int Login(string email, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connstring))
                {
                    connection.Open();

                    string query = "SELECT id FROM users WHERE email = @email AND password = @password";
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               //Console.WriteLine("Error: " + ex.Message);
            }

            // Login failed
            //Console.WriteLine("Login failed. Invalid email or password.");

            return -1;
        }

        private void login_page_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.ShowDialog();
            
        }
    }
}
