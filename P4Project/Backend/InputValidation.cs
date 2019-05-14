﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4Project.Exceptions;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

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

        public void VerifyStudentUsername(string username)
        {
            string username = new Regex()
            //if (username.Contains("@") || username.Contains(".") || username.Contains(",") || username.Contains("!")) throw new InvalidUsernameException;
            if (username.Length < 5)
            if (SQL.StudentCheckUsername(username) != 0) throw new UserNameAlreadyExistsException();
        }
        #endregion //End of Universal Input

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

        public void VerifyTask(string title, string description, string location)
        {
            // Tilføj ordentlig validation eks. nummer:
            if (title == "" || title.Contains("@")) throw new InvalidTaskTitleException(title);
            if (description == "") throw new InvalidTaskDescriptionExeption(description);
            if (location == "") throw new InvalidTaskLocationException(location);
        }
    }
}
