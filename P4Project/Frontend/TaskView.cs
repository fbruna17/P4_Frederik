using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4Project.Backend.Classes;
using MySql.Data.MySqlClient;
using P4Project.Exceptions;

namespace P4Project.Frontend
{
    public partial class TaskView : Form
    {
        // This form is used by both SMEs and Students. There are several different constructers, 
        // - that makes sure the view is made correctly, depending on who logs in, and what relation they have to the task.
        private TaskDetailed ThisTask { get; }

        // Used when an SME used this form:
        private SMELoggedIn ThisSME { get; }

        // Used when a student uses this form:
        private StudentLoggedIn ThisStudent { get; }
        private ApplicationBase ThisApplication { get; }

        //...................................................... CONSTRUCTORS: .........................................................

        #region Constructors:
        // This Constructor is used when an SME wants to view its own task:
        public TaskView(TaskDetailed task, SMELoggedIn sme)
        {
            InitializeComponent();
            ThisTask = task;
            ThisTask.GetApplicants();
            ThisTask.GetApplications();
            ThisSME = sme;
            InitializeDefault();
            if(ThisTask.StateID == 3)
            {
                InitializeFormForTaskInProgress();
            }
            else if (ThisTask.StateID == 4)
            {
                InitializeFormForTaskCompletedSME();
            }
            else
            {
                InitializeFormForSMEOwner();
            }

        }
        // This constructor is used when an SME is creating a new/editting a task. 
        // It is shown when all data has been inputted as a preview of the task:
        public TaskView(TaskDetailed task, SMELoggedIn sme, bool isUpdate)
        {
            InitializeComponent();
            ThisTask = task;
            ThisSME = sme;
            InitializeDefault();

            if (isUpdate) InitializeFormForUpdateTask();
            else InitializeFormForCreateNewTask();
        }

        // This constructor is used when a student looks up a task:
        public TaskView(TaskDetailed task, StudentLoggedIn student)
        {
            InitializeComponent();
            ThisTask = task;
            ThisStudent = student;
            InitializeDefault();
            bool alreadyApplied = false;
            // First we check is the student has already applied for this task: 
            if(ThisStudent.Applications.Count != 0)
            {
                foreach (ApplicationDetailed a in ThisStudent.Applications)
                {
                    if (a.TaskID == ThisTask.ID)
                    {   // Now we know that there has already been applied, and we have the relevant application:                        
                        ThisApplication = a;
                        InitializeFormForAppliedStudent();
                        break;
                    }
                }
            }
            // If the Student is the Assigned Student:
            if (ThisTask.AssignedStudentID == student.ID)
            {
                InitializeFormForAssignedStudent();
            }
            // If the student has not already applied, are not assigned, and the task is in Public state:
            else if(ThisTask.StateID == 2)
            {
                InitializeFormForRegStudent();
            }
        }

        #endregion

        //...................................................... INITIALIZERS: .........................................................
        // All functions used to set up the form. They are called depending on which constructer is used, 
        // - and the relation between the user and the task:

        #region Initializers:
        // This is always called, and simply put in the task data:
        private void InitializeDefault()
        {
            TaskNameLabel.Text = ThisTask.Title;
            CompanyNameLabel.Text = ThisTask.SMEName;
            TaskDescriptionBox.Text = ThisTask.Description;
            LocationLabel.Text = ThisTask.Location;
            ApplicationDeadline.Text = ThisTask.ApplicationDeadline.ToShortDateString();
            StartDate.Text = ThisTask.Startdate.ToShortDateString();
            CompletionDeadline.Text = ThisTask.EstCompletionDate.ToShortDateString();
            EstHours.Text = ThisTask.Hours.ToString();
            foreach(Skill skill in ThisTask.RequiredSkills)
            {
                RecSkills.Items.Add(skill.Name);
            }
        }

        // Student specific Initializers:
        #region Initializers - Student:

        private void InitializeFormForRegStudent()
        {
            RecScoreLabel.Text = "Your Recommendation Score for this task: " + ThisTask.RecScore;
            Apply.Visible = true;
        }

        private void InitializeFormForAppliedStudent()
        {
            RecScoreLabel.Text = "Your Recommendation Score for this task: " + ThisTask.RecScore;
            UnApply.Visible = true;
        }

        private void InitializeFormForAssignedStudent() 
        {
            
        }

        #endregion

        // SME specific Initializers:
        #region Initializers - SME:

        // Default initializer for a Task in public or private state:
        private void InitializeFormForSMEOwner()
        {
            EditTask.Visible = true;
            ViewApplicants.Text = string.Format("View Applicants ({0})", ThisTask.Applications.Count);
            ViewApplicants.Visible = true;
            Back.Left = 278;
        }

        // When an SME is making a new task and getting the preview::
        private void InitializeFormForCreateNewTask()
        {
            Back.Visible = false;
            EditAgain.Visible = true;
            SubmitNew.Visible = true;
        }
        // When an SME is Updating a task:
        private void InitializeFormForUpdateTask()
        {
            Back.Visible = false;
            EditAgain.Visible = true;
            UpdateTaskSubmit.Visible = true;
        }

        // When an SME is looking up a completed task: 
        private void InitializeFormForTaskCompletedSME()
        {
            ViewAssignedStudent.Left = 435;
            Back.Left = 320;
            ViewAssignedStudent.Visible = true;
        }

        // When an SME is looking up a task in progress:
        private void InitializeFormForTaskInProgress()
        {
            ViewAssignedStudent.Visible = true;
            CompletBtn.Visible = true;
            Back.Left = 278;
        }


        #endregion

        #endregion

        //...................................................... BUTTON CLICKS: .........................................................
        // All Button clicks, seperate in Student, Universel and SME Specific:

        #region Buttons:

        // Universal Button (Back Button): 
        private void Back_Click(object sender, EventArgs e)
        {
            Close();  // Simply closes the form, and returns to whatever form the user was on before
        }

        // Buttons only visible/usable by students:
        #region Student Specific Buttons:
        
        // When a student clicks apply:
        private void Apply_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to apply for this task?", "Confirm Apply", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SQLControl sql = new SQLControl();
                    sql.PostApplication(ThisStudent.ID, ThisTask.ID, ThisTask.RecScore); // Her skal tilføjes REC SCORE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occured while trying to make your application for this task! Please try again later!" + ex.Message, "SQL Error");
                }
                MessageBox.Show("Application has been registered!");
                Close();
            }
        }

        // When a student is already applied, they have the option to UnApply:
        private void UnApply_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to unapply for this task?", "Confirm Apply", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SQLControl sql = new SQLControl();
                    sql.RemoveApplication(ThisApplication.ApplicationID);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occured while trying to remove this application! Please try again later!" + ex.Message, "SQL Error");
                }
                MessageBox.Show("Application has been removed!");
                Close();
            }
        }

        #endregion

        // Buttons only visible/usable by SMEs:
        #region SME Specific Buttons:

        // When an SME user wants to see the list of applicants:
        private void ViewApplicants_Click(object sender, EventArgs e)
        {
            StudentApplicantsView.Rows.Clear();
            ThisTask.GetApplicants();
            ThisTask.GetApplications();
            if(ThisTask.Applications.Count == 0)
            {
                MessageBox.Show("No Student has applied for this task yet.");
            }
            else
            {
                ApplicantBox.Visible = true;
                if (ThisTask.Applicants.Count != 0)
                {
                    foreach (StudentApplicant student in ThisTask.Applicants)
                    {   // These Lambda Expression goes through the list of applicants, and makes sure only the applications in "Pending" state is shown:
                        if (ThisTask.Applications.Any(a => a.StudentID == student.ID))
                        {
                            if (ThisTask.Applications.First(a => a.StudentID == student.ID).StateID == 1)
                            {
                                StudentApplicantsView.Rows.Add(student.MakeDataViewString());
                            }
                        }
                    }
                }
            }
        }

        // When an SME users clicks a student from the Applicant lists, and click "See Profile"
        private void SeeStudentProfile_Click(object sender, EventArgs e)
        {
            if (StudentApplicantsView.SelectedCells[0].Value == null)
            {
                MessageBox.Show("Please select a student");
            }
            else
            {
                DataGridViewRow row = StudentApplicantsView.CurrentCell.OwningRow;
                if (int.TryParse(row.Cells["StudentID"].Value.ToString(), out int studentID))
                {
                    ApplicationBase thisApplication = ThisTask.Applications.First(a => a.StudentID == studentID);
                    SQLControl sql = new SQLControl();
                    StudentDetailed student = sql.FetchStudentDetailed(studentID);
                    StudentProfileView studentProfile = new StudentProfileView(ThisSME, student, thisApplication);
                    Hide();
                    studentProfile.ShowDialog();
                    Show();
                }
            }
        }

        // When an SME selects a student from the applicants list and wants to reject this student for this task:
        private void RemoveStudentApplicant_Click(object sender, EventArgs e)
        {
            if (StudentApplicantsView.SelectedCells[0].Value == null)
            {
                MessageBox.Show("Please select a student");
            }
            else
            {
                DataGridViewRow row = StudentApplicantsView.CurrentCell.OwningRow;
                if (int.TryParse(row.Cells["StudentID"].Value.ToString(), out int studentID))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to reject this application?", "Confirm Apply", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            SQLControl sql = new SQLControl();
                            sql.RejectApplication(studentID, ThisTask.ID);
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("An error occured while trying to reject this application! Please try again later!" + ex.Message, "SQL Error");
                        }
                        MessageBox.Show("Application has been Rejected!");
                        UpdateApplicantView();
                        ViewApplicants.Text = string.Format("View Applicants ({0})", ThisTask.Applications.Count);
                    }
                }
            }
        }

        // Simply closes the GroupBox displaying the list of applicants:
        private void CloseApplicantView_Click(object sender, EventArgs e)
        {
            ApplicantBox.Visible = false;
        }

        // When an SME wants to Edit the current Task:       
        private void EditTask_Click(object sender, EventArgs e)
        {
            CreateTask editTask = new CreateTask(ThisTask, ThisSME);
            Close();
            editTask.ShowDialog();
        }

        // When a task is in Ongoing or Completed State The SME can see the student they have assigned for the task:
        private void ViewAssignedStudent_Click(object sender, EventArgs e)
        {
            SQLControl sql = new SQLControl();
            StudentDetailed student = sql.FetchStudentDetailed(ThisTask.AssignedStudentID);
            StudentProfileView studProfile = new StudentProfileView(ThisSME, student, ThisTask);
            Hide();
            studProfile.ShowDialog();
            Show();
        }

        // When a Task has an assigned student and the SME marks the Task as Completed:
        private void CompletBtn_Click(object sender, EventArgs e)
        {
            SQLControl sql = new SQLControl();
            DialogResult result = MessageBox.Show("Are you sure you want to mark this task as completed? This cannot be undone!", "Confirm Assign", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    sql.CompleteTask(ThisTask.ID);
                    MessageBox.Show("Task has been marked as completed!");
                    Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error uccored while marking this task as completed! Please try again later, or contact system administrators! Error message: " + ex.Message);
                }
            }
        }

        // When an SME confirms the new task, and submits the task:
        private void SubmitNew_Click(object sender, EventArgs e)
        {
            SQLControl sql = new SQLControl();
            try
            {
                sql.CreateNewTask(ThisTask);
                MessageBox.Show("The Task has succesfully been added to the database!");
                Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("An Error occures while trying to add this task to the database! Make sure all fields are filled our correctly! " +
                    "If this error keeps occuring, please contact system administrators!" + ex.Message);
            }
        }

        // When an SME confirms the updated task info and submits:
        private void UpdateTaskSubmit_Click(object sender, EventArgs e)
        {
            SQLControl sql = new SQLControl();
            try
            {
                sql.UpdateTask(ThisTask);
                MessageBox.Show("The Task has succesfully been updated!");
                Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An Error occures while trying to add this task to the database! Make sure all fields are filled our correctly! " +
                    "If this error keeps occuring, please contact system administrators!" + ex.Message);
            }
        }


        private void EditAgain_Click(object sender, EventArgs e)
        {
            CreateTask editTask = new CreateTask(ThisTask, ThisSME);
            Close();
            editTask.ShowDialog();
        }

        #endregion

        #endregion

        //...................................................... UPDATE FUNCTIONS: .........................................................
        // Function that updates the Applicant DataViewGrid (Kind of does the same as when the button is clicked):
        private void UpdateApplicantView()
        {
            StudentApplicantsView.Rows.Clear();
            ThisTask.GetApplicants();
            ThisTask.GetApplications();
            if(ThisTask.Applicants.Count != 0)
            {
                foreach (StudentApplicant student in ThisTask.Applicants)
                {   // This "Dobbelchecking" ensures no exception is thrown when a student has already been rejected for a task.
                    if(ThisTask.Applications.Any(a => a.StudentID == student.ID))
                    {
                        if (ThisTask.Applications.First(a => a.StudentID == student.ID).StateID == 1)
                        {
                            StudentApplicantsView.Rows.Add(student.MakeDataViewString());
                        }
                    }
                }
            }
        }



        //...................................................... MISS CLICKS REMOVE LATER .........................................................

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
