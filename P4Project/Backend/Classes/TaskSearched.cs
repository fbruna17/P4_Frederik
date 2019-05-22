using System;

namespace P4Project.Backend.Classes
{
    // This Class is used to store information on tasks that are searched, to give the short preview of them.
    public class TaskSearched : TaskBase
    {
        public string Location { get; }
        public int Hours { get; }
        public DateTime Startdate { get; }
        public DateTime ApplicationDeadline { get; }
        public DateTime EstCompletionDate { get; }
        public int RecScore { get; set; }
        public int StateID { get; }

        // A constructer for when the State is irrelevant:
        public TaskSearched(int id, int smeid, string title, string location, int hours, DateTime startdate, 
            DateTime applicationDeadline, DateTime estCompletionDate) 
            : base(id, smeid, title)
        {
            Location = location;
            Hours = hours;
            Startdate = startdate;
            ApplicationDeadline = applicationDeadline;
            EstCompletionDate = estCompletionDate;
        }

        // For when stateID is used. Ex. When making a detailed task:
        public TaskSearched(int id, int smeid, string title, string location, int hours, DateTime startdate,
            DateTime applicationDeadline, DateTime estCompletionDate, int stateID)
            : base(id, smeid, title)
        {
            Location = location;
            Hours = hours;
            Startdate = startdate;
            ApplicationDeadline = applicationDeadline;
            EstCompletionDate = estCompletionDate;
            StateID = stateID;
        }
    }
}
