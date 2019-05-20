using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4Project.Exceptions;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace P4Project
{
    class UserInputValidation
    {
        #region Instance Variables & Properties
        private SQLControl SQL;
        #endregion

        #region Constructor(s)
        public UserInputValidation()
        {
            SQL = new SQLControl();
        }
        #endregion

        #region SME input
        public void VerifySMERegistration(string name, string pass, string confirm, string email, string username)
        {
            VerifySMEName(name);
            VerifyRegPassword(pass, confirm);
            VerifyEmail(email);
            VerifyUsername(username);
        }

        public void VerifySMEName(string name)
        {
            if (name.Length < 3 || name.Length > 100) throw new InvalidNameException(name);
        }

        #endregion

        #region Student input

        public void VerifyStudentRegistration(string username, string password, string confirmpassword, string email)
        {
            VerifyUsername(username);
            VerifyRegPassword(password, confirmpassword);
            VerifyEmail(email);
        }

        #endregion //End of Student Input Region

        #region Universal input
        public void VerifyRegPassword(string pass, string confirm)
        {
            if (pass != confirm) throw new PasswordsDoesNotMatchException();
            if (pass.Length < 8) throw new PasswordToShortException();
        }

        public void VerifyEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains(".") || email.Contains(" ")) throw new InvalidEmailException(email);
        }

        public void VerifyUsername(string username)
        {
            if (username.Contains("@") || username.Contains(".") || username.Contains(",") || username.Contains("!")) throw new InvalidUsernameException(username);
            if (username.Length < 5) { }
        }

        public void VerifyTitle(string title)
        {
            if (title == "" || title.Contains("@") || title.Length < 3 || title == string.Empty) throw new InvalidTaskTitleException(title);
        }
        public void VerifyDescription(string description)
        {
            //Husk at ændre .Lenght til noget som er rimeligt!
            if (description == "" || description.Length < 10 || description == string.Empty) throw new InvalidTaskDescriptionExeption(description);
        }
        public void VerifyApplyDate(DateTime applydate, DateTime startdate, DateTime deadlinedate)
        {
            if ((applydate < DateTime.Now) ||(applydate > startdate) || (applydate > deadlinedate)) throw new InvalidTaskApplyDateException(applydate);
        }
        public void VerifyStartDate(DateTime startdate, DateTime deadlinedate, DateTime applydate)
        {
            if ((startdate < DateTime.Now) || (startdate > deadlinedate) || (startdate < applydate)) throw new InvalidTaskStartDateException(startdate);
        }
        public void VerifyDeadlineDate(DateTime deadlinedate, DateTime applydate, DateTime startdate)
        {
            if ((deadlinedate < DateTime.Now) || (deadlinedate < applydate) || (deadlinedate < startdate)) throw new InvalidTaskDeadlineDateException(deadlinedate);
        }
        public void VerifyHours(int hours)
        {
            if (hours < 1) throw new InvalidTaskHoursException();
        }
        #endregion //End of Universal Input

        #region Verification

        public int VerifyLogin(string username, string password, string type)
        {
            string ID;
            // Sikrer der er et input:
            if (username == "") throw new NoUsernameInputException();
            if (password == "") throw new NoPasswordInputException();
            // Der forespørges i Databasen efter en bruger:
            if ((ID = SQL.LogInRequest(username, password, type)) == string.Empty) throw new UserDoesNotExistException();
            // ID laves til int og returneres:
            int.TryParse(ID, out int iD);
            return iD;
        }

        public void VerifyTask(string title, string description, DateTime applydate, DateTime startdate, DateTime deadlinedate, int hours)
        {
            VerifyTitle(title);
            VerifyDescription(description);
            VerifyApplyDate(applydate, startdate, deadlinedate);
            VerifyStartDate(startdate, deadlinedate, applydate);
            VerifyDeadlineDate(deadlinedate, applydate, startdate);
            VerifyHours(hours);
        }
        #endregion
    }
}
