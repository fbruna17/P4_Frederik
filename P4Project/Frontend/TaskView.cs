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
        private TaskDetailed ThisTask { get; }
        private SMELoggedIn ThisSME { get; }

        // Dise bruges når en student ser en task:
        private StudentLoggedIn ThisStudent { get; }
        private ApplicationBase ThisApplication { get; }

        // Denne construkter bruges til når en SME bruger vil se en af sine egne tasks:
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
        // Denne bruges til når en Student ser en task:
        public TaskView(TaskDetailed task, StudentLoggedIn student)
        {
            InitializeComponent();
            ThisTask = task;
            ThisStudent = student;
            InitializeDefault();
            bool alreadyApplied = false;
            // Først checkes der om den givne Student har applied: 
            if(ThisStudent.Applications.Count != 0)
            {
                foreach (ApplicationDetailed a in ThisStudent.Applications)
                {
                    if (a.TaskID == ThisTask.ID)
                    {
                        alreadyApplied = true;
                        ThisApplication = a;
                        break;
                    }
                }
            }

            // Hvis studenten er assigned:
            if (ThisTask.AssignedStudentID == student.ID)
            {
                InitializeFormForAssignedStudent();
            }
            // Hvis en student allerede har applied for den givne task:
            else if (alreadyApplied)
            {
                InitializeFormForAppliedStudent();
            }
            // Hvis ikke studenten er assigned, og tasken er public:
            else if(ThisTask.StateID == 2)
            {
                InitializeFormForRegStudent();
            }
        }

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

        private void InitializeFormForSMEOwner()
        {
            EditTask.Visible = true;
            ViewApplicants.Text = string.Format("View Applicants ({0})", ThisTask.Applicants.Count);
            ViewApplicants.Visible = true;
            Back.Left = 278;
        }

        private void InitializeFormForAssignedStudent()
        {

        }

        private void InitializeFormForRegStudent()
        {
            Apply.Visible = true;
        }

        private void InitializeFormForAppliedStudent()
        {
            UnApply.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ViewApplicants_Click(object sender, EventArgs e)
        {
            StudentApplicantsView.Rows.Clear();
            ThisTask.GetApplicants();
            ApplicantBox.Visible = true;
            foreach(StudentApplicant student in ThisTask.Applicants)
            {   // Dette lambda udtryk går listen af applications igennem, og sikrer at kun applications der er pending vises:
                if(ThisTask.Applications.First(a => a.StudentID == student.ID).StateID == 1)
                {
                    StudentApplicantsView.Rows.Add(student.MakeDataViewString());
                }
            }
        }

        // Function that updates the Applicant data view grid:
        private void UpdateApplicantView()
        {
            StudentApplicantsView.Rows.Clear();
            ThisTask.GetApplicants();
            ThisTask.GetApplications();
            foreach (StudentApplicant student in ThisTask.Applicants)
            {   // Dette lambda udtryk går listen af applications igennem, og sikrer at kun applications der er pending vises:
                if (ThisTask.Applications.First(a => a.StudentID == student.ID).StateID == 1)
                {
                    StudentApplicantsView.Rows.Add(student.MakeDataViewString());
                }
            }
        }

        private void EditTask_Click(object sender, EventArgs e)
        {
            CreateTask editTask = new CreateTask(ThisTask, ThisSME);
            Close();
            editTask.ShowDialog();
            // Når Edit Task er færdig, skal denne form kaldes igen med den nye Task, så info er opdateret uden databasekald!
        }

        private void Apply_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to apply for this task?", "Confirm Apply", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                try
                {
                    SQLControl sql = new SQLControl();
                    sql.PostApplication(ThisStudent.ID, ThisTask.ID, 5); // Her skal tilføjes REC SCORE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                }
                catch(MySqlException ex)
                {                    
                    MessageBox.Show("An error occured while trying to make your application for this task! Please try again later!" + ex.Message, "SQL Error");
                }
                MessageBox.Show("Application has been registered!");
                Close();
            }
        }

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

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseApplicantView_Click(object sender, EventArgs e)
        {
            ApplicantBox.Visible = false;
        }

        private void SeeStudentProfile_Click(object sender, EventArgs e)
        {
            if (StudentApplicantsView.SelectedCells[0].Value == null)
            {
                MessageBox.Show("Please select a student");
            }
            else
            {
                DataGridViewRow row = StudentApplicantsView.CurrentCell.OwningRow;
                if(int.TryParse(row.Cells["StudentID"].Value.ToString(), out int studentID))
                {
                    SQLControl sql = new SQLControl();
                    StudentDetailed student = sql.FetchStudentDetailed(studentID);
                    // Her skal vi have Student Profile View Lavet, som skal tage imod en task og en detailed student. Der skal så tilføjes en knap der hedder assign studen/Reject Student.

                }
            }
        }

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
                    }
                }
            }

        }
    }
}
