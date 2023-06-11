using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kebele_Management_System.User
{
    public partial class UC_Id : UserControl
    {
        Users.RegisteredUser signedUser;
        public UC_Id(Users.RegisteredUser signedUser)
        {
            InitializeComponent();
            this.signedUser = signedUser;
            string barcode = signedUser.ToString();
            try
            {
                Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                barCodePic.Image = brCode.Draw(barcode, barCodePic.Height);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            string fullname = signedUser.FirstName + " " + signedUser.FatherName + " " + signedUser.GrandFatherName;
            fullname_lbl.Text = fullname;
            dateofbirth_lbl.Text = signedUser.DateOfBirth;
            bloodType_lbl.Text = signedUser.BloodType;
            nationality_lbl.Text = signedUser.Nationality;
            sex_lbl.Text = signedUser.Sex;
            expiredate_lbl.Text = signedUser.ExpireDate;
            region_lbl.Text = signedUser.Region;
            phonenumber_lbl.Text = signedUser.Phone;
            id_lbl.Text = signedUser.Id.ToString();
            using (MemoryStream ms = new MemoryStream(signedUser.Image))
            {
                // Create an Image object from the byte array
                Image imageObject = Image.FromStream(ms);

                // Assign the Image object to the PictureBox control
                profilepicture_box.Image = imageObject;
                
            }

        }

        private void UC_Id_Load(object sender, EventArgs e)
        {
            
        }
    }
}
