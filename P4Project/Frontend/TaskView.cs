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
    public partial class TaskView : Form
    {
        private TaskDetailed ThisTask { get; }

        // Denne construkter bruges til når en SME bruger vil se en af sine egne tasks:
        public TaskView(TaskDetailed task, SMELoggedIn sme)
        {
            InitializeComponent();
            ThisTask = task;

            MessageBox.Show(ThisTask.Title);
            MessageBox.Show(ThisTask.SMEName);
            InitializeDefault();
            if (ThisTask.SMEID == sme.ID)
            {
                InitializeFormForSMEOwner();
            }

        }

        public TaskView(TaskDetailed task, StudentLoggedIn student)
        {
            ThisTask = task;
            if(ThisTask.AssignedStudentID == student.ID)
            {
                InitializeFormForAssignedStudent();
            }
            else
            {
                InitializeFormForRegStudent();
            }
        }

        private void InitializeDefault()
        {
            TaskNameLabel.Text = ThisTask.Title;
            //CompanyNameLabel.Text = ThisTask.SMEName;
            TaskDescriptionBox.Text = ThisTask.Description;
            foreach(Skill skill in ThisTask.RequiredSkills)
            {
                RecSkills.Items.Add(skill.Name);
            }
        }

        private void InitializeFormForSMEOwner()
        {

        }

        private void InitializeFormForAssignedStudent()
        {

        }

        private void InitializeFormForRegStudent()
        {

        }
    }
}
