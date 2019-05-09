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
    public partial class TestForm : Form
    {
        private string myConnectionString = "server=mysql33.unoeuro.com;uid=blo_store_dk;pwd=3pdaxzyt;database=blo_store_dk_db_wd";
        private MySqlConnection connection = null;

        private SQLControl SQL;

        public TestForm()
        {
            InitializeComponent();
            SQL = new SQLControl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SQL.Open();
                MessageBox.Show("Connection is open!");
                SQL.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(myConnectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Skill(SkillName,Category) VALUES(@SkillName,@Category)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@SkillName", "MySQLGOD");
                cmd.Parameters.AddWithValue("@Category", "Programming");
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
            try
            {
                connection = new MySqlConnection(myConnectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT SkillID,SkillName,Category FROM Skill";
                cmd.Prepare();

                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    string someStringFromColumnTwo = reader.GetString(2);
                    MessageBox.Show(someStringFromColumnZero + "," + someStringFromColumnOne + "," + someStringFromColumnTwo);
                }
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(myConnectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Student(Firstname,Lastname,Email) VALUES(@Firstname,@Lastname,@Email)";
                cmd.Prepare();

                string firstname = "Lasse";
                string lastname = "Hammer";
                string email = "Totalt@cool.dk";

                cmd.Parameters.AddWithValue("@Firstname", firstname);
                cmd.Parameters.AddWithValue("@Lastname", lastname);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Noice!");
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(myConnectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT Firstname,Lastname,Email FROM Student";
                cmd.Prepare();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    string someStringFromColumnTwo = reader.GetString(2);
                    MessageBox.Show(someStringFromColumnZero + "," + someStringFromColumnOne + "," + someStringFromColumnTwo);
                }
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var stud = new CreateStudProfileV2();
            stud.ShowDialog();
            this.Show();
        }

        private void SMERegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sme = new RegisterSMEProfile();
            sme.ShowDialog();
            Show();
        }
    }
}
