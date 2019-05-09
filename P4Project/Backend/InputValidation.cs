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

        #endregion

        #region Constructor(s)
        public UserInputValidation() { }
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
    }
}
