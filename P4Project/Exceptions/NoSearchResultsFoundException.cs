using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    public class NoSearchResultsFoundException : Exception
    {
        public string i;
        public NoSearchResultsFoundException() : base()
        {

        }

        public NoSearchResultsFoundException(string input) : base()
        {
            i = input;
        }
    }
}
