using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Kebele_Management_System
{
    
    internal class Validator
    {
        private string connectionString = "server=localhost;uid=root;pwd=root;database=kebele_management_system";
        //isValidName
        internal bool isValidName(string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(name)) return true;
            else return false;
        }
        //isEmptyText
        internal bool isEmptyText(string text) { 
            if(text == null || text == "") return true;
            else return false;
        }
        //isValidPhoneNumber
        internal bool isValidPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^+251[1-59]\d{8}$");
            if (regex.IsMatch(phoneNumber)) return true;
            else return false;
            
        }
        //isValidEmail
        internal bool isValidEmail(string email)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (regex.IsMatch(email)) return true;
            else return false;
        }

        internal bool PhoneNumberExists(string phoneNumber)
        {
            bool exists = false;
            

            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check in first table
                    string query1 = "SELECT COUNT(*) FROM waiting WHERE phone = @PhoneNumber";
                    MySqlCommand command1 = new MySqlCommand(query1, connection);
                    command1.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    int count1 = Convert.ToInt32(command1.ExecuteScalar());

                    // Check in second table
                    string query2 = "SELECT COUNT(*) FROM users WHERE phone = @PhoneNumber";
                    MySqlCommand command2 = new MySqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    int count2 = Convert.ToInt32(command2.ExecuteScalar());

                    exists = (count1 > 0) || (count2 > 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking phone number existence: " + ex.Message);
            }

            return exists;
        }

        internal bool PhoneNumberExists_edit(string phoneNumber, string id)
        {
            bool exists = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check in first table
                    string query1 = "SELECT COUNT(*) FROM waiting WHERE phone = @PhoneNumber AND id != @Id";
                    MySqlCommand command1 = new MySqlCommand(query1, connection);
                    command1.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command1.Parameters.AddWithValue("@Id", id);

                    int count1 = Convert.ToInt32(command1.ExecuteScalar());

                    // Check in second table
                    string query2 = "SELECT COUNT(*) FROM users WHERE phone = @PhoneNumber AND id != @Id";
                    MySqlCommand command2 = new MySqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command2.Parameters.AddWithValue("@Id", id);

                    int count2 = Convert.ToInt32(command2.ExecuteScalar());

                    exists = (count1 > 0) || (count2 > 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking phone number existence: " + ex.Message);
            }

            return exists;
        }


        internal bool EmailExists(string email)
        {
            bool exists = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check in first table
                    string query1 = "SELECT COUNT(*) FROM waiting WHERE email = @Email";
                    MySqlCommand command1 = new MySqlCommand(query1, connection);
                    command1.Parameters.AddWithValue("@Email", email);

                    int count1 = Convert.ToInt32(command1.ExecuteScalar());

                    // Check in second table
                    string query2 = "SELECT COUNT(*) FROM users WHERE email = @Email";
                    MySqlCommand command2 = new MySqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@Email", email);

                    int count2 = Convert.ToInt32(command2.ExecuteScalar());

                    exists = (count1 > 0) || (count2 > 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking email existence: " + ex.Message);
            }

            return exists;
        }

        internal bool EmailExists_edit(string email, string id)
        {
            bool exists = false;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check in first table
                    string query1 = "SELECT COUNT(*) FROM waiting WHERE email = @Email AND id != @Id";
                    MySqlCommand command1 = new MySqlCommand(query1, connection);
                    command1.Parameters.AddWithValue("@Email", email);
                    command1.Parameters.AddWithValue("@Id", id);

                    int count1 = Convert.ToInt32(command1.ExecuteScalar());

                    // Check in second table
                    string query2 = "SELECT COUNT(*) FROM users WHERE email = @Email AND id != @Id";
                    MySqlCommand command2 = new MySqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@Email", email);
                    command2.Parameters.AddWithValue("@Id", id);

                    int count2 = Convert.ToInt32(command2.ExecuteScalar());

                    exists = (count1 > 0) || (count2 > 0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking email existence: " + ex.Message);
            }

            return exists;
        }



    }
}
