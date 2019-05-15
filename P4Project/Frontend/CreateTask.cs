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
using P4Project.Backend.Classes;

namespace P4Project.Frontend
{
    public partial class CreateTask : Form
    {
        #region Instance Variables
        private SQLControl SQL;
        private UserInputValidation InputValidation;
        SMEBase SME;
        private List<Skill> SkillList;
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

        private void btnSubmitTask_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtTaskDesc.Text;
            string location = txtLocation.Text;
            int hours = Convert.ToInt32(numHours.Value);
            int stateid = 1;

            SkillList = new List<Skill>();

            DateTime startdate = StartDeadlinePicker.Value;
            DateTime applicationdeadline = ApplicationDeadlinePicker.Value;
            DateTime completion = CompDeadlinePicker.Value;


            TaskDetailed newtask = new TaskDetailed(0, SME, title, location, hours, description, startdate, applicationdeadline, completion, stateid, SkillList);

            try
            {
                //InputValidation.VerifyTask(title, description, location);
                SQL.CreateNewTask(newtask);
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
            //Adding a list of skill id's:
            List<int> SkillInts = SQL.FetchAllSkills();

            //Inserting the name of the skill with a given id 'i' into the list:
            foreach (int i in SkillInts)
            {
                var skill = SQL.HammersFetchSkillInfo(i);
                AddSkillReqList.Items.Add(skill.Name);
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
