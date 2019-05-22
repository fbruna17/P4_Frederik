using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using P4Project.Backend.Classes;
using MySql.Data.MySqlClient;
using P4Project.Exceptions;

namespace P4Project.Frontend
{
    public partial class SMELandingPage : Form
    {
        private SMELoggedIn ThisSME { get; set; }
        private SQLControl SQL { get; }

        #region Constructors
        public SMELandingPage(SMELoggedIn thisSME)
        {
            ThisSME = thisSME;
            InitializeComponent();
            SQL = new SQLControl();
            // Checks for "dates exceeded" and counts notification.
            try
            {
                SMENotificationBtn.Text = "Notifications (" + TaskNotificationCounter() + ")";
                MakePrivatPublicDataGrid(2);
            }
            #region Exception Catching:
            catch(MySqlException ex)
            {
                MessageBox.Show("An SQL exception has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An Unknow error has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
            #endregion
        }
        #endregion

        #region Session Related
        private void UpdateSession()
        {
            ThisSME = ThisSME.UpdateSessionData();
            MakePrivatPublicDataGrid(2);
        }
        #endregion

        #region TaskState Related
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
                    var message = "Your task: " + task.Title + " has passed its StartDate and no student is assigned. The task will be moved into Private State.";

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
            }
            //Updation the session after making potential changes to different Task States.
            UpdateSession();
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
        #endregion

        #region Buttons
        private void SMENotificationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TaskStateAutoStateChangeByDate();
                SMENotificationBtn.Text = "Notifications (" + TaskNotificationCounter() + ")";
            }
            #region Exception Catching:
            catch (MySqlException ex)
            {
                MessageBox.Show("An SQL exception has occured whil loading this page! Please contact system administrators! \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Unknow error has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
            #endregion

        }

        private void ViewTask_Click(object sender, EventArgs e)
        {
            try
            {
                string taskname = TaskView.SelectedCells[0].Value.ToString();
                TaskSearched tTask = ThisSME.Tasks.Single(t => t.Title == taskname);
                TaskDetailed thisTask = SQL.FetchTaskDetailed(tTask.ID);
                Hide();
                var tView = new TaskView(thisTask, ThisSME);
                tView.ShowDialog();
                UpdateSession();
                Show();
            }
            #region Exception Catching:
            catch (DataErrorInDataBaseException)
            {
                MessageBox.Show("There was an error with the data trying to be loaded for this task! Please try again later or contact system administrators!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An SQL exception has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Unknow error has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
            #endregion

        }


        private void Create_New_Task_Click(object sender, EventArgs e)
        {
            var taskCreate = new CreateTask(ThisSME);
            Hide();
            taskCreate.ShowDialog();
            try
            {
                UpdateSession();
                Show();
            }
            #region Exception Catching:
            catch (DataErrorInDataBaseException)
            {
                MessageBox.Show("There was an error with the data trying to be loaded for this task! Please try again later or contact system administrators!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An SQL exception has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Unknow error has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
            #endregion

        }

        private void SeePublicTasks_Click(object sender, EventArgs e)
        {
            try
            {
                MakePrivatPublicDataGrid(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Unknow error has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
        }

        private void SeePrivateTasks_Click(object sender, EventArgs e)
        {
            try
            {
                MakePrivatPublicDataGrid(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Unknow error has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
        }

        private void SeeOnGoingTasks_Click(object sender, EventArgs e)
        {
            try
            {
                MakeOngoingCompletedDataGrid(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Unknow error has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
        }

        private void SeeCompletedTasks_Click(object sender, EventArgs e)
        {
            try
            {
                MakeOngoingCompletedDataGrid(4);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Unknow error has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
        }

        private void SeeAllTasks_Click(object sender, EventArgs e)
        {
            try
            {
                TaskView.Rows.Clear();
                TaskView.Refresh();
                RefreshVisibilityOnDataGridView();
                TaskView.Columns["ApplicationDeadline"].Visible = true;
                TaskView.Columns["Deadline"].Visible = true;
                List<TaskSearched> tasks = ThisSME.Tasks;
                foreach (TaskSearched task in tasks)
                {
                    string[] output = { task.Title, "", task.ApplicationDeadline.ToShortDateString(), "", task.Startdate.ToShortDateString(), task.EstCompletionDate.ToShortDateString() };
                    TaskView.Rows.Add(output);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Unknow error has occured while loading this page! Please contact system administrators! \n" + ex.Message);
            }
        }
        #endregion

        #region DataGridViewCreaters:

        // Making of the Privat or Public DataGrid:
        private void MakePrivatPublicDataGrid(int stateID)
        {
            TaskView.Rows.Clear();
            TaskView.Refresh();
            RefreshVisibilityOnDataGridView();
            TaskView.Columns["Applications"].Visible = true;
            TaskView.Columns["ApplicationDeadline"].Visible = true;
            List<TaskSearched> tasks = ThisSME.GetListOfTasks(stateID);
            foreach (TaskSearched task in tasks)
            {
                int amount = SQL.FetchAmountOfApplications(task.ID);
                string[] output = { task.Title, amount.ToString(), task.ApplicationDeadline.ToShortDateString(), "", task.Startdate.ToShortDateString() };
                TaskView.Rows.Add(output);
            }
        }

        // Making of the Ongoing or Completed DataGrid:
        private void MakeOngoingCompletedDataGrid(int stateID)
        {
            TaskView.Rows.Clear();
            TaskView.Refresh();
            RefreshVisibilityOnDataGridView();
            TaskView.Columns["AssignedStudent"].Visible = true;
            TaskView.Columns["Deadline"].Visible = true;
            List<TaskSearched> tasks = ThisSME.GetListOfTasks(stateID);
            foreach (TaskSearched task in tasks)
            {
                string studName = SQL.FetchAssignedStudentName(task.ID);
                string[] output = { task.Title, "", "", studName, task.Startdate.ToShortDateString(), task.EstCompletionDate.ToShortDateString() };
                TaskView.Rows.Add(output);
            }
        }

        public void RefreshVisibilityOnDataGridView()
        {
            TaskView.Columns["AssignedStudent"].Visible = false;
            TaskView.Columns["Deadline"].Visible = false;
            TaskView.Columns["Applications"].Visible = false;
            TaskView.Columns["ApplicationDeadline"].Visible = false;
        }

        private void SMELogOutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
