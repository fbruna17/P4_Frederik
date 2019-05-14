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
using P4Project.Frontend;
using System.IO;

namespace P4Project.Frontend
{
    public partial class SMEProfileView : Form
    {
        private SMEBase SME;
        private string myConnectionString = "server=mysql33.unoeuro.com;uid=blo_store_dk;pwd=3pdaxzyt;database=blo_store_dk_db_wd";
        private MySqlConnection connection = null;

        private SQLControl SQL;

        public SMEProfileView(SMEBase SME)
        {
            InitializeComponent();
            this.SME = SME;
            companyName.Text = "Welcome to TaskDistributer2000 " + SME.Name;
            email.Text = SME.Email;
        }

        private void createTask_Click(object sender, EventArgs e)
        {
            var taskCreate = new CreateTask(SME);
            Hide();
            taskCreate.ShowDialog();
            Show();
        }

        private void btnShowPublicTask_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(myConnectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT Title,Description,Location FROM Task WHERE StateID='0';"; //&& SMEID
                cmd.Prepare();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < 2; i++)
                    {
                        string output = "";
                        string someStringFromColumnZero = reader.GetString(0);
                        string someStringFromColumnOne = reader.GetString(1);
                        string someStringFromColumnTwo = reader.GetString(2);
                        output = output + someStringFromColumnZero + " " + someStringFromColumnOne + " " + someStringFromColumnTwo + "\n";
                        SMETaskList.Items.Add(output);
                        i++;
                    }
                }
                //SMETaskList.Items.Clear();
                
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
