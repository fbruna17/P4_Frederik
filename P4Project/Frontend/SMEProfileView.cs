using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4Project.Frontend
{
    public partial class SMEProfileView : Form
    {
        private SMEBase SME;

        public SMEProfileView(SMEBase SME)
        {
            InitializeComponent();
            this.SME = SME;
            companyName.Text = "Welcome to TaskDistributer2000 " + SME.Name;
            email.Text = SME.Email;
        }

        private void createTask_Click(object sender, EventArgs e)
        {
            var taskCreate = new CreateTask(SME);
            Hide();
            taskCreate.ShowDialog();
            Show();
        }
    }
}
