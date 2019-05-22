namespace P4Project.Backend.Classes
{
    // This class resembles a Struct containing base information of an application:
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
