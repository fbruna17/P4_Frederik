using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    public class ApplicationDetailed : ApplicationBase
    {
        public string TaskTitle { get; private set; }
        public string SMEName { get; private set; }
        public string StudentName { get; private set; }
        public string State { get; private set; }

        // Denne klasse bruges til at opbevare detaljerede info om en application:
        public ApplicationDetailed(ApplicationBase thisApp, string taskName, string smeName, string studentName, string state)
            : base(thisApp.ApplicationID, thisApp.StudentID, thisApp.TaskID, thisApp.RecScore, thisApp.StateID)
        {
            TaskTitle = taskName;
            SMEName = smeName;
            StudentName = studentName;
            State = state;
        }
        // En Constructer der bruges til at objektet selv finder de resterende oplysninger ud fra AppBase:
        public ApplicationDetailed(ApplicationBase thisApp)
             : base(thisApp.ApplicationID, thisApp.StudentID, thisApp.TaskID, thisApp.RecScore, thisApp.StateID)
        {
            GetDetailedInformation();
        }

        // Funktion der henter detailed information:
        private void GetDetailedInformation()
        {
            SQLControl sql = new SQLControl();

            TaskTitle = sql.FetchApplicationTaskTitle(TaskID);
            SMEName = sql.FetchApplicationSMEName(TaskID);
            StudentName = sql.FetchApplicationStudentName(StudentID);
            State = sql.FetchApplicationStateName(StateID);            
        }

        // Funktion der returnerer en string der kan bruges i DataViewGrid:
        public string[] MakeDataViewGridStudent()
        {
            string[] output = { TaskTitle, State, SMEName };
            return output;
        }
    }
}
