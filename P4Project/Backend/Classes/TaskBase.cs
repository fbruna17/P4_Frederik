namespace P4Project.Backend.Classes
{
    // This is the superclass for all tasks, and is used as a struct for base information regarding a task:
    public class TaskBase
    {
        public int ID { get; }
        public string Title { get; }
        public int SMEID { get; }
        public string SMEName { get; protected set; }

        // Base Constructer:
        public TaskBase(int id, int smeID, string title)
        {
            ID = id;
            SMEID = smeID;
            Title = title;
        }
        // Constructer if the SMEName is already known::
        public TaskBase(int id, int smeID, string title, string smeName)
        {
            ID = id;
            SMEID = smeID;
            Title = title;
            SMEName = smeName;
        }

        // Method that sets, and return the Name of the SMEOwner:
        public string GetSMEName()
        {
            SQLControl sql = new SQLControl();
            SMEName = sql.FetchSMEName(SMEID);
            return SMEName;
        }
    }
}
