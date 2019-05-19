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
using P4Project.Backend.Classes;
using MySql.Data.MySqlClient;

namespace P4Project.Frontend
{
    public partial class SMELogInPage : Form
    {
        private UserInputValidation InputValidation;
        private SQLControl SQL;

        public SMELogInPage()
        {
            InitializeComponent();
            InputValidation = new UserInputValidation();
            SQL = new SQLControl();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            try
            {
                int smeID = InputValidation.VerifyLogin(username, password, "SME");
                SMEDetailed tSME = SQL.FetchSMEDetailedInformation(smeID);
                SMELoggedIn sme = new SMELoggedIn(username, password, tSME);
                var smeLandingPage = new SMELandingPage(sme);
                Hide();
                Close();
                smeLandingPage.ShowDialog();
            }
            catch(NoUsernameInputException)
            {
                MessageBox.Show("Please input a username!");
            }
            catch(NoPasswordInputException)
            {
                MessageBox.Show("Please input a password!");
            }
            catch(UserDoesNotExistException)
            {
                MessageBox.Show("Wrong Username or password!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An unexpected SQL error has occures! Error Number: " + ex.Number + " Error message: " + ex.Message + ex.Source);
            }
        }
    }
}
