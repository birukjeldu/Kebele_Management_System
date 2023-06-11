using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kebele_Management_System.User
{
    public partial class UC_Home : UserControl
    {
        Users.RegisteredUser signedUser;
        public UC_Home(Users.RegisteredUser signedUser)
        {
            InitializeComponent();
            this.signedUser = signedUser;
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            string fullName = signedUser.FirstName + " " + signedUser.FatherName + " " + signedUser.GrandFatherName;
            fullName_lbl.Text = fullName;
            age_lbl.Text = signedUser.Age.ToString();
            gender_lbl.Text = signedUser.Sex;
            occupation_lbl.Text = signedUser.Occupation;
            nationality_lbl.Text = signedUser.Nationality;
            region_lbl.Text = signedUser.Region;
            zone_lbl.Text = signedUser.Zone;
            wereda_lbl.Text = signedUser.Woreda;
            kebele_lbl.Text = signedUser.Kebele;
            approvedDate_lbl.Text = signedUser.ApprovedDate;
            expireDate_lbl.Text = signedUser.ExpireDate;
            bloodType_lbl.Text = signedUser.BloodType;
            maritalStatus_lbl.Text = signedUser.MaritalStatus;
            dateOfBirth_lbl.Text = signedUser.DateOfBirth;
            houseNumber_lbl.Text = signedUser.HouseNumber.ToString();
            id_lbl.Text = signedUser.Id.ToString();
            email_lbl.Text = signedUser.Email;
            phone_lbl.Text = signedUser.Phone;
            using (MemoryStream ms = new MemoryStream(signedUser.Image))
            {
                // Create an Image object from the byte array
                Image imageObject = Image.FromStream(ms);

                // Assign the Image object to the PictureBox control
                profielImage_box.Image = imageObject;
            }
        }
    }
}
