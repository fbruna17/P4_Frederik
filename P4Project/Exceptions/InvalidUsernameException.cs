using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    class InvalidUsernameException : Exception
    {
        public string i;
        public InvalidUsernameException() : base()
        { }

        public InvalidUsernameException(string input) : base()
        {
            i = input;
        }
    }
}
