using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
    using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4Project.Backend.Classes;

namespace P4Project.Frontend
{
    public partial class StudentProfileView : Form
    {
        private StudentDetailed Student { get; }
        private SMELoggedIn ThisSME { get; }
        private ApplicationBase ThisApplication { get; }

        private StudentLoggedIn ThisStudent { get; set; }

        private SQLControl sql = new SQLControl();


        //...................................................... CONSTRUCTORS: .........................................................
        #region Constructors:
        // Constructor for a Logged in Student Viewing his or hers own profile:
        public StudentProfileView(StudentLoggedIn thisStudent)
        {
            ThisStudent = thisStudent;

            InitializeComponent();
            InitializeDefault(thisStudent);
            InitializeStudentLoggedin();
        }
        // Constructor for when a student wants to edit his profile:
        public StudentProfileView(StudentLoggedIn thisStudent, bool edit)
        {
            ThisStudent = thisStudent;

            InitializeComponent();
            InitializeDefault(thisStudent);
            InitializeStudentEdit();
        }

        // Constructor for an SME looking up a student profile, based on an application to a given task:
        public StudentProfileView(SMELoggedIn thisSME, StudentDetailed student, ApplicationBase thisApplication)
        {
            ThisSME = thisSME;
            Student = student;
            ThisApplication = thisApplication;

            InitializeComponent();
            InitializeDefault(student);
            InitializeSMEView();
        }


        #endregion

        //...................................................... INITIALIZERS: .........................................................
        // All functions used to set up the form. They are called depending on which constructer is used, 
        // - and the relation between the user and the profile:
        #region Initializers:
        // Default Initializer, always called, fills out default data based on what student profile is seen:
        private void InitializeDefault(StudentDetailed student)
        {
            NameLabel.Text = student.FirstName + " " + student.LastName;
            StudentDescBox.Text = student.Description;
            EmailLabel.Text = student.Email;
            EducationLabel.Text = student.Education;

            // Former tasks is initialized:
            student.GetAssignedTasks();
            foreach(TaskAssigned task in student.AssignedTasks)
            {
                if(task.StateID == 4)
                {
                    FormerTaskGrid.Rows.Add(task.MakeDataViewString());
                }
            }
            // Skillset is initialized:
            foreach(SkillStudent skill in student.Skills)
            {
                SkillSetGrid.Rows.Add(skill.MakeDataViewGrid());
            }
        }
        // Initializes the buttons only usable by a logged in student viewing his own profile:
        private void InitializeStudentLoggedin()
        {
            StudentEditProfileBtn.Visible = true;
        }
        // Initializes the components needed for a student to edit his or hers profile:
        private void InitializeStudentEdit()
        {
            EmailLabel.Visible = false;
            EditEmail.Visible = true;
            EditEmail.Text = ThisStudent.Email;

        }
        // Initializes the buttons for an SME viewing a student profile:
        private void InitializeSMEView()
        {

        }

        #endregion

        //...................................................... BUTTON CLICKS: .........................................................
        // All Button clicks, seperate in Student, Universel and SME Specific:

        #region Student-specific:
        // Click on EditProfile:
        private void StudentEditProfileBtn_Click(object sender, EventArgs e)
        {
            bool edit = true;
            StudentProfileView editView = new StudentProfileView(ThisStudent, edit);
            Hide();
            editView.ShowDialog();
            ThisStudent = ThisStudent.UpdateSessionData();
            InitializeDefault(ThisStudent);
            InitializeStudentLoggedin();
            Show();
        }

        #endregion

        //...................................................... MISS CLICKS REMOVE LATER .........................................................

        private void StudentProfileView_Load(object sender, EventArgs e)
        {
        }

        private void StudSkillList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void StudentResumeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void StudentDescBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void Education_Click(object sender, EventArgs e)
        {

        }


    }
}
