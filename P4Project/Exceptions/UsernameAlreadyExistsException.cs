using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    class UsernameAlreadyExistsException : Exception
    {
        public string username;

        public UsernameAlreadyExistsException() : base()
        { }

        public UsernameAlreadyExistsException(string username) : base()
        {
            this.username = username;
        }
    }
}
