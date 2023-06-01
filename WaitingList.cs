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
    public partial class WaitingList : Form
    {
        string connstring = "server=localhost;uid=root;pwd=root;database=kebele_management_system";
        public WaitingList()
        {
            InitializeComponent();
            DisplayTableData();
        }
        private void DisplayTableData()
        {
            try
            {
                string query = "SELECT * FROM waiting"; // Replace "YourTableName" with the actual name of your table

                using (MySqlConnection connection = new MySqlConnection(connstring))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            waitingDataGridView.DataSource = dataTable; // dataGridView is the name of your DataGridView control
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void approve_btn_Click(object sender, EventArgs e)
        {
            // Check if a single row is selected
            if (waitingDataGridView.SelectedRows.Count == 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = waitingDataGridView.SelectedRows[0];
                DateTime today = DateTime.Today;
                int year = today.Year;
                int month = today.Month;
                int day = today.Day;
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
                string bloodtype = selectedRow.Cells["bloodtype"].Value.ToString();
                string nationality = selectedRow.Cells["nationality"].Value.ToString();
                string occupation = selectedRow.Cells["occupation"].Value.ToString();
                string dateofbirth = selectedRow.Cells["dateofbirth"].Value.ToString();
                string maritalstatus = selectedRow.Cells["maritalstatus"].Value.ToString();
                string approveddate = day.ToString() + '/' + month.ToString() + '/' + year.ToString();
                string expirationdate = day.ToString() + '/' + month.ToString() + '/' + (year + 10).ToString();
                string region = selectedRow.Cells["region"].Value.ToString();
                string zone = selectedRow.Cells["zone"].Value.ToString();
                string woreda = selectedRow.Cells["woreda"].Value.ToString();
                string kebele = selectedRow.Cells["kebele"].Value.ToString();
                byte[] image = (byte[])selectedRow.Cells["image"].Value;

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connstring))
                    {
                        connection.Open();

                        // Insert the selected data into a new table
                        string insertQuery = "INSERT INTO users (firstname, fathername, grandfathername, email,birthcardverification,expirationdate,image, phone, sex, password, age, bloodtype, nationality, occupation, dateofbirth, maritalstatus, approveddate, region, zone, woreda, kebele) " +
                            "VALUES (@firstname, @fathername, @grandfathername, @email,@birthcardverification,@expirationdate,@image, @phone, @sex, @password, @age, @bloodtype, @nationality, @occupation, @dateofbirth, @maritalstatus, @approveddate, @region, @zone, @woreda, @kebele)";

                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            //insertCommand.Parameters.AddWithValue("@id", id);
                            insertCommand.Parameters.AddWithValue("@firstname", firstname);
                            insertCommand.Parameters.AddWithValue("@fathername", fathername);
                            insertCommand.Parameters.AddWithValue("@grandfathername", grandfathername);
                            insertCommand.Parameters.AddWithValue("@email", email);
                            insertCommand.Parameters.AddWithValue("@phone", phone);
                            insertCommand.Parameters.AddWithValue("@sex", sex);
                            insertCommand.Parameters.AddWithValue("@password", password);
                            insertCommand.Parameters.AddWithValue("@age", age);
                            insertCommand.Parameters.AddWithValue("@bloodtype", bloodtype);
                            insertCommand.Parameters.AddWithValue("@nationality", nationality);
                            insertCommand.Parameters.AddWithValue("@occupation", occupation);
                            insertCommand.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                            insertCommand.Parameters.AddWithValue("@maritalstatus", maritalstatus);
                            insertCommand.Parameters.AddWithValue("@approveddate", approveddate);
                            insertCommand.Parameters.AddWithValue("@expirationdate", expirationdate);
                            insertCommand.Parameters.AddWithValue("@region", region);
                            insertCommand.Parameters.AddWithValue("@zone", zone);
                            insertCommand.Parameters.AddWithValue("@woreda", woreda);
                            insertCommand.Parameters.AddWithValue("@kebele", kebele);
                            insertCommand.Parameters.AddWithValue("@image", image);
                            insertCommand.Parameters.AddWithValue("@birthcardverification", "false");

                            insertCommand.ExecuteNonQuery();
                        }

                        // Delete the selected row from the current table
                        string deleteQuery = "DELETE FROM waiting WHERE id = @id";
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

        private void decline_btn_Click(object sender, EventArgs e)
        {
            // Check if a single row is selected
            if (waitingDataGridView.SelectedRows.Count == 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = waitingDataGridView.SelectedRows[0];

                // Get the ID from the selected row
                string id = selectedRow.Cells["id"].Value.ToString();

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connstring))
                    {
                        connection.Open();

                        // Delete the selected row from the current table
                        string deleteQuery = "DELETE FROM waiting WHERE id = @id";
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
