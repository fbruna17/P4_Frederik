using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    public class SMEDetailed : SMEBase
    {
        public List<TaskSearched> Tasks { get; }
        public string Logo { get; protected set; }
        public string Description { get; protected set; }

        public SMEDetailed(int id, string name, string email, List<TaskSearched> tasks, string logo, string description) : base(id, name, email)
        {
            Tasks = tasks;
            Logo = logo;
            Description = description;
        }
    }
}
