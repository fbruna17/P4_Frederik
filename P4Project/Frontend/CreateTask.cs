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
        private TaskDetailed ThisTask { get; set; }
        #endregion

        #region Constructor(s)
        public CreateTask(SMEBase sme)
        {
            InitializeComponent();
            SQL = new SQLControl();
            InputValidation = new UserInputValidation();
            SME = sme;
        }

        // Constructer til når der skal edites Task:
        public CreateTask(TaskDetailed thisTask, SMELoggedIn thisSME)
        {
            ThisTask = thisTask;
            SetUpEditTaskView();
        }
        #endregion

        #region Load
        private void CreateTask_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void SetUpEditTaskView()
        {
            txtTitle.Text = ThisTask.Title;
            txtTaskDesc.Text = ThisTask.Description;
            txtLocation.Text = ThisTask.Location;
            txtHours.Text = ThisTask.Hours.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitTask_Click(object sender, EventArgs e)
        {
            //TODO: taskid needs to be set automatically.
            string title = txtTitle.Text;
            string description = txtTaskDesc.Text;
            string location = txtLocation.Text;
            if (int.TryParse(txtHours.Text, out int hours)) { }
            else MessageBox.Show("Please input a number that estimates the time needed to complete the task in Hours field!");
            int stateid = 1;
            List<Skill> SkillList = new List<Skill>();
            DateTime startdate = StartDeadlinePicker.Value;
            DateTime applicationdeadline = ApplicationDeadlinePicker.Value;
            DateTime completion = CompDeadlinePicker.Value;


            TaskDetailed newtask = new TaskDetailed(0, SME, title, location, hours, description, startdate, applicationdeadline, completion, stateid, SkillList, 0);

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
            
            SkillList = SQL.FetchAllSkills();
            foreach (Skill s in SkillList)
            {
                AddSkillReqList.Items.Add(s.Name);
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
