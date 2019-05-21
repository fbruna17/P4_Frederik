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
using System.Net;
using System.IO;

namespace P4Project.Frontend
{
    public partial class StudentLandingPage : Form
    {

        public StudentLoggedIn ThisStudent { get; private set; }
        public StudentLandingPage(StudentLoggedIn thisStudent)
        {
            InitializeComponent();
            ThisStudent = thisStudent;
            SetupForm();
            CheckProfileInfo();
        }
        // Denne funktion bruges til at sikre at LandingPage er up to date med det der er i databasen:
        private void UpdateStudent()
        {
            ThisStudent = ThisStudent.UpdateSessionData();
            RecommendedTasks.Rows.Clear();
            ApplicationViewGrid.Rows.Clear();
            AssignedTaskGridView.Rows.Clear();
            SetupForm();
        }

        private void SetupForm()
        {
            ShowStudentEmailLabel.Text = ThisStudent.Email;
            ShowStudentNameLabel.Text = ThisStudent.FirstName + " " + ThisStudent.LastName;
            SetupImage();

            // De recommended tasks vises:
            foreach (TaskRecommend task in ThisStudent.RecTasks)
            {
                RecommendedTasks.Rows.Add(task.MakeDataViewGrid());
            }
            // De eksisterende Applications vises:         
            if (ThisStudent.Applications.Count != 0)
            {
                foreach (ApplicationDetailed app in ThisStudent.Applications)
                {
                    ApplicationViewGrid.Rows.Add(app.MakeDataViewGridStudent());
                }
            }
            // If this student has any assigned tasks in Progress, theese will be shown:
            if(ThisStudent.AssignedTasks.Count != 0)
            {
                bool visible = false;
                foreach(TaskAssigned task in ThisStudent.AssignedTasks)
                {
                    if(task.StateID == 3)
                    {
                        AssignedTaskGridView.Rows.Add(task.MakeDataViewString());
                        visible = true;
                    }
                }
                AssignedTasksBox.Visible = visible;
            }
        }

        // Void function that checks key values on the profile and informs the user:
        private void CheckProfileInfo()
        {
            string item = "";
            // Checking description:
            if (ThisStudent.Description == "")
            {
                item = item + "Your profile currently lacks a description." + "\n";
            }
            // Checking skills:
            if (ThisStudent.Skills.Count == 0)
            {
                item = item + "Your profile currently has no skills connected." + "\n";
            }
            // Checking education:
            if (ThisStudent.Education == "")
            {
                item = item + "Your profile currently has no education connected." + "\n";
            }
            // Checking assigned tasks:
            if (ThisStudent.AssignedTasks.Count < 0)
            {
                item = item + "You have been assigned for a task!." + "\n";
            }
            if(item != "") MessageBox.Show(item);
        }
       
        private void ViewRecTask_Click(object sender, EventArgs e)
        {
            // Der skal foretages SQL kald:     !!! Burde måske gøres til Funktion i SQL Control!:
            SQLControl sql = new SQLControl();
            // Vi kender Taskname da det står i tabelen:
            string taskname = RecommendedTasks.SelectedCells[0].Value.ToString();
            // Ud fra TaskName finder vi en task:
            TaskRecommend tTask = ThisStudent.RecTasks.Single(t => t.Title == taskname);
            // Hvor vi bruger ID´et til at finde task detailed:
            TaskDetailed thisTask = sql.FetchTaskDetailed(tTask.ID);
            Hide();
            var tView = new TaskView(thisTask, ThisStudent);
            tView.ShowDialog();
            Show();
            UpdateStudent();
        }

        public void SetupImage()
        {
            var ProfilePicture = ThisStudent.ProfilePicture;
            StudentPictureBox.ImageLocation = ProfilePicture;
        }

        private void SeeApplication_Click(object sender, EventArgs e)
        {
            // Der skal foretages SQL kald:     !!! Burde måske gøres til Funktion i SQL Control!:
            SQLControl sql = new SQLControl();
            string taskTitle = ApplicationViewGrid.SelectedCells[0].Value.ToString();
            ApplicationDetailed app = ThisStudent.Applications.Single(t => t.TaskTitle == taskTitle);
            TaskDetailed thisTask = sql.FetchTaskDetailed(app.TaskID);

            Hide();
            var tView = new TaskView(thisTask, ThisStudent);
            tView.ShowDialog();
            Show();
            UpdateStudent();
        }

        private void ViewAssignedTask_Click(object sender, EventArgs e)
        {
            SQLControl sql = new SQLControl();
            string taskTitle = AssignedTaskGridView.SelectedCells[0].Value.ToString();
            TaskAssigned task = ThisStudent.AssignedTasks.Single(t => t.Title == taskTitle);
            TaskDetailed thisTask = sql.FetchTaskDetailed(task.ID);

            Hide();
            var tView = new TaskView(thisTask, ThisStudent);
            tView.ShowDialog();
            Show();
            UpdateStudent();
        }

        private void ViewProfile_Click(object sender, EventArgs e)
        {
            StudentProfileView profileView = new StudentProfileView(ThisStudent);
            Hide();
            profileView.ShowDialog();
            UpdateStudent();
            Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new Search();
            search.ShowDialog();
        }

        // DELETE
        private void ApplicationView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
