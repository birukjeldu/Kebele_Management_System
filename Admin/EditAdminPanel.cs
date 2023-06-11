using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kebele_Management_System
{
    public partial class EditAdminPanel : Form
    {
        private MySqlConnection connection;
        private string connectionString = DB_Connection.connstring;

        private string Email;
        private string Password;
        private string FullName;
        private string Id;

        
        public EditAdminPanel(string id ,string email, string password, string fullName)
        {
            this.Email = email;
            this.Password = password;
            this.FullName = fullName;
            this.Id = id;
            InitializeComponent();

            //Pre-fill the forms
            fullName_TB.Text = fullName;
            email_TB.Text = email;
            password_TB.Text = password;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Validator v = new Validator();
            bool allValid = true;

            //Email Validation
            if (!(v.isValidEmail(email_TB.Text)) || v.isEmptyText(email_TB.Text))
            {
                errorProvider.SetError(email_TB, "Invalid Email");
                allValid = false;
            }
            else
            {
                bool emailExists = v.EmailExists_adminUpdate(email_TB.Text,Id);
                if (emailExists)
                {
                    errorProvider.SetError(email_TB, "Email Already Exists");
                    allValid = false;
                }
                else
                {
                    errorProvider.SetError(email_TB, null);
                }

            }

            //Password Validation
            if (v.isEmptyText(password_TB.Text))
            {
                errorProvider.SetError(password_TB, "Enter Password");
                allValid = false;
            }
            else { errorProvider.SetError(password_TB, null); }

            //Full Name Validation
            if (v.isEmptyText(fullName_TB.Text))
            {
                errorProvider.SetError(fullName_TB, "Enter Your Full name");
                allValid = false;
            }
            else { errorProvider.SetError(fullName_TB, null); }

            if (allValid)
            {
                string email = email_TB.Text;
                string password = password_TB.Text;
                string fullName = fullName_TB.Text;


                try
                {
                    // Establish a database connection
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Prepare the update query
                        string updateQuery = "UPDATE admin SET password = @Password, fullname = @FullName, email = @email WHERE id = @id"; ;


                        // Create a SqlCommand object with the query and connection
                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            // Set the parameter values
                            command.Parameters.AddWithValue("@fullname", fullName);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@password", password);
                            command.Parameters.AddWithValue("@id", Id);

                            // Execute the update query
                            command.ExecuteNonQuery();
                        }

                        // Close the database connection
                        connection.Close();
                    }

                    // Display a success message to the user
                    MessageBox.Show("Record updated successfully.");
                    //this.Close();
                }
                catch (Exception ex)
                {
                    // Display an error message to the user
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            


        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
