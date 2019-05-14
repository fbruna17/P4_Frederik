using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    // Denne klasse bruges til at håndterer alle detaljerne der er om en task:
    class TaskDetailed : TaskSearched
    {
        private List<int> RequiredSkills { get; }
        public string Description { get; }


        // Denne constructer tager alle de nødvendige informationer for at kunne displaye en Task for en bruger:
        public TaskDetailed(int id, int smeID, string title, string location, int hours, string description, 
                               DateTime startdate, DateTime applicationDeadline, DateTime estCompletionDate, List<int> requiredSkills) 
                               : base(id, smeID, title, location, hours, startdate, applicationDeadline, estCompletionDate)
        {
            // Dataene ligges i de korrekte properties:
            RequiredSkills = requiredSkills;
            Description = description;
        }
    }
}
