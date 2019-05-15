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

namespace P4Project.Frontend
{
    public partial class SMELandingPage : Form
    {
        private SMELoggedIn ThisSME { get; }

        public SMELandingPage(SMELoggedIn thisSME)
        {
            ThisSME = thisSME;
            InitializeComponent();
            CompanyNameBox.Text = "Welcome " + ThisSME.Name;
            InformUserOfTaskDates();
        }

        private void InformUserOfTaskDates()
        {
            string taskAppNames = "";
            string taskBeginNames = "";
            foreach (TaskSearched task in ThisSME.Tasks)
            {
                if (task.ApplicationDeadline < DateTime.Now && task.StateID == 2) taskAppNames += task.Title + "";
                if (task.Startdate < DateTime.Now && task.StateID == 1 && task.StateID == 2 ) taskBeginNames += task.Title + "";
            }

            if (taskAppNames != "") MessageBox.Show("Your task(s): " + taskAppNames + " has exceded Application Deadline!");
            if (taskBeginNames != "") MessageBox.Show("Your task(s): " + taskBeginNames + " Should be in progress but are not.");
        }

        private void Create_New_Task_Click(object sender, EventArgs e)
        {
            var taskCreate = new CreateTask(ThisSME);
            Hide();
            taskCreate.ShowDialog();
            Show();
        }

        private void SeePublicTasks_Click(object sender, EventArgs e)
        {
            List<TaskSearched> tasks = ThisSME.GetListOfTasks(2);
            foreach(TaskSearched task in tasks)
            {
                SMETasksDisplay.Items.Add(task);
            }
        }

        private void SeePrivateTasks_Click(object sender, EventArgs e)
        {

        }

        private void SeeOnGoingTasks_Click(object sender, EventArgs e)
        {

        }

        private void SeeCompletedTasks_Click(object sender, EventArgs e)
        {

        }

        private void SeeAllTasks_Click(object sender, EventArgs e)
        {

        }

        private void SMETasksDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewTask_Click(object sender, EventArgs e)
        {
            // Display task der er valgt.
        }
    }
}
