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
        public string Title { get; }
        public string Location { get; }
        public int Hours { get; }

        // Denne konstrukter bruges KUN ved instansiering af DetailedClass:
        public TaskSearched(int id, int smeID) : base(id, smeID)
        {

        }
        // Den constructer der normalt vil bruges til denne klasse:
        // Det forventes at den behøvede data allerede er blevet hentet i et databasekald:
        public TaskSearched(int id, int smeID, string title, string location, int hours) : base(id, smeID)
        {
            Title = title;
            Location = location;
            Hours = hours;
        }
    }
}
