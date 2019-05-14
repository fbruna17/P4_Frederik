using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    // Dette er superklassen for Tasks:
    class TaskBase
    {
        public int ID { get; }
        public string Title { get; }
        public int SMEID { get; }

        public TaskBase(int id)
        {
            ID = id;
        }
        // Base klassen kan også håndterer hvis der kommer et SMEID med:
        public TaskBase(int id, int smeID)
        {
            ID = id;
            SMEID = smeID;
        }
        // Og hvis der kommer title med:
        public TaskBase(int id, int smeID, string title)
        {
            ID = id;
            SMEID = smeID;
            Title = title;
        }
    }
}
