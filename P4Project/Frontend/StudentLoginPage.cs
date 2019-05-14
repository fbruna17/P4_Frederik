using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4Project.Exceptions;

namespace P4Project.Frontend
{
    public partial class StudentLoginPage : Form
    {
        private UserInputValidation InputValidation;
        private SQLControl SQL;

        public StudentLoginPage()
        {
            InitializeComponent();
            InputValidation = new UserInputValidation();
            SQL = new SQLControl();
        }

        private void StudentLoginBtn_Click(object sender, EventArgs e)
        {
            string stud_username = studentUsername.Text;
            string stud_password = studentPassword.Text;

            try
            {
                int StudID = InputValidation.VerifyStudLogin(stud_username, stud_password);
                StudentBase Stud = SQL.FetchStudBaseInformation(StudID);
                var stud = MessageBox.Show("Correct");
            }
            catch (NoUsernameInputException)
            {
                MessageBox.Show("Please input a username!");
            }
            catch (NoPasswordInputException)
            {
                MessageBox.Show("Please input a password!");
            }
            catch (StudUserDoesNotExistsException)
            {
                MessageBox.Show("Wrong Username or password!");
            }
        }
    }
}
