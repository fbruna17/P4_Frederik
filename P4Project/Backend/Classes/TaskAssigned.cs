using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    public class TaskAssigned : TaskBase
    {
        // This class is used for the Student Landing page, as a struct to keep and show data in their list of assigned tasks:
        public DateTime Deadline { get; }

        public int StateID { get; }

        public TaskAssigned(TaskBase thisTask, DateTime deadline, int stateID) : base(thisTask.ID, thisTask.SMEID, thisTask.Title)
        {
            Deadline = deadline;
            StateID = stateID;
        }

        public string[] MakeDataViewString()
        {
            string[] output = { Title, SMEName, Deadline.ToShortDateString() };
            return output;
        }
    }
}
