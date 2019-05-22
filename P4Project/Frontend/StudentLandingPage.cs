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
using System.Net;
using System.IO;

namespace P4Project.Frontend
{
    public partial class StudentLandingPage : Form
    {

        public StudentLoggedIn ThisStudent { get; private set; }


        #region Constructors
        public StudentLandingPage(StudentLoggedIn thisStudent)
        {
            InitializeComponent();
            ThisStudent = thisStudent;
            SetupForm();
            CheckProfileInfo();
        }
        #endregion

        #region Setup Profile and check for "Missing" information.
        private void SetupForm()
        {
            ShowStudentEmailLabel.Text = ThisStudent.Email;
            ShowStudentNameLabel.Text = ThisStudent.FirstName + " " + ThisStudent.LastName;
            var ProfilePicture = ThisStudent.ProfilePicture;
            StudentPictureBox.ImageLocation = ProfilePicture;

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
            if (ThisStudent.AssignedTasks.Count != 0)
            {
                bool visible = false;
                foreach (TaskAssigned task in ThisStudent.AssignedTasks)
                {
                    if (task.StateID == 3)
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
            if (item != "") MessageBox.Show(item);
        }
        #endregion

        #region Session Related
        private void UpdateStudent()
        {
            ThisStudent = ThisStudent.UpdateSessionData();
            RecommendedTasks.Rows.Clear();
            ApplicationViewGrid.Rows.Clear();
            AssignedTaskGridView.Rows.Clear();
            SetupForm();
        }
        #endregion

        #region Buttons
        private void ViewRecTask_Click(object sender, EventArgs e)
        {
            SQLControl sql = new SQLControl();
            // We know the Task title from the gridview:
            string taskname = RecommendedTasks.SelectedCells[0].Value.ToString();
            // We use that to find the task
            TaskRecommend tTask = ThisStudent.RecTasks.Single(t => t.Title == taskname);
            // and the ID to find a detailed task:
            TaskDetailed thisTask = sql.FetchTaskDetailed(tTask.ID);
            thisTask.RecScore = tTask.RecommendScore;
            Hide();
            var tView = new TaskView(thisTask, ThisStudent);
            tView.ShowDialog();
            Show();
            UpdateStudent();
        }

        private void SeeApplication_Click(object sender, EventArgs e)
        {
            SQLControl sql = new SQLControl();
            string taskTitle = ApplicationViewGrid.SelectedCells[0].Value.ToString();
            ApplicationDetailed app = ThisStudent.Applications.Single(t => t.TaskTitle == taskTitle);

            // If the application has been rejected, the user is informed and the application is deleted:
            if(app.StateID == 2)
            {
                MessageBox.Show("You have not been selected for this task. The application will be deleted.");
                sql.RemoveApplication(app.ApplicationID);

            }
            else
            {
                TaskDetailed thisTask = sql.FetchTaskDetailed(app.TaskID);
                Hide();
                var tView = new TaskView(thisTask, ThisStudent);
                tView.ShowDialog();
                Show();
                UpdateStudent();
            }

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
            var search = new Search(ThisStudent);
            search.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
