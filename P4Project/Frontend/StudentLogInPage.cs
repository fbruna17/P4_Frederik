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
using P4Project.Exceptions;
using MySql.Data.MySqlClient;

namespace P4Project.Frontend
{
    public partial class StudentLogInPage : Form
    {
        private UserInputValidation InputValidation;
        private SQLControl SQL;

        public StudentLogInPage()
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
                int studID = InputValidation.VerifyLogin(username, password, "Student");
                StudentDetailed tStudent = SQL.FetchStudentDetailed(studID);
                StudentLoggedIn student = new StudentLoggedIn(username, password, tStudent);
                student.UpdateSkillSet();
                var studLandingPage = new StudentLandingPage(student);
                Close();
                studLandingPage.ShowDialog();
            }
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
            catch (DataErrorInDataBaseException ex)
            {
                MessageBox.Show("There was an error in the data loaded! Please contact system administrators!" + ex.place);
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show("An unexpected SQL error has occures! Error Number: " + ex.Number + " Error message: " + ex.Message + ex.Source);
            }
        }
    }
}
