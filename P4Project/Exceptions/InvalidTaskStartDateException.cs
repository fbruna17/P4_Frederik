using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    class InvalidTaskStartDateException : Exception
    {
        public DateTime input;

        public InvalidTaskStartDateException() : base() { }

        public InvalidTaskStartDateException(DateTime input) : base()
        {
            this.input = input;
        }
    }
}
