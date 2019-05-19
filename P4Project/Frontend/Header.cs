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
    public partial class Header : Form
    {
        /// <summary>
        /// Classes will inherit header.
        ///     ClassName : Header
        ///     
        /// The relevant constructor(s) will then inherit the base header with parameters.
        ///     public ConstructorName(SMELoggedIn SME) : base(SME).
        ///     
        /// Similar for student.
        /// </summary>

        //Profile type variables:
        private SMEBase SME { get; }
        private StudentBase Student { get; }
        //Bool to define Task-button function:
        private bool isSME;

        public Header(SMEBase SME)
        {
            InitializeComponent();
            isSME = true;
            this.SME = SME;
            lblNameInHeader.Text = SME.Name;
            btnSidebarTask.Text = "Create Task";
        }

        public Header(StudentBase Student)
        {
            InitializeComponent();
            isSME = false;
            this.Student = Student;
            lblNameInHeader.Text = Student.FirstName + " " + Student.LastName;
            btnSidebarTask.Text = "Search Tasks";
        }

        private void btnSidebarTask_Click(object sender, EventArgs e)
        {
            if (isSME)
            {
               // var taskCreate = new CreateTask(SME);
                Hide();
             //   taskCreate.ShowDialog();
                Show();
            }
            else
            {
                //Stuff for student.
            }
        }
    }
}
