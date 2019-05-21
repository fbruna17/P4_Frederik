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
            // Checks for "dates exceeded" and counts notification.
            SMENotificationBtn.Text = "Notifications (" + TaskNotificationCounter() + ")"; 
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

        private void TaskStateAutoStateChangeByDate()
        {
            SQLControl SQL = new SQLControl();

            //Checking individual if State Change is recommended due to ApplicationDeadline, StartDate and Est. Completion Deadline when an SME logs into the system.
            foreach (TaskSearched task in ThisSME.Tasks)
            {
                var taskAppIDs = 0;

                if (task.Startdate < DateTime.Now && (task.StateID != 3 && task.StateID != 4 && task.StateID != 1))
                {
                    taskAppIDs = task.ID;
                    var taskNewState = 1;
                    var message = "Your task: " + task.Title + " has passed its StartDate and no student is assigned. The task has been moved into Private State.";

                    SQL.AutoTaskStateChange(taskAppIDs, taskNewState);
                    MessageBox.Show(message);                    
                }

                else if (task.EstCompletionDate < DateTime.Now && task.StateID == 3)
                {
                    taskAppIDs = task.ID;

                    DialogResult result = MessageBox.Show("Your task: " + task.Title + " has exceeded its Completion Deadline. Do you want to move it into Completed State?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        SQL.CompleteTask(taskAppIDs);
                    }
                    else if (result == DialogResult.No || result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Task State wasn't changed. Please update your deadline manually");
                    }
                    else { }
                }
                //Updation the session after making potential changes to different Task States.
                UpdateSession();
            }        
        }

        private int TaskNotificationCounter()
        {
            int notifications = 0;
            foreach (TaskSearched task in ThisSME.Tasks)
            {
                if (task.Startdate < DateTime.Now && (task.StateID != 3 && task.StateID != 4 && task.StateID != 1))
                {
                    notifications++;
                }

                else if (task.EstCompletionDate < DateTime.Now && task.StateID == 3)
                {
                    notifications++;
                }
            }
            return notifications;
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
            TaskView.Rows.Clear();
            TaskView.Refresh();
            foreach (TaskSearched task in ThisSME.GetListOfTasks(3))
            {
                TaskView.Rows.Add(task.MakeDataViewString());
            }
        }

        private void SeeCompletedTasks_Click(object sender, EventArgs e)
        {
            TaskView.Rows.Clear();
            TaskView.Refresh();
            foreach (TaskSearched task in ThisSME.GetListOfTasks(4))
            {
                TaskView.Rows.Add(task.MakeDataViewString());
            }
        }

        private void SeeAllTasks_Click(object sender, EventArgs e)
        {
            TaskView.Rows.Clear();
            TaskView.Refresh();
            foreach (TaskSearched task in ThisSME.Tasks)
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

        private void SMENotificationBtn_Click(object sender, EventArgs e)
        {
            TaskStateAutoStateChangeByDate();
            SMENotificationBtn.Text = "Notifications (" + TaskNotificationCounter() + ")";
        }
    }
}
