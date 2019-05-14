using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    class SMEDetailed : SMEBase
    {
        public List<Task> Tasks { get; }

        public SMEDetailed(int id, string name, string email) : base(id, name, email)
        {

        }
    }
}
