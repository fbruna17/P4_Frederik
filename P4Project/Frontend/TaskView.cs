﻿using System;
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
            if (ThisTask.SMEID == sme.ID)
            {
                InitializeFormForSMEOwner();
            }

        }
        // This constructor is used when an SME is creating a new/editting a task. 
        // It is shown when all data has been inputted as a preview of the task:
        public TaskView(SMELoggedIn sme, string ti)
        {
            // MAAAAAAAAAAANGLER!!!!!!
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
                        alreadyApplied = true;
                        ThisApplication = a;
                        break;
                    }
                }
            }
            // If the Student is the Assigned Student:
            if (ThisTask.AssignedStudentID == student.ID)
            {
                InitializeFormForAssignedStudent();
            }
            // For when a Student has already applied:
            else if (alreadyApplied)
            {
                InitializeFormForAppliedStudent();
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
            Apply.Visible = true;
        }

        private void InitializeFormForAppliedStudent()
        {
            UnApply.Visible = true;
        }

        // MANGLER !!! Skal måske åbne op for en PDF henter for further instructions?
        // Eller holde som den er, så der bare ikke er andre muligheder end "Back"...
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

        // Initializer for Task in progress:        MANGLER!!!!!!!

        // Initializer for Edit/Create Task (Displays the data, and gives Confirm/Cancel options:       MANGLER!!!!!!!

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
                    sql.PostApplication(ThisStudent.ID, ThisTask.ID, 5); // Her skal tilføjes REC SCORE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
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

        // When an SME users clicks a student from the Applicant lists, and click "See Profile"     !!!!!!!!!!! MANGLER NOGET!!!!!!!!!!
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
                    SQLControl sql = new SQLControl();
                    StudentDetailed student = sql.FetchStudentDetailed(studentID);
                    // Her skal vi have Student Profile View Lavet, som skal tage imod en task og en detailed student. Der skal så tilføjes en knap der hedder assign studen/Reject Student.

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

        // When an SME wants to Edit the current Task:                     !!!!!!!!!! MANGLER!!!!!!!!!!!!!!!!!
        private void EditTask_Click(object sender, EventArgs e)
        {
            CreateTask editTask = new CreateTask(ThisTask, ThisSME);
            Close();
            editTask.ShowDialog();
            // Når Edit Task er færdig, skal denne form kaldes igen med den nye Task, så info er opdateret uden databasekald!
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
