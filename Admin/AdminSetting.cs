using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kebele_Management_System
{
    public partial class AdminSetting : Form
    {
       
        private string connstring = DB_Connection.connstring;
        public AdminSetting()
        {
            InitializeComponent();
            DisplayTableData();
        }

        private void InsertAdminToDatabase(Admin admin)
        {
            string connectionString = connstring;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO admin (email, password, fullname) VALUES (@Email, @Password, @FullName)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", admin.Email);
                        command.Parameters.AddWithValue("@Password", admin.Password);
                        command.Parameters.AddWithValue("@FullName", admin.FullName);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Admin inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert admin.");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }

            
        }

        private void addAdmin_btn_Click(object sender, EventArgs e)
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
                bool emailExists = v.EmailExists_admin(email_TB.Text);
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
                errorProvider.SetError(fullName_TB, "Enter You Full name");
                allValid = false;
            }
            else { errorProvider.SetError(fullName_TB, null); }



            if (allValid)
            {
                Admin admin = new Admin(email_TB.Text, password_TB.Text, fullName_TB.Text);
                
                InsertAdminToDatabase(admin);
                DisplayTableData();

            }
        }



        private void DisplayTableData()
        {
            try
            {
                string query = "SELECT * FROM admin"; 

                using (MySqlConnection connection = new MySqlConnection(connstring))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            Admin_dataGrid.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                //  connection.Close();
            }

        }

        private void edit_btn_Click_1(object sender, EventArgs e)
        {
            // Check if a single row is selected
            if (Admin_dataGrid.SelectedRows.Count == 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = Admin_dataGrid.SelectedRows[0];

                // Get the values from the selected row
                string id = selectedRow.Cells["id"].Value.ToString();
                string fullName = selectedRow.Cells["fullname"].Value.ToString();
                string email = selectedRow.Cells["email"].Value.ToString();
                string password = selectedRow.Cells["password"].Value.ToString();
                

                // Pass the values to the edit form
                EditAdminPanel editForm = new EditAdminPanel(id,email, password, fullName);
                editForm.ShowDialog();

                // Refresh the table data after editing
                DisplayTableData();
            }
        }

        private void delete_btn_Click_1(object sender, EventArgs e)
        {
            // Check if a single row is selected
            if (Admin_dataGrid.SelectedRows.Count == 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = Admin_dataGrid.SelectedRows[0];

                // Get the ID from the selected row
                string id = selectedRow.Cells["id"].Value.ToString();

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connstring))
                    {
                        connection.Open();

                        // Delete the selected row from the current table
                        string deleteQuery = "DELETE FROM admin WHERE id = @id";
                        using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@id", id);
                            deleteCommand.ExecuteNonQuery();
                        }

                        // Refresh the DataGridView
                        DisplayTableData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        
    }
}
