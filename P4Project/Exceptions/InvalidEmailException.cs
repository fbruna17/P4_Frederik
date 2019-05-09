using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    public class InvalidEmailException : Exception
    {
        public string i;
        public InvalidEmailException() : base()
        { }

        public InvalidEmailException(string input) : base()
        {
            i = input;
        }
    }
}
