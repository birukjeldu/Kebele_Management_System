using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kebele_Management_System
{
    public partial class RegisteredUsers : Form
    {
        
        private string connstring = DB_Connection.connstring;
        public RegisteredUsers()
        {
            InitializeComponent();
            DisplayTableData();
        }
        private void DisplayTableData()
        {
            try
            {
                string query = "SELECT * FROM users"; 

                using (MySqlConnection connection = new MySqlConnection(connstring))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            registeredDataGridView.DataSource = dataTable;
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

        private void edit_btn_Click(object sender, EventArgs e)
        {
            // Check if a single row is selected
            if (registeredDataGridView.SelectedRows.Count == 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = registeredDataGridView.SelectedRows[0];

                // Get the values from the selected row
                string id = selectedRow.Cells["id"].Value.ToString();
                string firstname = selectedRow.Cells["firstname"].Value.ToString();
                string fathername = selectedRow.Cells["fathername"].Value.ToString();
                string grandfathername = selectedRow.Cells["grandfathername"].Value.ToString();
                string email = selectedRow.Cells["email"].Value.ToString();
                string phone = selectedRow.Cells["phone"].Value.ToString();
                string sex = selectedRow.Cells["sex"].Value.ToString();
                string password = selectedRow.Cells["password"].Value.ToString();
                string age = selectedRow.Cells["age"].Value.ToString();
                string housenumber = selectedRow.Cells["house_number"].Value.ToString();
                string bloodtype = selectedRow.Cells["bloodtype"].Value.ToString();
                string nationality = selectedRow.Cells["nationality"].Value.ToString();
                string occupation = selectedRow.Cells["occupation"].Value.ToString();
                string dateofbirth = selectedRow.Cells["dateofbirth"].Value.ToString();
                string maritalstatus = selectedRow.Cells["maritalstatus"].Value.ToString();
                string issuedate = selectedRow.Cells["approveddate"].Value.ToString();
                string region = selectedRow.Cells["region"].Value.ToString();
                string zone = selectedRow.Cells["zone"].Value.ToString();
                string woreda = selectedRow.Cells["woreda"].Value.ToString();
                string kebele = selectedRow.Cells["kebele"].Value.ToString();
                byte[] image = (byte[])selectedRow.Cells["image"].Value;

                // Pass the values to the edit form
                EditPanel editForm = new EditPanel(id, firstname, fathername, grandfathername, email, phone, sex, password, age, bloodtype, nationality, occupation, dateofbirth, maritalstatus, issuedate, region, zone, woreda, kebele, image, housenumber);
                editForm.ShowDialog();

                // Refresh the table data after editing
                DisplayTableData();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            // Check if a single row is selected
            if (registeredDataGridView.SelectedRows.Count == 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = registeredDataGridView.SelectedRows[0];

                // Get the ID from the selected row
                string id = selectedRow.Cells["id"].Value.ToString();

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connstring))
                    {
                        connection.Open();

                        // Delete the selected row from the current table
                        string deleteQuery = "DELETE FROM users WHERE id = @id";
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
