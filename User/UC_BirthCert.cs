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
                        bool birthCardVerification = Convert.ToBoolean(result);

                        if (birthCardVerification)
                        {
                            // Birth Card is verified, show the panel for true condition
                            panelTrue.Visible = true;
                            panelFalse.Visible = false;
                        }
                        else
                        {
                            // Birth Card is not verified, show the panel for false condition
                            panelTrue.Visible = false;
                            panelFalse.Visible = true;
                        }
                    }
                }
            }
        }


    }
}
