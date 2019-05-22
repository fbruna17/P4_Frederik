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
        SMELoggedIn ThisSME;
        private TaskDetailed ThisTask { get; set; }
        #endregion
        //...................................................... CONSTRUCTORS: .........................................................

        #region Constructor(s)
        // Regular Constructor for making a new task:
        public CreateTask(SMELoggedIn thisSME)
        {
            InitializeComponent();
            SQL = new SQLControl();
            InputValidation = new UserInputValidation();
            ThisSME = thisSME;
            SetUpNewTaskView();
        }

        // Constructer for when its Edit a task:
        public CreateTask(TaskDetailed thisTask, SMELoggedIn thisSME)
        {

            InitializeComponent();
            SQL = new SQLControl();
            InputValidation = new UserInputValidation();
            ThisTask = thisTask;
            ThisSME = thisSME;
            SetUpEditTaskView();
        }

        #endregion


        //...................................................... INITIALIZERS: .........................................................
        // All functions used to set up the form. They are called depending on which constructer is used, 

        #region Initializers:
        private void SetUpEditTaskView()
        {
            txtTitle.Text = ThisTask.Title;
            richTaskDesc.Text = ThisTask.Description;
            listLocation.SelectedItem = ThisTask.Location;
            UpDownHours.Text = ThisTask.Hours.ToString();
            ApplicationDeadlinePicker.Value = ThisTask.ApplicationDeadline;
            StartDeadlinePicker.Value = ThisTask.Startdate;
            CompDeadlinePicker.Value = ThisTask.EstCompletionDate;
            foreach(Skill skill in ThisTask.RequiredSkills)
            {
                SkillSetGrid.Rows.Add(skill.Name);
            }
            InitializeSkillEditing();
            if (ThisTask.StateID == 1) PrivateStateRadio.Checked = true;
            else if (ThisTask.StateID == 2) PublicStateRadio.Checked = true;
            else StateGroupBox.Visible = false;
        }

        private void SetUpNewTaskView()
        {
            listLocation.SelectedItem = "Aalborg";
            InitializeSkillEditing();
        }

        // Initialize SkillEditing:
        private void InitializeSkillEditing()
        {

            SkillDropDown.Items.Clear();

            SkillDropDown.Text = "Select a skill...";
            List<Skill> skills = SQL.FetchALLSkills();
            if(ThisTask != null)
            {
                foreach (Skill skill in ThisTask.RequiredSkills)
                {
                    skills.RemoveAll(a => a.ID == skill.ID);
                }
                if (ThisTask.StateID == 1) Delete.Visible = true;
            }
            foreach (Skill skill in skills)
            {
                SkillDropDown.Items.Add(skill.Name);
            }
        }

        #endregion
        //...................................................... BUTTON CLICKS: .........................................................

        #region Buttons:

        // This Button is for making a new task:
        private void btnSubmitTask_Click(object sender, EventArgs e)
        {

            // This Bool determines if its a submit for Create, or Update:
            bool isUpdate = true;
            int taskID = 0;
            if (ThisTask == null) isUpdate = false;
            else taskID = ThisTask.ID;


            // All variables are declared, and value from the form are stoed:
            // Assisgn the number of hours into the "NumberOfHours"
            int NumberOfHours = Decimal.ToInt32(UpDownHours.Value);

            string title = txtTitle.Text;
            string description = richTaskDesc.Text;
            string location = listLocation.Text;
            int hours = NumberOfHours;
            
            // Default state is private:
            int stateid = 0;
            if (PrivateStateRadio.Checked == true) stateid = 1;
            else if (PublicStateRadio.Checked == true && ApplicationDeadlinePicker.Value.Date > DateTime.Now) stateid = 2;
            else if (PublicStateRadio.Checked == true && ApplicationDeadlinePicker.Value.Date <= DateTime.Now)
            {
                stateid = 1;
                MessageBox.Show("Application Date was earlier than today, so the task is in private state!");
            }
            else stateid = ThisTask.StateID;
        
            // Skill List is made:
            List<Skill> SkillList = new List<Skill>();
            foreach(DataGridViewRow row in SkillSetGrid.Rows)
            {
                if(row.Cells[0].Value != null)
                {
                    SkillList.Add(SQL.FetchSkillInfoBasedOnName(row.Cells[0].Value.ToString()));
                }
            }

            DateTime startdate = StartDeadlinePicker.Value.Date;
            DateTime applicationdeadline = ApplicationDeadlinePicker.Value.Date;
            DateTime completion = CompDeadlinePicker.Value.Date;
            
            try
            {
                // All Data is send through a simple verify check:
                InputValidation.VerifyTask(title, description, applicationdeadline, startdate, completion, hours, isUpdate);
                TaskDetailed newTask = new TaskDetailed(taskID, ThisSME.ID, title, location, hours, description, startdate, applicationdeadline, completion, stateid, SkillList, 0);
                TaskView preview = new TaskView(newTask, ThisSME, isUpdate);
                Close();
                preview.ShowDialog();

            }
            #region Exception Catching:
            catch (InvalidTaskTitleException ex)
            {
                MessageBox.Show("Please enter a valid title input. Your input was: " + ex.input);
            }
            catch (InvalidTaskDescriptionExeption ex)
            {
                MessageBox.Show("Please enter a valid description input. Your input was: " + ex.input);
            }
            catch (InvalidTaskLocationException ex)
            {
                MessageBox.Show("Please enter a valid location input. Your input was: " + ex.input);
            }
            catch (InvalidTaskApplyDateException ex)
            {
                MessageBox.Show("Please enter a valid application date. Your input was: " + ex.input.ToShortDateString());
            }
            catch (InvalidTaskStartDateException ex)
            {
                MessageBox.Show("Please enter a valid start date. Your input was: " + ex.input.ToShortDateString());
            }
            catch (InvalidTaskDeadlineDateException ex)
            {
                MessageBox.Show("Please enter a valid deadline date. Your input was: " + ex.input.ToShortDateString());
            }
            catch (InvalidTaskHoursException ex)
            {
                MessageBox.Show("Please select a valid estimation of work hours. Your input was: " + ex.input);
            }
            #endregion
        }

        private void AddSkill_Click(object sender, EventArgs e)
        {
            if (SkillDropDown.SelectedItem != null)
            {
                SkillSetGrid.Rows.Add(SkillDropDown.SelectedItem.ToString());
            }
            else MessageBox.Show("Please select a skill from the dropdown to add.");
        }

        private void RemoveSkill_Click(object sender, EventArgs e)
        {
            SkillSetGrid.Rows.RemoveAt(SkillSetGrid.CurrentCell.RowIndex);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this task? This action cannot be undone!", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SQL.DeleteTask(ThisTask.ID);
                    MessageBox.Show("The Task has been deleted.");
                    Close();
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("An Error occured while trying to delete this task! Please contact system administrators! \n Error Message:" + ex.Message);
            }

        }
        #endregion
    }
}
