using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
    using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4Project.Backend.Classes;

namespace P4Project.Frontend
{
    public partial class StudentProfileView : Form
    {
        private StudentDetailed Student;
        private TaskBase Task;
        private string myConnectionString = "server=mysql33.unoeuro.com;uid=blo_store_dk;pwd=3pdaxzyt;database=blo_store_dk_db_wd";
        private MySqlConnection connection = null;

        private SQLControl SQL;


        public StudentProfileView()
        {
            //Student = student;

            InitializeComponent();
            WelcomeText.Text = "Welcome to your profile "; // + Student.FirstName + Student.LastName
        }

        private void StudentProfileView_Load(object sender, EventArgs e)
        {

        }

        private void StudentResumeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {
            NameLabel.Text = Student.FirstName;
        }

        private void StudentDescBox_TextChanged(object sender, EventArgs e)
        {
            StudentDescBox.Text = Student.Description;
        }


        private void EmailLabel_Click(object sender, EventArgs e)
        {
            EmailLabel.Text = Student.Email;
        }

        private void Education_Click(object sender, EventArgs e)
        {
            EducationLabel.Text = Student.Education;
        }


        private void FillSKills()
        {
            
        }
        private void StudSkillList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
