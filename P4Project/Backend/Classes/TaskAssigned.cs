using System;

namespace P4Project.Backend.Classes
{
    // This class is used for the Student Landing page, as a struct to keep and show data in their list of assigned tasks:
    // + Used as a parent class to more detailed task instances:
    public class TaskAssigned : TaskBase
    {   
        public DateTime Deadline { get; }
        public int StateID { get; }

        public TaskAssigned(TaskBase thisTask, DateTime deadline, int stateID) : base(thisTask.ID, thisTask.SMEID, thisTask.Title)
        {
            Deadline = deadline;
            StateID = stateID;
        }

        // Method that return the string[] for showing informatin in a DataGridView: 
        // (Used for StudentLandingPage and Profile to display Assigned and completed Tasks)
        public string[] MakeDataViewString()
        {
            string[] output = { Title, SMEName, Deadline.ToShortDateString() };
            return output;
        }
    }
}
