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
    public partial class RegisterSMEProfile : Form
    {
        public RegisterSMEProfile()
        {
            InitializeComponent();
        }

        private void CompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(e.ToString());
        }
    }
}
