using MySql.Data.MySqlClient;
using P4Project.Backend.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace P4Project.Frontend
{
    public partial class StudentProfileView : Form
    {
        #region Instance Variables & Properties
        // Properties for SME View og profile:
        private StudentDetailed Student { get; }
        private SMELoggedIn ThisSME { get; }
        private ApplicationBase ThisApplication { get; }

        // Property for a student:
        private StudentLoggedIn ThisStudent { get; set; }

        // SQL Control:
        private SQLControl sql = new SQLControl();
        #endregion

        #region FTPVariables:
        private FTPControl FTP = new FTPControl();
        //Declearing a string for the local full path of the file.
        private string LocalPDFPath = string.Empty;
        //Declearing a string for the file extension of the file.
        private string LocalPDFFiletype = string.Empty;
        //Declearing a string for the local full path of the image.
        private string LocalImagePath = string.Empty;
        //Declearing a string for the file extension of the image.
        private string LocalImageFiletype = string.Empty;
        #endregion

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
            InitializeSMEViewApplication();
        }

        // Constructor for an SME looking up a student profile by a task the student is assigned too/has completed:
        public StudentProfileView(SMELoggedIn thisSME, StudentDetailed student, TaskDetailed task)
        {
            ThisSME = thisSME;
            Student = student;
            InitializeComponent();
            InitializeDefault(student);
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
            StudentPictureBox.ImageLocation = student.ProfilePicture;

            // Former tasks is initialized:
            student.GetAssignedTasks();
            FormerTaskGrid.Rows.Clear();
            foreach (TaskAssigned task in student.AssignedTasks)
            {
                if(task.StateID == 4)
                {
                    FormerTaskGrid.Rows.Add(task.MakeDataViewString());
                }
            }
            // Skillset is initialized:
            InitializeSkillList(student);
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
            StudentDescBox.ReadOnly = false;
            SubmitEdit.Visible = true;
            ChoosePDFBtn.Visible = true;
            ChooseImageBtn.Visible = true;
            ChoosenImageLabel.Visible = true;

            // Education editing is initialized:
            InitializeEducationEditing();
            // Skill editing:
            InitializeSkillEditing();            
        }

        // Initializes the buttons for an SME viewing a student profile:
        private void InitializeSMEViewApplication()
        {
            AssignStudent.Visible = true;
        }

        // Initialize Educations:
        private void InitializeEducationEditing()
        {
            List<EducationBase> educations = sql.FetchALLEducations();
            EducationDropDown.Items.Clear();
            EducationDropDown.Text = ThisStudent.Education;
            foreach (EducationBase edu in educations)
            {
                EducationDropDown.Items.Add(edu.Name);
            }
            EducationDropDown.Visible = true;
        }

        // Initialize SkillEditing:
        private void InitializeSkillEditing()
        {
            EditSkillsBox.Visible = true;

            SkillDropDown.Items.Clear();
            SkillDropDown.Text = "Select a skill...";
            List<Skill> skills = sql.FetchALLSkills();

            // The skills the student already has are removed:
            foreach (SkillStudent skill in ThisStudent.Skills)
            {
                skills.RemoveAll(a => a.ID == skill.ID);
            }
            foreach (Skill skill in skills)
            {
                SkillDropDown.Items.Add(skill.Name);
            }
        }

        private void InitializeSkillList(StudentDetailed student)
        {
            SkillSetGrid.Rows.Clear();
            foreach (SkillStudent skill in student.Skills)
            {
                SkillSetGrid.Rows.Add(skill.MakeDataViewGrid());
            }
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

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        // A function that submits the new information on the student:
        private void SubmitEdit_Click(object sender, EventArgs e)
        {
            var File_Path = LocalPDFPath;
            var File_Type = LocalPDFFiletype;
            var serverFilePathDir = string.Empty;
            if (File_Path != string.Empty)
            {

                serverFilePathDir = FTP.UploadFile(File_Path, File_Type);
            }

            var image_Path = LocalImagePath;
            var image_Type = LocalImageFiletype;
            var serverImagePathDir = string.Empty;
            if (image_Path != string.Empty)
            {

                serverImagePathDir = FTP.UploadImage(image_Path, image_Type);
            }

            string profilepicture = ThisStudent.ProfilePicture;
            if (serverImagePathDir != string.Empty)
            {
                profilepicture = serverImagePathDir;
            }

            string resume = ThisStudent.Resume;
            if(serverFilePathDir != string.Empty)
            {
                resume = serverFilePathDir;
            }
            string email = EditEmail.Text;
            string description = StudentDescBox.Text;
            string education = ThisStudent.Education;
            if(EducationDropDown.SelectedItem != null)
            {
                education = EducationDropDown.SelectedItem.ToString();
            }
            // ProfilePicture Hvis ikke det ændres på student objektet.

            StudentDetailed newStudInfo = new StudentDetailed(ThisStudent.FirstName, ThisStudent.LastName, ThisStudent.ID, email, education, ThisStudent.Skills, description, profilepicture, resume);

            // Verifies!
            try
            {
                sql.UpdateStudentProfile(newStudInfo);
                MessageBox.Show("Your profile has been updated!");
                Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("There where an error while updating you edits! Please try again, or contact system administrators! " + ex.Message);
            }

        }

        // When a student is editing his or hers profile, and wants to remove a skill from his or hers skill set:
        private void RemoveSkill_Click(object sender, EventArgs e)
        {
            string skillName = SkillSetGrid.SelectedCells[0].Value.ToString();

            if (SkillSetGrid.SelectedCells[1].Value.ToString() == "Yes")
            {
                MessageBox.Show("The skill " + skillName + " is verified by your education or a completed task. It is not possible to remove!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove the skill " + skillName + "?", "Confirm Remove", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    ThisStudent.RemoveFromSkillSet(skillName);
                    InitializeSkillList(ThisStudent);
                    InitializeSkillEditing();
                }
            }
        }

        // When a student is editing his or hers profile, and wants to add a skill to their skill set: 
        private void AddSkill_Click(object sender, EventArgs e)
        {
            if(SkillDropDown.SelectedItem != null)
            {
                string skillName = SkillDropDown.SelectedItem.ToString();
                Skill skill = sql.FetchSkillInfoBasedOnName(skillName);
                SkillStudent rSkill = new SkillStudent(skill.ID, skill.Name, false);
                ThisStudent.AddTooSkillSet(rSkill);
                InitializeSkillList(ThisStudent);
                InitializeSkillEditing();
            }
            else MessageBox.Show("Please select a skill from the dropdown to add.");
        }

        private void ChoosePDFBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //Sets the FileDialog "Start path" to the C drive
                openFileDialog.InitialDirectory = "c:\\";
                //Applies filter for allowed filetypes
                openFileDialog.Filter = "Choose your resumé file (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Stores the name of the chosen file into "fileName"
                    var fileName = openFileDialog.SafeFileName;
                    //Stores the fileextension into "fileType"
                    var fileType = Path.GetExtension(openFileDialog.FileName);
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;
                    //Displays the filename of the chosen PDF in the label.
                    ResumeNameLabel.Text = "Your file: " + fileName;
                    //Stores the local path into the already decleared "LocalPDFPath" string.
                    LocalPDFPath = filePath;
                    //Stores the file extension into the already decleared "LocalPDFFiletype" string.
                    LocalPDFFiletype = fileType;
                }
            }
        }

        private void ResumeLink()
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            StudentResumeLink.LinkVisited = true;
            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start(ThisStudent.Resume);
        }
        private void StudentResumeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ThisStudent.Resume != "")
            {
                ResumeLink();
            }
            else
            {
                MessageBox.Show("This student hasn't uploaded a resumé yet.");
            }
        }
        private void ChooseImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                //Sets the FileDialog "Start path" to the C drive
                openFileDialog.InitialDirectory = "c:\\";
                //Applies filter for allowed filetypes
                openFileDialog.Filter = "Choose your image file (*.jpg)|*.jpg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Stores the name of the chosen file into "fileName"
                    var fileName = openFileDialog.SafeFileName;
                    //Stores the fileextension into "fileType"
                    var fileType = Path.GetExtension(openFileDialog.FileName);
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;
                    //Displays the choosen image in the PictureBox
                    StudentPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                    //Display the local filename of the choosen image.
                    ChoosenImageLabel.Text = "Your choosen image: " + fileName;
                    //Stores the local path into the already decleared "LocalImagePath" string.
                    LocalImagePath = filePath;
                    //Stores the file extension into the already decleared "LocalImageFiletype" string.
                    LocalImageFiletype = fileType;
                }
            }
        }

        #endregion

        #region SME-Specific:
        // When an SME user assigns this student to a task:
        private void AssignStudent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to assign " + Student.FirstName + " for this task?", "Confirm Assign", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    sql.AssignStudentToTask(Student.ID, ThisApplication.TaskID);
                    MessageBox.Show(Student.FirstName + " has succesfully been assigned for this task!");
                    Close();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("An error uccored while assigning this student! Please try again later, or contact system administrators! Error message: " + ex.Message);
                }
            }
        }
        #endregion
    }
}
