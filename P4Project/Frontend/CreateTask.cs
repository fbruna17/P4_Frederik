using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4Project.Exceptions;
using MySql.Data.MySqlClient;

namespace P4Project.Frontend
{
    public partial class CreateTask : Form
    {
        #region Instance Variables
        private SQLControl SQL;
        private UserInputValidation InputValidation;
        SMEBase SME;
        #endregion

        #region Constructor(s)
        public CreateTask(SMEBase sme)
        {
            InitializeComponent();
            SQL = new SQLControl();
            InputValidation = new UserInputValidation();
            SME = sme;
        }
        #endregion

        #region Load
        private void CreateTask_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitTask_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtTaskDesc.Text;
            string location = txtLocation.Text;

            try
            {
                InputValidation.VerifyTask(title, description, location);
                SQL.CreateNewTask(SME.ID, title, description, location);
                MessageBox.Show("Your task has been added to the database.");
                this.Hide();
            }
            catch(InvalidTaskTitleException ex)
            {
                MessageBox.Show("Please enter a valid tite input. Your input was: " + ex.input);
            }
            catch(InvalidTaskDescriptionExeption ex)
            {
                MessageBox.Show("Please enter a valid description input. Your input was: " + ex.input);
            }
            catch(InvalidTaskLocationException ex)
            {
                MessageBox.Show("Please enter a valid description input. Your input was: " + ex.input);
            }
        }
    }
}
