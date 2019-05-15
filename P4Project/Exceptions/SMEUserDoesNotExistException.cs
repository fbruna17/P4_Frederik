using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    public class UserDoesNotExistException : Exception
    {
        public string username;
        public string password;

        public UserDoesNotExistException() : base()
        { }

        public UserDoesNotExistException(string username, string password) : base()
        {
            this.username = username;
            this.password = password;
        }
    }
}
