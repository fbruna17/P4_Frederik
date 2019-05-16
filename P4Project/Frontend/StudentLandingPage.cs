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
    public partial class StudentLandingPage : Form
    {
        public StudentLoggedIn ThisStudent { get; }
        public StudentLandingPage(StudentLoggedIn thisStudent)
        {
            InitializeComponent();
            ThisStudent = thisStudent;
            ShowStudentEmailLabel.Text = ThisStudent.Email;
            ShowStudentNameLabel.Text = ThisStudent.FirstName + " " + ThisStudent.LastName;

            foreach(TaskRecommend task in ThisStudent.RecTasks)
            {
                RecommendedTasks.Rows.Add(task.MakeDataViewGrid());
            }
        }

        private void ViewRecTask_Click(object sender, EventArgs e)
        {

        }
    }
}
