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
        private SMEBase SME { get; }
        private StudentBase Student { get; }

        public Header(SMEBase SME)
        {
            InitializeComponent();
            this.SME = SME;
            lblNameInHeader.Text = SME.Name;
        }

        public Header(StudentBase Student)
        {
            InitializeComponent();
            this.Student = Student;
            lblNameInHeader.Text = Student.FirstName + " " + Student.LastName;
        }
    }
}
