﻿using Kebele_Management_System.User;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace Kebele_Management_System
{
    
        partial class UserDashboard : Form
    {
        private int userId;
        private Users.RegisteredUser signedUser;
        private string connectionString = DB_Connection.connstring;


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
            //UC_BirthCert birth = new UC_BirthCert(signedUser);
            CheckBirthCardVerification(userId);
            //addUserControl(birth);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home(signedUser);
            addUserControl(home);
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            login_page login = new login_page();
            login.Owner = null;
            login.Show();
            this.Hide();
        }

        private void UserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void CheckBirthCardVerification(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT birthcardverification FROM users WHERE id = @Id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Set the parameter value for the user's ID
                    command.Parameters.AddWithValue("@Id", userId);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string birthCardVerification = Convert.ToString(result);

                        if (birthCardVerification != "false")
                        {
                            //If Birth Card is verified
                            UC_BirthCert birth = new UC_BirthCert(signedUser);
                            addUserControl(birth);
                        }
                        else
                        {
                            // Birth Card is not verified, show the panel for false condition
                            UC_BirthForm birthForm = new UC_BirthForm(userId);
                            addUserControl(birthForm);
                        }
                    }
                }
            }
        }
    }
}
