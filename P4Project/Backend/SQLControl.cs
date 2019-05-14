using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using P4Project.Exceptions;
using P4Project.Backend.Classes;

namespace P4Project
{
    class SQLControl
    {
        #region Instance Variables & Properties
        private string MyConnectionString = "server=mysql33.unoeuro.com;uid=blo_store_dk;pwd=3pdaxzyt;database=blo_store_dk_db_wd";
        private MySqlConnection Connection { get; set; }
        #endregion

        #region Constructor(s)
        public SQLControl()
        {
            Connection = new MySqlConnection(MyConnectionString);
        }
        #endregion

        #region Universal SQL
        public void Open()
        {
            Connection.Open();
        }

        public void Close()
        {
            Connection.Close();
        }
        #endregion

        #region SME-specific SQL
        public void RegisterSMEProfile(byte[] img_SME, string companyName, string email, string password)
        {
            // MySQL commandoen udføres:
            try
            {
                // Forbindelsen åbnes:
                Open();
                //Der initialiseres en instans til command håndtering:
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                // Commandoen defineres og forberedes:
                cmd.CommandText = "INSERT INTO SME(Name,Email,Password,LogoDIR) VALUES(@Name,@Email,@Password,@LogoDIR)";
                cmd.Prepare();

                // Parametrene tilføjes:
                cmd.Parameters.AddWithValue("@LogoDIR", img_SME);
                cmd.Parameters.AddWithValue("@Name", companyName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                // Kaldet udføres, og SME profilen bliver tilføjet til databasen:
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // Forbindelsen lukkes:
                if (Connection != null) Close();
            }
        }
        #endregion

        #region Student-specific SQL
        public void AddStudent(string firstname, string lastname, string email, byte[] img)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "INSERT INTO Student(Firstname,Lastname,Email,Profile_Picture) VALUES(@Firstname,@Lastname,@Email,@Profile_Picture)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Profile_Picture", img);
                cmd.Parameters.AddWithValue("@Firstname", firstname);
                cmd.Parameters.AddWithValue("@Lastname", lastname);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

      //  public StudentDetailed FetchStudentDetailed(int id)
      //  {
      //      StudentDetailed res
      //      return 
      //  }
        #endregion

        #region Task-specific SQL
        // Funktion der henter de skills der er Required for en task:
        public List<int> FetchRequiredSkills(int taskID)
        {
            var resList = new List<int>();
            string resString = "";
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT Required_Skill FROM Task WHERE TaskID = @TaskID LIMIT 1"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resString += reader.GetString(0);
                }
            }
            finally
            {
                if (Connection != null) Close();
            }
            // Strengen fra SQL kaldet deles op ved , :
            string[] tempres = resString.Split(',');
            foreach(string s in tempres)
            {   // Der burde nu blot være tale om ints, så de tilføjes til resultats listen og returneres:
                if(int.TryParse(s, out int i))
                {
                    resList.Add(i);
                }
            }
            return resList;
        }

        public List<Skill> FetchSkillInfo(List<int> skillIDs)
        {
            var resList = new List<Skill>();
            try
            {
                Open();
                foreach (int skillID in skillIDs)
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        Connection = Connection,
                        CommandText = "SELECT SkillName,Catagory FROM Skill WHERE SkillID = @SkillID"
                    };
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@SkillID", skillID);
                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    string skillName = reader.GetString(0);
                    string catagory = reader.GetString(1);
                    resList.Add(new Skill(skillID, skillName, catagory));
                }
            }
            finally
            {
                if (Connection != null) Close();
            }
            return resList;
        }

        // Funktion der henter detailed view af en task:
        public TaskDetailed FetchTaskDetailed(int taskID)
        {
            // Resultats variablen declareres:
            TaskDetailed result;
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT SMEID,Title,Location,Hours,StartDate,Application_Deadline,Completion,StateID,Description FROM Task WHERE TaskID = @TaskID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);

                // Readeren gøres klar:
                var reader = cmd.ExecuteReader();
                reader.Read();

                // Der laves en liste af de required skills:
                List<int> reqSkillIDs = FetchRequiredSkills(taskID);
                List<Skill> reqSkills = FetchSkillInfo(reqSkillIDs);
                // Dataen samles:
                int smeID = reader.GetInt32(0);
                string title = reader.GetString(1);
                string location = reader.GetString(2);
                int hours = reader.GetInt32(3);
                DateTime startDate = reader.GetDateTime(4);
                DateTime applicationDeadline = reader.GetDateTime(5);
                DateTime estCompletion = reader.GetDateTime(6);
                int stateID = reader.GetInt32(7);
                string description = reader.GetString(8);
                // Resultatet instansieres og returneres:
                return result = new TaskDetailed(taskID, smeID, title, location, hours, description, startDate, applicationDeadline, estCompletion, stateID, reqSkills);
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Funktion der henter alle tasks lavet af en given SME:
        public List<TaskSearched> FetchAllTasksForSME(int smeID)
        {
            var taskList = new List<TaskSearched>();

            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT TaskID,Title,Location,Hours,StartDate,Application_Deadline,Completion,StateID FROM Task WHERE SMEID = @SMEID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@SMEID", smeID);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int taskID = reader.GetInt32(0);
                    string title = reader.GetString(1);
                    string location = reader.GetString(2);
                    int hours = reader.GetInt32(3);
                    DateTime startDate = reader.GetDateTime(4);
                    DateTime applicationDeadline = reader.GetDateTime(5);
                    DateTime estCompletion = reader.GetDateTime(6);
                    int stateID = reader.GetInt32(7);
                    taskList.Add(new TaskSearched(taskID, smeID, title, location, hours, startDate, applicationDeadline, estCompletion, stateID));
                }
            }
            finally
            {
                if (Connection != null) Close();
            }
            return taskList;
        }
        
        // Henter alle tasks en given student er Assigned til, ud fra en givent State: 
        public List<TaskSearched> FetchStudentAssignedTasks(int studentID, int stateID)
        {
            var result = new List<TaskSearched>();

            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT TaskID,SMEID,Title,Location,Hours,StartDate,Application_Deadline,Completion FROM Task WHERE Assigned_Student = @Assigned_Student AND StateID = @StateID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Assigned_Student", studentID);
                cmd.Parameters.AddWithValue("@StateID", stateID);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int taskID = reader.GetInt32(0);
                    int smeID = reader.GetInt32(1);
                    string title = reader.GetString(2);
                    string location = reader.GetString(3);
                    int hours = reader.GetInt32(4);
                    DateTime startDate = reader.GetDateTime(5);
                    DateTime applicationDeadline = reader.GetDateTime(6);
                    DateTime estCompletion = reader.GetDateTime(7);
                    result.Add(new TaskSearched(taskID, smeID, title, location, hours, startDate, applicationDeadline, estCompletion, stateID));
                }
            }
            finally
            {
                if (Connection != null) Close();
            }

            return result;
        }

        // Henter alle tasks en given student har applied for:
        public List<TaskSearched> FetchStudentAppliedForTasks(int studentID)
        {
            var result = new List<TaskSearched>();
            var taskIDs = new List<int>();
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT TaskID FROM Application WHERE StudentID = @StudentID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@StudentID", studentID);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    taskIDs.Add(reader.GetInt32(0));
                }
                foreach (int i in taskIDs)
                {
                    cmd.CommandText = "SELECT SMEID,Title,Location,Hours,StartDate,Application_Deadline,Completion FROM Task WHERE TaskID = @TaskID";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@TaskID", i);
                    while(reader.Read())
                    {
                        int smeID = reader.GetInt32(0);
                        string title = reader.GetString(1);
                        string location = reader.GetString(2);
                        int hours = reader.GetInt32(3);
                        DateTime startDate = reader.GetDateTime(4);
                        DateTime applicationDeadline = reader.GetDateTime(5);
                        DateTime estCompletion = reader.GetDateTime(6);
                        result.Add(new TaskSearched(i, smeID, title, location, hours, startDate, applicationDeadline, estCompletion));
                    }
                }
            }
            finally
            {
                if (Connection != null) Close();
            }

            return result;
        }
        #endregion

        public string SMELogInRequest(string username, string password)
        {
            string SMEID = "";
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT SMEID FROM SME WHERE Name = @Name AND Password = @Password"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", username);
                cmd.Parameters.AddWithValue("@Password", password);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SMEID = reader.GetString(0);
                }
            }
            finally
            {
                if (Connection != null) Close();
            }
            return SMEID;
        }



        public SMEBase FetchSMEBaseInformation(int ID)
        {
            string name = "";
            string email = "";
            // string profilePicturePath = "";

            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT Name,Email FROM SME WHERE SMEID = @SMEID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@SMEID", ID);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    email = reader.GetString(1);
                }
                var SME = new SMEBase(ID, name, email);
                return SME;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        public void CreateNewTask(int SMEID, string title, string description, string location)
        {
            // MySQL commandoen udføres:
            try
            {
                // Forbindelsen åbnes:
                Open();
                //Der initialiseres en instans til command håndtering:
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    // Commandoen defineres og forberedes:
                    CommandText = "INSERT INTO Task(SMEID,Title,Description,Location) VALUES (@sme,@title,@description,@location)"
                };
                cmd.Prepare();

                // Parametrene tilføjes:
                cmd.Parameters.AddWithValue("@sme", SMEID);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@location", location);
                // Kaldet udføres, og tasken bliver tilføjet til databasen:
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // Forbindelsen lukkes:
                if (Connection != null) Close();
            }
        }
    }
}
