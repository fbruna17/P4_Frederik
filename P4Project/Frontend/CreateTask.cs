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
        private List<string> SkillList;
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
            int taskid = 8;
            string title = txtTitle.Text;
            string description = txtTaskDesc.Text;
            string location = txtLocation.Text;
            DateTime startdate = StartDeadlinePicker.Value;
            DateTime completion = CompDeadlinePicker.Value;
            //STARTER LEG
            string hours = txtHours.Text;
             
            
            //SLUTTER LEG

            try
            {
                InputValidation.VerifyTask(title, description, location);
                SQL.CreateNewTask(taskid, SME.ID, title, description, location, startdate, completion);
                MessageBox.Show("Your task has been added to the database.");
                this.Hide();
            }
            catch(InvalidTaskTitleException ex)
            {
                MessageBox.Show("Please enter a valid title input. Your input was: " + ex.input);
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

        private void AddSkillButton_Click(object sender, EventArgs e)
        {
            
            SkillList = SQL.FetchAllSkills();
            foreach (string s in SkillList)
            {
                AddSkillReqList.Items.Add(s);
            }
            AddSkillReqList.Show();
            btnConfirmSkillAdd.Show();
        }

        private void btnConfirmSkillAdd_Click(object sender, EventArgs e)
        {
            foreach (string itemChecked in AddSkillReqList.CheckedItems)
            {
                ReqSkillList.Items.Add(itemChecked);
            }
            AddSkillReqList.Hide();
            btnConfirmSkillAdd.Hide();
        }

        private void ClearSkillsButton_Click(object sender, EventArgs e)
        {
            ReqSkillList.Items.Clear();
        }
    }
}
