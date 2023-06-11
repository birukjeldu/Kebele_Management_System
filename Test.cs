using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Kebele_Management_System
{
    public partial class Test : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;pwd=root;database=kebele_management_system";

        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            LoadRegions();
        }
        private void LoadRegions()
        {
            try
            {
                string query = "SELECT DISTINCT Region FROM Location";
                DataTable dt = GetData(query);
                if (dt != null)
                {
                    regionComboBox.DataSource = dt;
                    regionComboBox.DisplayMember = "Region";
                    regionComboBox.ValueMember = "Region";
                    regionComboBox.SelectedIndex = -1;
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
                    zoneComboBox.DataSource = dt;
                    zoneComboBox.DisplayMember = "Zone";
                    zoneComboBox.ValueMember = "Zone";
                    zoneComboBox.SelectedIndex = -1;
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
                    weredaComboBox.DataSource = dt;
                    weredaComboBox.DisplayMember = "Wereda";
                    weredaComboBox.ValueMember = "Wereda";
                    weredaComboBox.SelectedIndex = -1;
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
                    kebeleComboBox.DataSource = dt;
                    kebeleComboBox.DisplayMember = "Kebele";
                    kebeleComboBox.ValueMember = "Kebele";
                    kebeleComboBox.SelectedIndex = -1;
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
            if (regionComboBox.SelectedIndex != -1)
            {
                string selectedRegion = regionComboBox.SelectedValue.ToString();
                LoadZones(selectedRegion);
            }
        }

        private void zoneComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (zoneComboBox.SelectedIndex != -1)
            {
                string selectedZone = zoneComboBox.SelectedValue.ToString();
                LoadWeredas(selectedZone);
            }
        }

        private void weredaComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (weredaComboBox.SelectedIndex != -1)
            {
                string selectedWereda = weredaComboBox.SelectedValue.ToString();
                LoadKebeles(selectedWereda);
            }
        }

        private void kebeleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
