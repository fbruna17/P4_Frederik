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
    public partial class SMEProfileView : Header
    {
        private SMELoggedIn SME;

        public SMEProfileView(SMELoggedIn SME) : base(SME)
        {
            InitializeComponent();
            this.SME = SME;
            companyName.Text = "Welcome to TaskDistributer2000 " + SME.Name;
            email.Text = SME.Email;
        }

        private void createTask_Click(object sender, EventArgs e)
        {
         //   var taskCreate = new CreateTask(SME);
            Hide();
          //  taskCreate.ShowDialog();
            Show();
        }
    }
}
