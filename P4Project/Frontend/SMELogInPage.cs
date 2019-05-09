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
    public partial class SMELogInPage : Form
    {
        private UserInputValidation InputValidation;

        public SMELogInPage()
        {
            InitializeComponent();
            InputValidation = new UserInputValidation();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            try
            {
                int SMEID = InputValidation.VerifySMELogin(username, password);
                MessageBox.Show("Gudav" + SMEID);
                Hide();
            }
            catch(NoUsernameInputException) 
            {
                MessageBox.Show("Please input a username!");
            }
            catch(NoPasswordInputException)
            {
                MessageBox.Show("Please input a password!");
            }
            catch(SMEUserDoesNotExistException)
            {
                MessageBox.Show("Wrong Username or password!");
            }
        }
    }
}
