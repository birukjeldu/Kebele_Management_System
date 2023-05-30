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

namespace Kebele_Management_System
{
    public partial class RegestarationForm : Form
    {
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
            else { errorProvider.SetError(phoneNumber, null); }

            //Email Validation
            if (!(v.isValidEmail(email.Text)) || v.isEmptyText(email.Text))
            {
                errorProvider.SetError(email, "Invalid Email");
                allValid= false;
            }
            else { errorProvider.SetError(email, null); }

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

            if (!(v.isValidName(occupation.Text)) || v.isEmptyText(occupation.Text))
            {
                errorProvider.SetError(occupation, "Invalid Name");
                allValid = false;
            }
            else { errorProvider.SetError(occupation, null); }

            //ComboBox Validation
            if (sex.SelectedItem == null || sex.SelectedIndex == -1) 
            {
                errorProvider.SetError(sex, "Cant't be empty Select something");
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

            if (allValid)
            {
                // If everything is Valid
                Console.WriteLine("Done!!! Corecct!!!!");
            }
        }
    }
}
