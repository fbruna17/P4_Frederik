namespace P4Project.Backend.Classes
{
    // This class is an expanded version of the base class. It enables detailed information of an application:
    public class ApplicationDetailed : ApplicationBase
    {
        public string TaskTitle { get; private set; }
        public string SMEName { get; private set; }
        public string StudentName { get; private set; }
        public string State { get; private set; }

        // This class simply stores the expanded information when called with this constructor:
        public ApplicationDetailed(ApplicationBase thisApp, string taskName, string smeName, string studentName, string state)
            : base(thisApp.ApplicationID, thisApp.StudentID, thisApp.TaskID, thisApp.RecScore, thisApp.StateID)
        {
            TaskTitle = taskName;
            SMEName = smeName;
            StudentName = studentName;
            State = state;
        }

        // An instance can be initiated with an instanse of ApplicationBase:
        public ApplicationDetailed(ApplicationBase thisApp)
             : base(thisApp.ApplicationID, thisApp.StudentID, thisApp.TaskID, thisApp.RecScore, thisApp.StateID)
        {
            // The detailed informations are by the object itself:
            GetDetailedInformation();
        }

        // The method that call for the detailed information
        private void GetDetailedInformation()
        {
            SQLControl sql = new SQLControl();
            TaskTitle = sql.FetchApplicationTaskTitle(TaskID);
            SMEName = sql.FetchApplicationSMEName(TaskID);
            StudentName = sql.FetchApplicationStudentName(StudentID);
            State = sql.FetchApplicationStateName(StateID);            
        }

        // Method that makes the string of arrays for when a detailed application is shown in DataViewGrid:
        public string[] MakeDataViewGridStudent()
        {
            string[] output = { TaskTitle, State, SMEName };
            return output;
        }
    }
}
