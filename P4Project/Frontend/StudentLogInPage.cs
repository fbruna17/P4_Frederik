using System;
using System.Windows.Forms;
using P4Project.Backend.Classes;
using P4Project.Exceptions;
using MySql.Data.MySqlClient;

namespace P4Project.Frontend
{
    public partial class StudentLogInPage : Form
    {     
        #region Instance Variables & Properties
        private UserInputValidation InputValidation;
        private SQLControl SQL;
        #endregion

        #region Constructors
        public StudentLogInPage()
        {
            InitializeComponent();
            InputValidation = new UserInputValidation();
            SQL = new SQLControl();
        }
        #endregion

        #region Buttons
        private void LogIn_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            try
            {
                int studID = InputValidation.VerifyLogin(username, password, "Student");
                StudentDetailed tStudent = SQL.FetchStudentDetailed(studID);
                StudentLoggedIn student = new StudentLoggedIn(username, password, tStudent);
                var studLandingPage = new StudentLandingPage(student);
                Close();
                studLandingPage.ShowDialog();
            }
            #region Exception Cathcing:
            catch (NoUsernameInputException)
            {
                MessageBox.Show("Please input a username!");
            }
            catch (NoPasswordInputException)
            {
                MessageBox.Show("Please input a password!");
            }
            catch (UserDoesNotExistException)
            {
                MessageBox.Show("Wrong Username or password!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An unexpected SQL error has occures! Error Number: " + ex.Number + " Error message: " + ex.Message + ex.Source);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error has occured while trying to log in! Please contact system administrators!" + ex.Message);
            }
            #endregion
        }

        private void StudentLoginBackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
