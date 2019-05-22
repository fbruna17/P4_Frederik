using System;
using System.Windows.Forms;
using P4Project.Frontend;

namespace P4Project
{
    public partial class LandingPage : Form
    {

        #region Instance Variables & Properties

        private SQLControl SQL;
        #endregion // End of Variables Region

        #region Constructor(s)
        public LandingPage()
        {
            InitializeComponent();
            SQL = new SQLControl();
        }
        #endregion

        #region Buttons
        private void StudentLoginBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var stud = new StudentLogInPage();
            stud.ShowDialog();
            Show();
        }

        private void StudentRegisterBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var stud = new CreateStudProfile();
            stud.ShowDialog();
            Show();
        }

        private void SMELoginBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var stud = new SMELogInPage();
            stud.ShowDialog();
            Show();
        }

        private void SMERegisterBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var stud = new RegisterSMEProfile();
            stud.ShowDialog();
            Show();
        }
        #endregion
    }
}
