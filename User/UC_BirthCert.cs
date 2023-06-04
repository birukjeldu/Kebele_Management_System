using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Wpf.Toolkit.Panels;
using MySql.Data.MySqlClient;
using System.IO;

namespace Kebele_Management_System.User
{
    public partial class UC_BirthCert : UserControl
    {
        private string connectionString = "server=localhost;uid=root;pwd=root;database=kebele_management_system";
        Users.RegisteredUser signedUser;
        public UC_BirthCert(Users.RegisteredUser signedUser)
        {
            InitializeComponent();
            this.signedUser = signedUser;
            
        }

        private void UC_BirthCert_Load(object sender, EventArgs e)
        {
            UserCertInfo User = GetUserById(signedUser.Id);
            firstName_lbl.Text = signedUser.FirstName;
            fathersName_lbl.Text = signedUser.FatherName;
            grandFatherName_lbl.Text = signedUser.GrandFatherName;
            sex_lbl.Text = signedUser.Sex;
            birthDate_lbl.Text = signedUser.DateOfBirth;
            nationality_lbl.Text = signedUser.Nationality;
            motherFullName_lbl.Text = User.FullMotherName;
            motherNationality_lbl.Text = User.MotherNationality;
            fatherFullName_lbl.Text = fathersName_lbl.Text + " " + grandFatherName_lbl.Text + " " + User.GGFatherName;
            fatherNationality_lbl.Text = User.FatherNationality;
            placeBirth_lbl.Text = User.PlaceofBirth;
            dateIssued_lbl.Text = User.DateofIssue;
            using (MemoryStream ms = new MemoryStream(signedUser.Image))
            {
                // Create an Image object from the byte array
                Image imageObject = Image.FromStream(ms);

                // Assign the Image object to the PictureBox control
                profilepicture_box.Image = imageObject;

            }

        }

        public UserCertInfo GetUserById(int userId)
        {
            UserCertInfo userCert = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM birth_card WHERE user_id = @Id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("id"));
                        int user_id = reader.GetInt32(reader.GetOrdinal("user_id"));
                        string placeofbirth = reader.GetString(reader.GetOrdinal("placeofbirth"));
                        string fullfathername = reader.GetString(reader.GetOrdinal("fullfathername"));
                        string fullmothername = reader.GetString(reader.GetOrdinal("fullmothername"));
                        string fathernationality = reader.GetString(reader.GetOrdinal("fathernationality"));
                        string mothernationality = reader.GetString(reader.GetOrdinal("mothernationality"));
                        string dateofissue = reader.GetString(reader.GetOrdinal("dateofissue"));


                        userCert = new UserCertInfo(id, userId, placeofbirth, fullfathername, fullmothername, fathernationality, mothernationality, dateofissue);

                        
                    }

                    reader.Close();
                }
            }

            return userCert;
        }
    }
}
