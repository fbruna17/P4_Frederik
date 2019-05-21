using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4Project.Frontend;
using System.IO;

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

        #region Load
        private void LandingPage_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Buttons
        private void StudentLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var stud = new StudentLogInPage();
            stud.ShowDialog();
            this.Show();
        }

        private void StudentRegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var stud = new CreateStudProfileV2();
            stud.ShowDialog();
            this.Show();
        }

        private void SMELoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var stud = new SMELogInPage();
            stud.ShowDialog();
            this.Show();
        }

        private void SMERegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var stud = new RegisterSMEProfile();
            stud.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
