using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    public class DataErrorInDataBaseException : Exception
    {
        public string place;
        public DataErrorInDataBaseException() : base()
        { }

        public DataErrorInDataBaseException(string place) : base()
        {
            this.place = place;
        }
    }
}
