using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace P4Project
{
    public partial class CreateStudProfileV2 : Form
    {
        private SQLControl SQL;

        public CreateStudProfileV2()
        {
            InitializeComponent();
            SQL = new SQLControl();
        }

        private void basicSaveBut_Click(object sender, EventArgs e)
        {
            string firstname = FirstNameText.Text;
            string lastname = LastNameText.Text;
            string email = EmailText.Text;
            try
            {
                SQL.AddStudent(firstname, lastname, email);
                MessageBox.Show("Student has been added to the database!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
        }

        private void CreateStudProfileV2_Load(object sender, EventArgs e)
        {

        }
    }
}
