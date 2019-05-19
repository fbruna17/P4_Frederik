using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    // Denne klasse bruges som super klasse til Applications. Den indeholder de informationer i de typer der er i databasen:
    public class ApplicationBase
    {
        public int ApplicationID { get; }
        public int StudentID { get; }
        public int TaskID { get; }
        public int RecScore { get; }
        public int StateID { get; }

        public ApplicationBase(int applicationID, int studID, int taskID, int recScore, int stateID)
        {
            ApplicationID = applicationID;
            StudentID = studID;
            TaskID = taskID;
            RecScore = recScore;
            StateID = stateID;
        }

    }
}
