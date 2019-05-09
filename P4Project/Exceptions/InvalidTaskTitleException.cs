using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    public class InvalidTaskTitleException : Exception
    {
        public string input;
        public InvalidTaskTitleException() : base()
        { }

        public InvalidTaskTitleException(string input) : base()
        {
            this.input = input;
        }

    }
}
