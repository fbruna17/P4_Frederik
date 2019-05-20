using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    class InvalidTaskHoursException : Exception
    {
        public int input;

        public InvalidTaskHoursException() : base() { }

        public InvalidTaskHoursException(int input) : base()
        {
            this.input = input;
        }
    }
}
