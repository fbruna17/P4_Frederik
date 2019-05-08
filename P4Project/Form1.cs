using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=mysql33.unoeuro.com;uid=blo_store_dk;pwd=3pdaxzyt;database=blo_store_dk_db_wd";

            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                MessageBox.Show("Connection Open  !");
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=mysql33.unoeuro.com;uid=blo_store_dk;pwd=3pdaxzyt;database=blo_store_dk_db_wd";
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(myConnectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Skill(SkillName) VALUES(@SkillName)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@SkillName", "MySQLGOD");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Noice!");
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=mysql33.unoeuro.com;uid=blo_store_dk;pwd=3pdaxzyt;database=blo_store_dk_db_wd";
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(myConnectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT SkillName,SkillID FROM Skill";
                cmd.Prepare();

                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    MessageBox.Show(someStringFromColumnZero + "," + someStringFromColumnOne);
                }
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
