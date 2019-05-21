using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    // Denne klasse bruges til at opbevare data til en task der blot skal vise få informationer (for eksempel i "SearchViewed")
    public class TaskSearched : TaskBase
    {
        public string Location { get; }
        public int Hours { get; }
        public DateTime Startdate { get; }
        public DateTime ApplicationDeadline { get; }
        public DateTime EstCompletionDate { get; }
        public int StateID { get; }

        // Den constructer der normalt vil bruges til denne klasse:
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
        // Constructer der bruges når f.eks. SMEs skal have hentet alle deres tasks, eller når man søger en DetailedTask (StateID tilføjes):
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

        public string[] MakeDataViewString()
        {
            string[] output = { Title, SMEName, ApplicationDeadline.ToShortDateString(), Startdate.ToShortDateString(), EstCompletionDate.ToShortDateString() };
            return output;
        }

        // DataGridView for Public/Private
        public string[] MakeDataViewStringPublicPrivate()
        {
            string[] output = { Title, SMEName, ApplicationDeadline.ToShortDateString(), Startdate.ToShortDateString(), EstCompletionDate.ToShortDateString() };
            return output;
        }

        // DataGridView for Ongoing/Completed
        public string[] MakeDataViewStringOngoingCompleted()
        {
            string[] output = { Title, SMEName, ApplicationDeadline.ToShortDateString(), Startdate.ToShortDateString(), EstCompletionDate.ToShortDateString() };
            return output;
        }

        // DataGridView for All Task
        public string[] MakeDataViewStringAll()
        {
            string[] output = { Title, SMEName, ApplicationDeadline.ToShortDateString(), Startdate.ToShortDateString(), EstCompletionDate.ToShortDateString() };
            return output;
        }
    }
}
