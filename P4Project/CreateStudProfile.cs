using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4Project
{
    public partial class CreateStudProfile : Form
    {
        public CreateStudProfile()
        {
            InitializeComponent();
        }

        private void basicSaveBut_Click(object sender, EventArgs e)
        {
            string firstname = FirstNameText.Text;
            string lastname = LastNameText.Text;
            string mail = EmailText.Text;
            MessageBox.Show("Your name: " + firstname + " " + lastname);
        }
    }
}
