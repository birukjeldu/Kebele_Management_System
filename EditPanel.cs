using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;
using MySql.Data.MySqlClient;

namespace Kebele_Management_System
{
    
    public partial class EditPanel : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;pwd=root;database=kebele_management_system";


        // Declare variables to hold the edited values
        private string id;
        private string firstname;
        private string fathername;
        private string grandfathername;
        private string email;
        private string phone;
        private string sex;
        private string password;
        private string age;
        private string bloodtype;
        private string nationality;
        private string occupation;
        private string dateofbirth;
        private string maritalstatus;
        private string issuedate;
        private string region;
        private string zone;
        private string woreda;
        private string kebele;
        private byte[] image;
        public EditPanel(string id, string firstname, string fathername, string grandfathername, string email, string phone, string sex, string password, string age, string bloodtype, string nationality, string occupation, string dateofbirth, string maritalstatus, string issuedate, string region, string zone, string woreda, string kebele, byte[] image)
        {
            InitializeComponent();
            // Store the passed values in the variables
            this.id = id;
            this.firstname = firstname;
            this.fathername = fathername;
            this.grandfathername = grandfathername;
            this.email = email;
            this.phone = phone;
            this.sex = sex;
            this.password = password;
            this.age = age;
            this.bloodtype = bloodtype;
            this.nationality = nationality;
            this.occupation = occupation;
            this.dateofbirth = dateofbirth;
            this.maritalstatus = maritalstatus;
            this.issuedate = issuedate;
            this.region = region;
            this.zone = zone;
            this.woreda = woreda;
            this.kebele = kebele;
            this.image = image;

            // Set the initial values in the form controls
            firstName_TB.Text = firstname;
            fatherName_TB.Text = fathername;
            grandFatherName_TB.Text = grandfathername;
            email_TB.Text = email;
            phoneNumber.Text = phone;
            password_TB.Text = password;

            // Set the selected value for the blood type ComboBox
            bloodType_CB.SelectedItem = bloodtype;

            // Set the selected value for the sex RadioButton
            sex_CB.SelectedItem = sex;

            // Set the selected value for the nationality ComboBox
            nationality_CB.SelectedItem = nationality;

            // Set the selected value for the occupation ComboBox
            occupation_CB.SelectedItem = occupation;

            // Set the date of birth using DateTime.ParseExact method
            DateTime dob = DateTime.ParseExact(dateofbirth, "d/M/yyyy", CultureInfo.InvariantCulture); ;
            birth_day.Value = dob.Day;
            birth_month.Value = dob.Month;
            birth_year.Value = dob.Year;

            // Set the selected value for the region ComboBox
            region_CB.SelectedItem = region;

            // Set the selected value for the zone ComboBox
            zone_CB.SelectedItem = zone;

            // Set the selected value for the wereda ComboBox
            wereda_CB.SelectedItem = woreda;

            // Set the selected value for the kebele ComboBox
            kebele_CB.SelectedItem = kebele;


            // Set the selected value for the region ComboBox
            LoadRegions(region);

            // Set the selected value for the zone ComboBox
            LoadZones(region, zone);

            // Set the selected value for the wereda ComboBox
            LoadWeredas(zone, woreda);

            // Set the selected value for the kebele ComboBox
            LoadKebeles(woreda, kebele);
            // Set the selected value for the sex RadioButton
            if (maritalstatus == "Single")
            {
                martial_single.Checked = true;
            }
            else if (maritalstatus == "Married")
            {
                martial_married.Checked = true;
            }



        }

        private void EditPanel_Load(object sender, EventArgs e)
        {
            
            
        }
        // This code is used to populate the ComboBox with region, wereda , zone and kebele info based on the user selecion
        private void LoadRegions(string selectedRegion)
        {
            try
            {
                string query = "SELECT DISTINCT Region FROM Location";
                DataTable dt = GetData(query);

                region_CB.DataSource = dt;
                region_CB.DisplayMember = "Region";
                region_CB.ValueMember = "Region";

                // Select the specified region in the ComboBox
                if (!string.IsNullOrEmpty(selectedRegion))
                {
                    region_CB.SelectedIndex = region_CB.FindStringExact(selectedRegion);
                }
                else
                {
                    region_CB.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadZones(string selectedRegion, string selectedZone)
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

                    // Select the specified zone in the ComboBox
                    if (!string.IsNullOrEmpty(selectedZone))
                    {
                        zone_CB.SelectedIndex = zone_CB.FindStringExact(selectedZone);
                    }
                    else
                    {
                        zone_CB.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadWeredas(string selectedZone, string selectedWereda)
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

                    // Select the specified wereda in the ComboBox
                    if (!string.IsNullOrEmpty(selectedWereda))
                    {
                        wereda_CB.SelectedIndex = wereda_CB.FindStringExact(selectedWereda);
                    }
                    else
                    {
                        wereda_CB.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadKebeles(string selectedWereda, string selectedKebele)
        {
            try
            {
                string query = "SELECT DISTINCT Kebele FROM Location WHERE Wereda = @Wereda";
                DataTable dt = GetData(query, new MySqlParameter("@Wereda", selectedWereda));
                if (dt != null)
                {
                    kebele_CB.DataSource = dt;
                    kebele_CB.DisplayMember = "Kebele";
                    kebele_CB.ValueMember = "Kebele";

                    // Select the specified kebele in the ComboBox
                    if (!string.IsNullOrEmpty(selectedKebele))
                    {
                        kebele_CB.SelectedIndex = kebele_CB.FindStringExact(selectedKebele);
                    }
                    else
                    {
                        kebele_CB.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Pass the region value initially and call the LoadRegions function
        //string selectedRegion = region;
        //LoadRegions(region);

        private void region_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (region_CB.SelectedIndex != -1)
            {
                string selectedRegion = region_CB.SelectedValue.ToString();

                // Load the zones based on the selected region
                LoadZones(selectedRegion, "YourSelectedZone");
            }
        }

        private void zone_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zone_CB.SelectedIndex != -1)
            {
                string selectedZone = zone_CB.SelectedValue.ToString();

                // Load the weredas based on the selected zone
                LoadWeredas(selectedZone, "YourSelectedWereda");
            }
        }

        private void wereda_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wereda_CB.SelectedIndex != -1)
            {
                string selectedWereda = wereda_CB.SelectedValue.ToString();

                // Load the kebeles based on the selected wereda
                LoadKebeles(selectedWereda, "YourSelectedKebele");
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


    }
}
