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
        private SMELoggedIn ThisSME { get; set; }

        public SMELandingPage(SMELoggedIn thisSME)
        {
            ThisSME = thisSME;
            InitializeComponent();
            InformUserOfTaskDates();
            foreach (TaskSearched task in ThisSME.GetListOfTasks(2))
            {
                TaskView.Rows.Add(task.MakeDataViewString());
            }
        }

        private void UpdateSession()
        {
            ThisSME = ThisSME.UpdateSessionData();
            TaskView.Rows.Clear();
            foreach (TaskSearched task in ThisSME.GetListOfTasks(2))
            {
                TaskView.Rows.Add(task.MakeDataViewString());
            }
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
            UpdateSession();
            Show();
        }

        private void SeePublicTasks_Click(object sender, EventArgs e)
        {
            TaskView.Rows.Clear();
            TaskView.Refresh();
            foreach (TaskSearched task in ThisSME.GetListOfTasks(2))
            {
                TaskView.Rows.Add(task.MakeDataViewString());
            }
        }

        private void SeePrivateTasks_Click(object sender, EventArgs e)
        {
            TaskView.Rows.Clear();
            TaskView.Refresh();
            foreach (TaskSearched task in ThisSME.GetListOfTasks(1))
            {
                TaskView.Rows.Add(task.MakeDataViewString());
            }
        }

        private void SeeOnGoingTasks_Click(object sender, EventArgs e)
        {
            foreach (TaskSearched task in ThisSME.GetListOfTasks(3))
            {
                TaskView.Rows.Add(task.MakeDataViewString());
            }
        }

        private void SeeCompletedTasks_Click(object sender, EventArgs e)
        {
            foreach (TaskSearched task in ThisSME.GetListOfTasks(4))
            {
                TaskView.Rows.Add(task.MakeDataViewString());
            }
        }

        private void SeeAllTasks_Click(object sender, EventArgs e)
        {
            foreach(TaskSearched task in ThisSME.Tasks)
            {
                TaskView.Rows.Add(task.MakeDataViewString());
            }
        }

        private void SMETasksDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewTask_Click(object sender, EventArgs e)
        {
            SQLControl sql = new SQLControl();
            string taskname = TaskView.SelectedCells[0].Value.ToString();
            TaskSearched tTask = ThisSME.Tasks.Single(t => t.Title == taskname);
            TaskDetailed thisTask = sql.FetchTaskDetailed(tTask.ID);
            Hide();
            var tView = new TaskView(thisTask, ThisSME);
            tView.ShowDialog();
            UpdateSession();
            Show();
        }
    }
}
