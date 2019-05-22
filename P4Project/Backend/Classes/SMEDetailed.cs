using System.Collections.Generic;

namespace P4Project.Backend.Classes
{
    // The detailed version of an SME instance:
    public class SMEDetailed : SMEBase
    {
        // This class stores the list of task owned by this SME:
        public List<TaskSearched> Tasks { get; }
        public string Logo { get; protected set; }

        // This class is used to display detailed information of an SME on runtime:
        public SMEDetailed(int id, string name, string email, List<TaskSearched> tasks, string logo) : base(id, name, email)
        {
            Tasks = tasks;
            Logo = logo;
        }
    }
}
