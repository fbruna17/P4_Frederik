using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    class InvalidTaskApplyDateException : Exception
    {
        public DateTime input;

        public InvalidTaskApplyDateException() : base() { }

        public InvalidTaskApplyDateException(DateTime input) : base()
        {
            this.input = input;
        }
    }
}
