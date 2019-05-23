using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Exceptions
{
    public class RecommendationException : Exception
    {
        public string input;
        public RecommendationException() : base()
        { }

        public RecommendationException(string input) : base()
        {
            this.input = input;
        }
    }
}
