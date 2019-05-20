using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    class InvalidTaskDeadlineDateException : Exception
    {
        public DateTime input;

        public InvalidTaskDeadlineDateException() : base() { }

        public InvalidTaskDeadlineDateException(DateTime input) : base()
        {
            this.input = input;
        }
    }
}
