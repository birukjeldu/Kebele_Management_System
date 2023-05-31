using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Wpf.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data.MySqlClient;
using MessageBox = System.Windows.Forms.MessageBox;
using System.IO;

namespace Kebele_Management_System
{
    public partial class RegestarationForm : Form
    {
        //Creating a connnectin to the database 
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;pwd=root;database=kebele_management_system";

        public RegestarationForm()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Validator v = new Validator();
            bool allValid = true;
            
            //Phone number Validation
            if (!(v.isValidPhoneNumber(phoneNumber.Text)) || v.isEmptyText(phoneNumber.Text)) {
                errorProvider.SetError(phoneNumber, "Invalid Phone Number Format Use(+251-----)");
                allValid = false;
            }
            else 
            {
                bool phoneExists = v.PhoneNumberExists(phoneNumber.Text);
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
            if (!(v.isValidEmail(email.Text)) || v.isEmptyText(email.Text))
            {
                errorProvider.SetError(email, "Invalid Email");
                allValid= false;
            }
            else 
            {
                bool emailExists = v.EmailExists(email.Text);
                if (emailExists)
                {
                    errorProvider.SetError(email, "Email Already Exists");
                    allValid = false;
                }
                else
                {
                    errorProvider.SetError(email, null);
                }
                
            }

           

            //Password Validation
            if (v.isEmptyText(password.Text))
            {
                errorProvider.SetError(password, "Enter Password");
                allValid = false;
            }
            else { errorProvider.SetError(password, null); }

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
            if (sex.SelectedItem == null || sex.SelectedIndex == -1) 
            {
                errorProvider.SetError(sex, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(sex, null); }

            if (occupation_CB.SelectedItem == null || occupation_CB.SelectedIndex == -1)
            {
                errorProvider.SetError(occupation_CB, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(sex, null); }

            if (nationality.SelectedItem == null || nationality.SelectedIndex == -1)
            {
                errorProvider.SetError(nationality, "Cant't be empty Select something");
                allValid = false;
            }
            else { errorProvider.SetError(nationality, null); }

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


            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                // Upload the image to the database
                //UploadImage(selectedImagePath);
                errorProvider.SetError(idPicture, null);
            }
            else
            {
                allValid = false;
                errorProvider.SetError(uploadImage_btn, "Please select an image before registering.");
            }

            if (allValid)
            {
                DateTime today = DateTime.Today;
                int year = today.Year;
                int month = today.Month;
                int day = today.Day;
                string firstname, fathername, grandfathername, emaill, phone, sexDB, passwordDB, bloodtype;
                string nationalityDB, occup, dateofbirth, maritalstatus, region, zone, woreda, kebele, image;
                string issuedate;

                firstname = firstName_TB.Text;
                fathername = fatherName_TB.Text;
                grandfathername = grandFatherName_TB.Text;
                emaill = email.Text;
                phone = phoneNumber.Text;
                if (martial_married.Checked) { maritalstatus = martial_married.Text; }
                if (martial_single.Checked) { maritalstatus = martial_single.Text; }
                passwordDB = password.Text;
                bloodtype = bloodType_CB.SelectedText;
                sexDB = sex.SelectedText;
                nationalityDB = nationality.SelectedText;
                occup = occupation_CB.SelectedText;
                int age = (int)(year - birth_year.Value);
                dateofbirth = birth_day.Value.ToString() + '/' + birth_month.Value.ToString() + '/' + birth_year.Value.ToString();
                region = region_CB.SelectedText;
                zone = zone_CB.SelectedText;
                woreda = wereda_CB.SelectedText;
                kebele = kebele_CB.SelectedText;
                issuedate = day.ToString() + '/' + month.ToString() + '/' + year.ToString();
                UploadImage(selectedImagePath);
                // If everything is Valid
                Console.WriteLine("Done!!! Corecct!!!!");
                
            }
        }

        private void RegestarationForm_Load(object sender, EventArgs e)
        {
            LoadRegions();
        }

        // This code is used to populate the ComboBox with region, wereda , zone and kebele info based on the user selecion
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

        private void LoadKebeles(string selectedWereda)
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
                    kebele_CB.SelectedIndex = -1;
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

        private void weredaComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (wereda_CB.SelectedIndex != -1)
            {
                string selectedWereda = wereda_CB.SelectedValue.ToString();
                LoadKebeles(selectedWereda);
            }
        }


        //To Upload an image
        private string selectedImagePath;
        private void UploadImage(string imagePath)
        {
            try
            {
                byte[] imageBytes = File.ReadAllBytes(imagePath);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO test (image) VALUES (@Image)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Image", imageBytes);
                    command.ExecuteNonQuery();
                }

                //MessageBox.Show("Image uploaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading image: " + ex.Message);
            }
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
    }
}
