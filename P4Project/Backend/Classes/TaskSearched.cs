using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    // Denne klasse bruges til at opbevare data til en task der blot skal vise få informationer (for eksempel i "SearchViewed")
    class TaskSearched : TaskBase
    {
        public string Location { get; }
        public int Hours { get; }
        public DateTime Startdate { get; }
        public DateTime ApplicationDeadline { get; }
        public DateTime EstCompletionDate { get; }
        public int StateID { get; }
        public SMEBase Owner { get; }

        // Den constructer der normalt vil bruges til denne klasse:
        public TaskSearched(int id, SMEBase owner, string title, string location, int hours, DateTime startdate, 
            DateTime applicationDeadline, DateTime estCompletionDate) 
            : base(id, owner.ID, title)
        {
            Location = location;
            Hours = hours;
            Startdate = startdate;
            ApplicationDeadline = applicationDeadline;
            EstCompletionDate = estCompletionDate;
            Owner = owner;
        }
        // Constructer der bruges når f.eks. SMEs skal have hentet alle deres tasks, eller når man søger en DetailedTask (StateID tilføjes):
        public TaskSearched(int id, SMEBase owner, string title, string location, int hours, DateTime startdate,
            DateTime applicationDeadline, DateTime estCompletionDate, int stateID)
            : base(id, owner.ID, title)
        {
            Location = location;
            Hours = hours;
            Startdate = startdate;
            ApplicationDeadline = applicationDeadline;
            EstCompletionDate = estCompletionDate;
            StateID = stateID;
            Owner = owner;
        }
    }
}
