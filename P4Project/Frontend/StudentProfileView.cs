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
    public partial class StudentProfileView : Form
    {
        private StudentBase Student;

        public StudentProfileView(StudentBase Student)
        {
            InitializeComponent();
            this.Student = Student;
            WelcomeText.Text = "Welcome to your profile " + Student.FirstName + Student.LastName;
        }

        private void StudentProfileView_Load(object sender, EventArgs e)
        {

        }
    }
}
