using Kebele_Management_System.User;
using MySql.Data.MySqlClient;
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
using MySql.Data.MySqlClient;

namespace Kebele_Management_System
{
    
        partial class UserDashboard : Form
    {
        private int userId;
        private Users.RegisteredUser signedUser;

        private string connectionString = "server=localhost;uid=root;pwd=root;database=kebele_management_system";

        public Users.RegisteredUser GetUserById(int userId)
        {
            Users.RegisteredUser user = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM users WHERE id = @Id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("id"));
                        string firstName = reader.GetString(reader.GetOrdinal("firstname"));
                        string fatherName = reader.GetString(reader.GetOrdinal("fathername"));
                        string grandFatherName = reader.GetString(reader.GetOrdinal("grandfathername"));
                        string email = reader.GetString(reader.GetOrdinal("email"));
                        string phone = reader.GetString(reader.GetOrdinal("phone"));
                        string sex = reader.GetString(reader.GetOrdinal("Sex"));
                        string password = reader.GetString(reader.GetOrdinal("Password"));
                        int age = reader.GetInt32(reader.GetOrdinal("age"));
                        string bloodType = reader.GetString(reader.GetOrdinal("bloodtype"));
                        string nationality = reader.GetString(reader.GetOrdinal("nationality"));
                        string occupation = reader.GetString(reader.GetOrdinal("occupation"));
                        string dateOfBirth = reader.GetString(reader.GetOrdinal("dateofbirth"));
                        string maritalStatus = reader.GetString(reader.GetOrdinal("maritalstatus"));
                        string approvedDate = reader.GetString(reader.GetOrdinal("approveddate"));
                        string expireDate = reader.GetString(reader.GetOrdinal("expirationdate"));
                        string region = reader.GetString(reader.GetOrdinal("region"));
                        string zone = reader.GetString(reader.GetOrdinal("zone"));
                        string woreda = reader.GetString(reader.GetOrdinal("woreda"));
                        string kebele = reader.GetString(reader.GetOrdinal("kebele"));
                        int houseNumber = reader.GetInt32(reader.GetOrdinal("house_number"));
                        byte[] image = (byte[])reader["image"];

                        user = new Users.RegisteredUser(id, firstName, fatherName, grandFatherName, email, phone, sex, password, age, bloodType, nationality, occupation, dateOfBirth, maritalStatus, approvedDate, expireDate, region, zone, woreda, kebele, houseNumber, image);
                    }

                    reader.Close();
                }
            }

            return user;
        }

        public UserDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            signedUser = GetUserById(userId);
            UC_Home home = new UC_Home(signedUser);
            addUserControl(home);
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        
        private void IdButton_Click(object sender, EventArgs e)
        {
            UC_Id uC = new UC_Id(signedUser);
            addUserControl(uC);
        }

        private void birthButton_Click(object sender, EventArgs e)
        {
            UC_BirthCert birth = new UC_BirthCert(signedUser);
            addUserControl(birth);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home(signedUser);
            addUserControl(home);
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            login_page login = new login_page();
            login.Owner = null;
            login.Show();
            this.Close();
        }
    }
}
