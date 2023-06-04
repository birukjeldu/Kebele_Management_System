using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Humanizer.In;

namespace Kebele_Management_System.User
{
    public partial class UC_BirthForm : UserControl
    {
        int userId;
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;pwd=root;database=kebele_management_system";
        public UC_BirthForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }


        private void LoadRegions()
        {
            try
            {
                string query = "SELECT DISTINCT Region FROM Location";
                DataTable dt = GetData(query);
                if (dt != null)
                {
                    region_CB.DataSource = dt;
                    region_CB.DisplayMember = "Region";
                    region_CB.ValueMember = "Region";
                    region_CB.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadZones(string selectedRegion)
        {
            try
            {
                string query = "SELECT DISTINCT Zone FROM Location WHERE Region = @Region";
                DataTable dt = GetData(query, new MySqlParameter("@Region", selectedRegion));
                if (dt != null)
                {
                    zone_CB.DataSource = dt;
                    zone_CB.DisplayMember = "Zone";
                    zone_CB.ValueMember = "Zone";
                    zone_CB.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadWeredas(string selectedZone)
        {
            try
            {
                string query = "SELECT DISTINCT Wereda FROM Location WHERE Zone = @Zone";
                DataTable dt = GetData(query, new MySqlParameter("@Zone", selectedZone));
                if (dt != null)
                {
                    wereda_CB.DataSource = dt;
                    wereda_CB.DisplayMember = "Wereda";
                    wereda_CB.ValueMember = "Wereda";
                    wereda_CB.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable GetData(string query, params MySqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddRange(parameters);
                    connection.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void regionComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (region_CB.SelectedIndex != -1)
            {
                string selectedRegion = region_CB.SelectedValue.ToString();
                LoadZones(selectedRegion);
            }
        }

        private void zoneComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (zone_CB.SelectedIndex != -1)
            {
                string selectedZone = zone_CB.SelectedValue.ToString();
                LoadWeredas(selectedZone);
            }
        }



        private void additionalBirthCardInfo_btn_Click(object sender, EventArgs e)
        {
            Validator v = new Validator();
            bool allValid = true;

            if (!(v.isValidName(GGF_Name_TB.Text)) || v.isEmptyText(GGF_Name_TB.Text))
            {
                errorProvider.SetError(GGF_Name_TB, "Invalid Name");
                allValid = false;
            }
            else { errorProvider.SetError(GGF_Name_TB, null); }

            if ( v.isEmptyText(GGM_name_TB.Text))
            {
                errorProvider.SetError(GGM_name_TB, "Invalid Name");
                allValid = false;
            }
            else { errorProvider.SetError(GGM_name_TB, null); }


            if (fatherNationality_CB.SelectedItem == null || fatherNationality_CB.SelectedIndex == -1)
            {
                errorProvider.SetError(fatherNationality_CB, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(fatherNationality_CB, null); }

            if (motherNationality_CB.SelectedItem == null || motherNationality_CB.SelectedIndex == -1)
            {
                errorProvider.SetError(motherNationality_CB, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(motherNationality_CB, null); }



            if (region_CB.SelectedItem == null || region_CB.SelectedIndex == -1)
            {
                errorProvider.SetError(region_CB, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(region_CB, null); }

            if (zone_CB.SelectedItem == null || zone_CB.SelectedIndex == -1)
            {
                errorProvider.SetError(zone_CB, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(zone_CB, null); }

            if (wereda_CB.SelectedItem == null || wereda_CB.SelectedIndex == -1)
            {
                errorProvider.SetError(wereda_CB, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(wereda_CB, null); }

            if (allValid)
            {
                DateTime today = DateTime.Today;
                int year = today.Year;
                int month = today.Month;
                int day = today.Day;
                string issuedDate = day + "/" + month + "/" + year;
                string GGF_Name = GGF_Name_TB.Text;
                DataRowView selectedRow = (DataRowView)region_CB.SelectedItem;
                string region = selectedRow["region"].ToString();
                DataRowView selectedRow1 = (DataRowView)zone_CB.SelectedItem;
                string zone = selectedRow1["zone"].ToString();
                DataRowView selectedRow2 = (DataRowView)wereda_CB.SelectedItem;
                string woreda = selectedRow2["wereda"].ToString();
                string placeBirth = region + "/" + zone + "/"+ woreda;
                string GGM_Name = GGM_name_TB.Text;
                string fatherNationality = fatherNationality_CB.SelectedItem.ToString();
                string motherNationality = motherNationality_CB.SelectedItem.ToString();

                string insertQuery = " INSERT INTO birth_card(user_id, fullfathername, fullmothername, fathernationality, mothernationality, dateofissue,placeofbirth)" +
                                                      "VALUES (@Id, @GGFathername, @GGMothername,@FatherNationality,@MotherNationality, @DateIssued,@placeBirth)";


                string updateQuery = "UPDATE users SET birthcardverification = 'true' WHERE (`id` = '"+userId+"')";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@Id", userId);
                        command.Parameters.AddWithValue("@GGFathername", GGF_Name);
                        command.Parameters.AddWithValue("@GGMothername", GGM_Name);
                        command.Parameters.AddWithValue("@FatherNationality", fatherNationality);
                        command.Parameters.AddWithValue("@MotherNationality", motherNationality);
                        command.Parameters.AddWithValue("@DateIssued", issuedDate);
                        command.Parameters.AddWithValue("@placeBirth", placeBirth);


                        try
                        {
                            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                            connection.Open();
                            command.ExecuteNonQuery();
                            updateCommand.ExecuteNonQuery();
                            

                            MessageBox.Show("You Have Registered Successfully!!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error inserting data: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void UC_BirthForm_Load(object sender, EventArgs e)
        {
            LoadRegions();
        }
    }
}
