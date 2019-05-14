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
    }
}
