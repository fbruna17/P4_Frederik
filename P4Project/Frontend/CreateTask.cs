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
        private List<Skill> SkillList;
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

        }

        // Constructer for when its Edit a task:
        public CreateTask(TaskDetailed thisTask, SMELoggedIn thisSME)
        {

            InitializeComponent();
            SQL = new SQLControl();
            InputValidation = new UserInputValidation();
            ThisTask = thisTask;
            MessageBox.Show(ThisTask.ID.ToString());
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
            txtTaskDesc.Text = ThisTask.Description;
            txtLocation.Text = ThisTask.Location;
            txtHours.Text = ThisTask.Hours.ToString();
            if (ThisTask.StateID == 1) PrivateStateRadio.Checked = true;
            else if (ThisTask.StateID == 2) PublicStateRadio.Checked = true;
            else StateGroupBox.Visible = false;
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
            string title = txtTitle.Text;
            string description = txtTaskDesc.Text;
            string location = txtLocation.Text;
            if (int.TryParse(txtHours.Text, out int hours)) { }
            else MessageBox.Show("Please input a number that estimates the time needed to complete the task in Hours field!");
            // Default state is private:
            int stateid = 0;
            if (PrivateStateRadio.Checked == true) stateid = 1;
            else if (PublicStateRadio.Checked == true) stateid = 2;
            else stateid = ThisTask.StateID;


            List<Skill> SkillList = new List<Skill>();   // SKILL LIST MANGLER!!!!!!!!!!!!!!!!!!!
            // The Different Dates are saved:         NEEED VERIFICATION POSSIBLE FROM INPUTVALIDATION!!!!!!!!
            DateTime startdate = StartDeadlinePicker.Value.Date;
            DateTime applicationdeadline = ApplicationDeadlinePicker.Value.Date;
            DateTime completion = CompDeadlinePicker.Value.Date;
            
            try
            {
                // All Data is send through a simple verify check:
                InputValidation.VerifyTask(title, description, location);
                TaskDetailed newTask = new TaskDetailed(taskID, ThisSME, title, location, hours, description, startdate, applicationdeadline, completion, stateid, SkillList, 0);
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
            #endregion
        }

        // When an SME clicks to add skills to the required list:
        private void AddSkillButton_Click(object sender, EventArgs e)
        {
            
            SkillList = SQL.FetchALLSkills();
            foreach (Skill s in SkillList)
            {
                AddSkillReqList.Items.Add(s.Name);
            }
            AddSkillReqList.Show();
            btnConfirmSkillAdd.Show();
        }

        // When the required skill set is confirmed by the user:
        private void btnConfirmSkillAdd_Click(object sender, EventArgs e)
        {
            foreach (string itemChecked in AddSkillReqList.CheckedItems)
            {
                ReqSkillList.Items.Add(itemChecked);
            }
            AddSkillReqList.Hide();
            btnConfirmSkillAdd.Hide();
        }

        // If the user decides to clear the skill list:
        private void ClearSkillsButton_Click(object sender, EventArgs e)
        {
            ReqSkillList.Items.Clear();
        }

        #endregion



        #region Not Used, should be deleted:
        private void CreateTask_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
