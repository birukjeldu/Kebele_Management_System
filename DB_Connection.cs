using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kebele_Management_System
{
    internal class DB_Connection
    {
        public static void Mainjnn(String[] args) 
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=root;database=kebele_management_system";
                MySqlConnection con = new MySqlConnection(connstring);
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from staff ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Name: " + reader["first_name"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
