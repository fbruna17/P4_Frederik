using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    class StudUserDoesNotExistsException : Exception
    {
        public string stud_username;
        public string stud_password;

        public StudUserDoesNotExistsException() : base()
        { }

        public StudUserDoesNotExistsException(string stud_username, string stud_password) : base()
        {
            this.stud_username = stud_username;
            this.stud_password = stud_password;
        }
    }
}
