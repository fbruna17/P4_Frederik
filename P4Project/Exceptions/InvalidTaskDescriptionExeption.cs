using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    class InvalidTaskDescriptionExeption : Exception
    {
        public string input;
        public InvalidTaskDescriptionExeption() : base()
        { }

        public InvalidTaskDescriptionExeption(string input) : base()
        {
            this.input = input;
        }
    }
}
