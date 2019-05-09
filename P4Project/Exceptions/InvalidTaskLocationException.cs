using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    class InvalidTaskLocationException : Exception
    {
        public string input;
        public InvalidTaskLocationException() : base()
        { }

        public InvalidTaskLocationException(string input) : base()
        {
            this.input = input;
        }
    }
}
