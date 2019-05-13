using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4Project.Exceptions;
using MySql.Data.MySqlClient;

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
        public void VerifySMERegistration(string name, string pass, string confirm, string email)
        {
            VerifySMEName(name);
            VerifyRegPassword(pass, confirm);
            VerifyEmail(email);
        }

        public void VerifySMEName(string name)
        {
            if (name.Length < 3 || name.Length > 100) throw new InvalidNameException(name);
        }

        #endregion

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
        #endregion
        public int VerifySMELogin(string username, string password)
        {
            string SMEID;
            int ID;
            // Sikrer der er et input:
            if (username == "") throw new NoUsernameInputException();
            if (password == "") throw new NoPasswordInputException();
            // Der forespørges i Databasen efter en bruger:
            if ((SMEID = SQL.SMELogInRequest(username, password)) == "") throw new SMEUserDoesNotExistException();
            // ID laves til int og returneres:
            int.TryParse(SMEID, out ID);
            return ID;
        }

        public int VerifyStudLogin(string username, string password)
        {
            string StudID;
            int ID;

            if (username == "") throw new NoUsernameInputException();
            if (password == "") throw new NoPasswordInputException();

            if ((StudID = SQL.StudLogInRequest(username, password)) == "") throw new StudUserDoesNotExistsException();

            int.TryParse(StudID, out ID);
            return ID;
        }

        public void VerifyTask(string title, string description, string location)
        {
            // Tilføj ordentlig validation eks. nummer:
            if (title == "" || title.Contains("@")) throw new InvalidTaskTitleException(title);
            if (description == "") throw new InvalidTaskDescriptionExeption(description);
            if (location == "") throw new InvalidTaskLocationException(location);
        }
    }
}
