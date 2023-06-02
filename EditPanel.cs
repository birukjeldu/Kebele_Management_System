using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        //Creating a connnectin to the database 
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

            using (MemoryStream ms = new MemoryStream(image))
            {
                // Create an Image object from the byte array
                Image imageObject = Image.FromStream(ms);

                // Assign the Image object to the PictureBox control
                idPicture.Image = imageObject;
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            Validator v = new Validator();
            bool allValid = true;

            //Phone number Validation
            if (!(v.isValidPhoneNumber(phoneNumber.Text)) || v.isEmptyText(phoneNumber.Text))
            {
                errorProvider.SetError(phoneNumber, "Invalid Phone Number Format Use(+251-----)");
                allValid = false;
            }
            else
            {
                bool phoneExists = v.PhoneNumberExists_edit(phoneNumber.Text, id);
                if (phoneExists)
                {
                    errorProvider.SetError(phoneNumber, "Phone Number Already Exists");
                    allValid = false;
                }
                else
                {
                    errorProvider.SetError(phoneNumber, null);
                }
            }

            //Email Validation
            if (!(v.isValidEmail(email_TB.Text)) || v.isEmptyText(email_TB.Text))
            {
                errorProvider.SetError(email_TB, "Invalid Email");
                allValid = false;
            }
            else
            {
                bool emailExists = v.EmailExists_edit(email_TB.Text, id);
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

            // Name Validation isValidName
            if (!(v.isValidName(firstName_TB.Text)) || v.isEmptyText(firstName_TB.Text))
            {
                errorProvider.SetError(firstName_TB, "Invalid Name");
                allValid = false;
            }
            else { errorProvider.SetError(firstName_TB, null); }

            if (!(v.isValidName(fatherName_TB.Text)) || v.isEmptyText(fatherName_TB.Text))
            {
                errorProvider.SetError(fatherName_TB, "Invalid Name");
                allValid = false;
            }
            else { errorProvider.SetError(fatherName_TB, null); }

            if (!(v.isValidName(grandFatherName_TB.Text)) || v.isEmptyText(grandFatherName_TB.Text))
            {
                errorProvider.SetError(grandFatherName_TB, "Invalid Name");
                allValid = false;
            }
            else { errorProvider.SetError(grandFatherName_TB, null); }



            //ComboBox Validation occupation_CB
            if (sex_CB.SelectedItem == null || sex_CB.SelectedIndex == -1)
            {
                errorProvider.SetError(sex_CB, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(sex_CB, null); }

            if (occupation_CB.SelectedItem == null || occupation_CB.SelectedIndex == -1)
            {
                errorProvider.SetError(occupation_CB, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(occupation_CB, null); }

            if (nationality_CB.SelectedItem == null || nationality_CB.SelectedIndex == -1)
            {
                errorProvider.SetError(nationality_CB, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(nationality_CB, null); }

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

            if (kebele_CB.SelectedItem == null || kebele_CB.SelectedIndex == -1)
            {
                errorProvider.SetError(kebele_CB, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(kebele_CB, null); }

            if (bloodType_CB.SelectedItem == null || bloodType_CB.SelectedIndex == -1)
            {
                errorProvider.SetError(bloodType_CB, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(bloodType_CB, null); }

            //Radio Button Validation

            if (martial_married.Checked == false && martial_single.Checked == false)
            {
                errorProvider.SetError(maritalBox, "Please Select");
                allValid = false;
            }
            else { errorProvider.SetError(maritalBox, null); }


            //idPicture.Image = Image(image);

            if (allValid)
            {
                DateTime today = DateTime.Today;
                int year = today.Year;
                int month = today.Month;
                int day = today.Day;
                string firstname, fathername, grandfathername, emaill, phone, sexDB, passwordDB, bloodtype;
                string nationalityDB, occup, dateofbirth, maritalstatus = string.Empty, region, zone, woreda, kebele, image;
                string issuedate;
                int houseNumber;

                firstname = firstName_TB.Text;
                fathername = fatherName_TB.Text;
                grandfathername = grandFatherName_TB.Text;
                emaill = email_TB.Text;
                phone = phoneNumber.Text;
                if (martial_married.Checked) { maritalstatus = martial_married.Text; }
                if (martial_single.Checked) { maritalstatus = martial_single.Text; }
                passwordDB = password_TB.Text;
                bloodtype = bloodType_CB.SelectedItem.ToString();
                sexDB = sex_CB.SelectedItem.ToString();
                nationalityDB = nationality_CB.SelectedItem.ToString();
                occup = occupation_CB.SelectedItem.ToString();
                int age = (int)(year - birth_year.Value);
                dateofbirth = birth_day.Value.ToString() + '/' + birth_month.Value.ToString() + '/' + birth_year.Value.ToString();
                DataRowView selectedRow = (DataRowView)region_CB.SelectedItem;
                region = selectedRow["region"].ToString();
                DataRowView selectedRow1 = (DataRowView)zone_CB.SelectedItem;
                zone = selectedRow1["zone"].ToString();
                DataRowView selectedRow2 = (DataRowView)wereda_CB.SelectedItem;
                woreda = selectedRow2["wereda"].ToString();
                DataRowView selectedRow3 = (DataRowView)kebele_CB.SelectedItem;
                kebele = selectedRow3["kebele"].ToString();



                try
                {
                    // Establish a database connection
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Prepare the update query
                        string updateQuery = @"
            UPDATE [kebele_management_system].[users]
            SET
                [firstname] = @firstname,
                [fathername] = @fathername,
                [grandfathername] = @grandfathername,
                [email] = @email,
                [phone] = @phone,
                [sex] = @sex,
                [password] = @password,
                [age] = @age,
                [bloodtype] = @bloodtype,
                [nationality] = @nationality,
                [occupation] = @occupation,
                [dateofbirth] = @dateofbirth,
                [maritalstatus] = @maritalstatus,
                [region] = @region,
                [zone] = @zone,
                [woreda] = @woreda,
                [kebele] = @kebele,
                [image] = @image,
                [house_number] = @house_number
            WHERE [id] = @id";

                        // Create a SqlCommand object with the query and connection
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Set the parameter values
                            command.Parameters.AddWithValue("@firstname", firstname);
                            command.Parameters.AddWithValue("@fathername", fathername);
                            command.Parameters.AddWithValue("@grandfathername", grandfathername);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@phone", phone);
                            command.Parameters.AddWithValue("@sex", sex);
                            command.Parameters.AddWithValue("@password", password);
                            command.Parameters.AddWithValue("@age", age);
                            command.Parameters.AddWithValue("@bloodtype", bloodtype);
                            command.Parameters.AddWithValue("@nationality", nationality);
                            command.Parameters.AddWithValue("@occupation", occupation);
                            command.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                            command.Parameters.AddWithValue("@maritalstatus", maritalstatus);
                            command.Parameters.AddWithValue("@region", region);
                            command.Parameters.AddWithValue("@zone", zone);
                            command.Parameters.AddWithValue("@woreda", woreda);
                            command.Parameters.AddWithValue("@kebele", kebele);
                            command.Parameters.AddWithValue("@image", GetImageData(selectedImagePath));
                            command.Parameters.AddWithValue("@house_number", house_number);
                            command.Parameters.AddWithValue("@id", id);

                            // Execute the update query
                            command.ExecuteNonQuery();
                        }

                        // Close the database connection
                        connection.Close();
                    }

                    // Display a success message to the user
                    MessageBox.Show("Record updated successfully.");
                }
                catch (Exception ex)
                {
                    // Display an error message to the user
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
            

// Close the edit form

        private string selectedImagePath;

        private byte[] GetImageData(string imagePath)
        {
            byte[] imageData = null;
            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    imageData = File.ReadAllBytes(imagePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading image file: " + ex.Message);
                }
            }
            return imageData;
        }
        private void uploadImage_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg)|*.jpg;*.png;*.jpeg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;

                // Display the selected image
                idPicture.Image = Image.FromFile(selectedImagePath);
            }
        }


        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
