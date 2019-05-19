using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using P4Project.Exceptions;
using P4Project.Backend.Classes;
using System.Data;

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
            if(Connection.State != ConnectionState.Open)
            {
                Connection.Close();
                Connection.Open();
            }
        }

        public void Close()
        {
            Connection.Close();
        }
        // En funktion der sikrer at der ikke opstår exceptione hvis feltet i databasen er null:
        private string GetSafeString(MySqlDataReader reader, int index)
        {
            if (!reader.IsDBNull(index)) return reader.GetString(index);
            return string.Empty;
        }
        // En funktion der sikrer at der ikke opstår exception hvis et Int felt er null i databasen:
        private int GetSafeInt(MySqlDataReader reader, int index)
        {
            if (!reader.IsDBNull(index)) return reader.GetInt32(index);
            return 0;
        }

        private int GetSafeIntMustNotBeNull(MySqlDataReader reader, int index)
        {
            if (!reader.IsDBNull(index)) return reader.GetInt32(index);
            throw new DataErrorInDataBaseException();
        }
        #endregion

        #region SME-specific SQL
        public void RegisterSMEProfile(string img_SME, string companyName, string email, string password, string username)
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
                cmd.CommandText = "INSERT INTO SME(Name,Email,Password,Image_Dir,Username) VALUES(@Name,@Email,@Password,@Image_Dir,@Username)";
                cmd.Prepare();

                // Parametrene tilføjes:
                cmd.Parameters.AddWithValue("@Image_Dir", img_SME);
                cmd.Parameters.AddWithValue("@Name", companyName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Username", username);
                // Kaldet udføres, og SME profilen bliver tilføjet til databasen:
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // Forbindelsen lukkes:
                if (Connection != null) Close();
            }
        }

        public SMEDetailed FetchSMEDetailedInformation(int smeID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT Name,Email,Description,LogoDIR FROM SME WHERE SMEID = @SMEID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@SMEID", smeID);

                var reader = cmd.ExecuteReader();
                reader.Read();
                string name = GetSafeString(reader, 0);
                string email = GetSafeString(reader, 1);
                string description = GetSafeString(reader, 2);
                //byte[] logo = reader.GetByte(3); // Halp!
                byte[] logo = new byte[1];
                // Readeren lukkes:
                reader.Close();
                var tempSME = new SMEBase(smeID, name, email);
                List<TaskSearched> tasks = FetchAllTasksForSME(tempSME);
                var SME = new SMEDetailed(smeID, name, email, tasks, logo, description);
                return SME;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        public string FetchSMEName(int smeID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT Name FROM SME WHERE SMEID = @SMEID LIMIT 1"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@SMEID", smeID);

                var reader = cmd.ExecuteReader();
                string name = string.Empty;
                while (reader.Read())
                {
                    name = GetSafeString(reader, 0);
                }
                reader.Close();
                return name;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }
        #endregion

        #region Student-specific SQL
        public void RegisterStudentProfile(string username, string password, string firstname, string lastname, string email, string img)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "INSERT INTO Student(Username,Password,Firstname,Lastname,Email,Image_Dir) VALUES(@Username,@Password,@Firstname,@Lastname,@Email,@Image_Dir)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Image_Dir", img);
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

        public StudentDetailed FetchStudentDetailed(int id)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT FirstName,LastName,Email,Description,EducationID,Image_Dir,Unverified_SkillSet,Verified_SkillSet FROM Student WHERE StudentID = @StudentID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@StudentID", id);

                var reader = cmd.ExecuteReader();
                reader.Read();
                string firstname = GetSafeString(reader, 0);
                string lastname = GetSafeString(reader, 1);
                string email = GetSafeString(reader, 2);
                string description = GetSafeString(reader, 3);
                int eduID = GetSafeInt(reader, 4);
                string profilepicture = GetSafeString(reader, 5);
                var suvSkills = GetSafeString(reader, 6).Split(',').ToList();
                var svSkills = GetSafeString(reader, 7).Split(',').ToList();
                // Readeren lukkes:
                reader.Close();
                // Skill listerne laves:
                var uvSkills = new List<SkillStudent>();
                var vSkills = new List<SkillStudent>();
                if (suvSkills[0] != string.Empty)
                {
                    uvSkills = MakeStudentSkillList(FetchSkillInfo(StringListToIntList(suvSkills)), false);
                }
                if (svSkills[0] != string.Empty)
                {
                    vSkills = MakeStudentSkillList(FetchSkillInfo(StringListToIntList(svSkills)), true);
                }

                List<SkillStudent> skills = uvSkills.Concat(vSkills).ToList();
                // Education navnet findes:
                string education = string.Empty;
                if (eduID != 0) education = GetEducationName(eduID);

                var student = new StudentDetailed(firstname, lastname, id, email, education, skills, description, profilepicture);
                return student;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }
        #endregion

        #region Task-specific SQL
        public List<Skill> FetchAllSkills()
        {
            var resList = new List<Skill>();
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT SkillID,SkillName,Category FROM Skill"
                };
                cmd.Prepare();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int skillid = reader.GetInt32(0);
                    string skillname = reader.GetString(1);
                    string category = reader.GetString(2);
                    resList.Add(new Skill(skillid, skillname, category));
                }
                return resList;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }
        // Funktion der henter de skills der er Required for en task:
        public List<int> FetchRequiredSkills(int taskID)
        {
            var resList = new List<int>();
            string resString = string.Empty;
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
                while(reader.Read()) 
                {
                    resString = GetSafeString(reader, 0);
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
                if (s == "" && s == string.Empty) { }
                else if (int.TryParse(s, out int i)) resList.Add(i);
                else throw new DataErrorInDataBaseException();
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
                        CommandText = "SELECT SkillName,Category FROM Skill WHERE SkillID = @SkillID LIMIT 1"
                    };
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@SkillID", skillID);
                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    string skillName = GetSafeString(reader, 0);
                    string category = GetSafeString(reader, 1);
                    resList.Add(new Skill(skillID, skillName, category));
                    reader.Close();
                }
                return resList;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Funktion der henter detailed view af en task:
        public TaskDetailed FetchTaskDetailed(int taskID)
        {
            // Resultats variablen declareres:
            TaskDetailed result;
            try
            {
                // Der laves en liste af de required skills:
                List<int> reqSkillIDs = FetchRequiredSkills(taskID);
                List<Skill> reqSkills = FetchSkillInfo(reqSkillIDs);

                // Variablerne der skal bruges til opbevaring af dataene initialiseres:
                int smeID = 0;
                string title = string.Empty;
                string location = string.Empty;
                int hours = 0;
                DateTime startDate = DateTime.Now;
                DateTime applicationDeadline = DateTime.Now;
                DateTime estCompletion = DateTime.Now;
                int stateID = 0;
                string description = string.Empty;
                int assignedStudent = 0;

                // Forbindelsen åbnes:
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT SMEID,Title,Location,Hours,StartDate,Application_Deadline,Completion,StateID,Description,Assigned_Student FROM Task WHERE TaskID = @TaskID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);

                // Readeren gøres klar:
                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    smeID = GetSafeIntMustNotBeNull(reader, 0);
                    title = GetSafeString(reader, 1);
                    location = GetSafeString(reader, 2);
                    hours = GetSafeInt(reader, 3);
                    startDate = reader.GetDateTime(4);
                    applicationDeadline = reader.GetDateTime(5);
                    estCompletion = reader.GetDateTime(6);
                    stateID = GetSafeInt(reader, 7);
                    description = GetSafeString(reader, 8);
                    assignedStudent = GetSafeInt(reader, 9);
                }
                reader.Close();
                // Resultatet instansieres og returneres:
                SMEBase owner = FetchSMEBaseInformation(smeID);
                return result = new TaskDetailed(taskID, owner, title, location, hours, description, startDate, applicationDeadline, estCompletion, stateID, reqSkills, assignedStudent);
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Funktion der henter alle tasks lavet af en given SME:
        public List<TaskSearched> FetchAllTasksForSME(SMEBase owner)
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
                cmd.Parameters.AddWithValue("@SMEID", owner.ID);

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
                    taskList.Add(new TaskSearched(taskID, owner, title, location, hours, startDate, applicationDeadline, estCompletion, stateID));
                }
            }
            finally
            {
                if (Connection != null) Close();
            }
            return taskList;
        }

        // Henter alle tasks en given student er Assigned til, ud fra en givent State:    BLIVER IKKE BRUGT / SKAL IKKE BRUGES / VIRKER IKKE CURRENTLY
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
                    SMEBase owner = FetchSMEBaseInformation(reader.GetInt32(1));
                    string title = reader.GetString(2);
                    string location = reader.GetString(3);
                    int hours = reader.GetInt32(4);
                    DateTime startDate = reader.GetDateTime(5);
                    DateTime applicationDeadline = reader.GetDateTime(6);
                    DateTime estCompletion = reader.GetDateTime(7);
                    result.Add(new TaskSearched(taskID, owner, title, location, hours, startDate, applicationDeadline, estCompletion, stateID));
                }
            }
            finally
            {
                if (Connection != null) Close();
            }

            return result;
        }

        // Henter alle tasks en given student har applied for:    BLIVER IKKE BRUGT / SKAL IKKE BRUGES / VIRKER IKKE CURRENTLY
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
                        SMEBase owner = FetchSMEBaseInformation(reader.GetInt32(0));
                        string title = reader.GetString(1);
                        string location = reader.GetString(2);
                        int hours = reader.GetInt32(3);
                        DateTime startDate = reader.GetDateTime(4);
                        DateTime applicationDeadline = reader.GetDateTime(5);
                        DateTime estCompletion = reader.GetDateTime(6);
                        result.Add(new TaskSearched(i, owner, title, location, hours, startDate, applicationDeadline, estCompletion));
                    }
                }
            }
            finally
            {
                if (Connection != null) Close();
            }

            return result;
        }
        // Funtkion til at hente applications for en given student:
        public List<ApplicationBase> FetchStudentAppliedBaseInfo(int studentID)
        {
            try
            {
                // ResList is initialized:
                List<ApplicationBase> resList = new List<ApplicationBase>();
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT ApplicationID,TaskID,RecScore,AppState FROM Application WHERE StudentID = @StudentID" // Tilføj RecScore!!!!
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@StudentID", studentID);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // For hver linje initialiseres der en ny AppBase, der tilføjes til listen:
                    resList.Add(new ApplicationBase(GetSafeIntMustNotBeNull(reader, 0), studentID, 
                        GetSafeIntMustNotBeNull(reader, 1), GetSafeInt(reader, 2), GetSafeIntMustNotBeNull(reader, 3)));
                }
                return resList;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        public string FetchApplicationStateName(int stateID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT AppStateName FROM ApplicationState WHERE AppStateID = @AppStateID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@AppStateID", stateID);

                string res = string.Empty;

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    res = GetSafeString(reader, 0);
                }
                if (res == string.Empty) throw new DataErrorInDataBaseException("STATE");
                else return res;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        public string FetchApplicationTaskTitle(int taskID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT Title FROM Task WHERE TaskID = @TaskID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);

                string res = string.Empty;

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    res = GetSafeString(reader, 0);
                }
                if (res == string.Empty) throw new DataErrorInDataBaseException("TASKTITLE");
                else return res;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        public string FetchApplicationSMEName(int taskID)
        {
            try
            {
                Open();
                // Først hente SMEID: 
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT SMEID FROM Task WHERE TaskID = @TaskID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);

                int smeID = 0;

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    smeID = GetSafeIntMustNotBeNull(reader, 0);
                }
                reader.Close();

                // Nu findes navnet på SMEen:
                cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT Name FROM SME WHERE SMEID = @SMEID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@SMEID", smeID);

                string res = string.Empty;

                var readerV2 = cmd.ExecuteReader();
                while (readerV2.Read())
                {
                    res = GetSafeString(readerV2, 0);
                }
                if (res == string.Empty) throw new DataErrorInDataBaseException("SMENAME");
                else return res;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        public string FetchApplicationStudentName(int studentID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT FirstName,LastName FROM Student WHERE StudentID = @StudentID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@StudentID", studentID);

                string res = string.Empty;

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    res = GetSafeString(reader, 0) + " " + GetSafeString(reader, 1);
                }
                if (res == " ") throw new DataErrorInDataBaseException("STUDENTNAME");
                else return res;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }


        // Henter alle public tasks og gør dem klar til recommendation:
        public List<TaskRecommend> FetchAllTasksForRecommendation()
        {
            try
            {
                Open();
                // Kommandoen gøres klar:
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT TaskID,Title,SMEID,Required_Skill FROM Task WHERE StateID = @StateID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@StateID", 2);
                var reader = cmd.ExecuteReader();
                // Der initialiseres variabler til håndtering af den midlertidige data:
                var tempTaskList = new List<TaskBase>();
                // Denne liste kommer til at indeholde den samlede liste over ALLE recquired skills:
                List<string> recSkill = new List<string>();
                while (reader.Read())
                {
                    int taskID = GetSafeIntMustNotBeNull(reader, 0);
                    string title = GetSafeString(reader, 1);
                    int smeID = GetSafeIntMustNotBeNull(reader, 2);
                    recSkill.Add(GetSafeString(reader, 3));
                    tempTaskList.Add(new TaskBase(taskID, smeID, title));
                }
                // Denne liste kommer til at indeholde alle de tasks der er hentet:
                List<TaskRecommend> resultList = new List<TaskRecommend>();
                // Der er nu lavet en liste af Base tasks, de skal nu parres med de recquired skills: 
                int i = 0;
                foreach(TaskBase task in tempTaskList)
                {
                    task.GetSMEName();
                    List<int> tRecSkillIDs = new List<int>();
                    List<string> tRecSkill = recSkill[i].Split(',').ToList();
                    foreach(string skillID in tRecSkill)
                    {
                        if (skillID == "" && skillID == string.Empty);
                        else if (int.TryParse(skillID, out int ID)) tRecSkillIDs.Add(ID);
                        else throw new DataErrorInDataBaseException("TryParse on skillID: " + skillID + i.ToString());
                    }
                    List<Skill> skills = FetchSkillInfo(tRecSkillIDs);
                    resultList.Add(new TaskRecommend(task, skills));
                }
                return resultList;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Funktion der henter alle Applied Students til en given task:
        public List<StudentApplicant> FetchApplicantsForTask(int taskID)
        {          
            
            try
            {
                List<StudentApplicant> result = new List<StudentApplicant>();
                List<int> studentIDs = new List<int>();
                List<int> recScore = new List<int>();
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT StudentID,RecScore FROM Application WHERE TaskID = @TaskID" // TIlføj RecommendationScore
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    studentIDs.Add(GetSafeIntMustNotBeNull(reader, 0));
                    recScore.Add(GetSafeIntMustNotBeNull(reader, 1));
                }
                reader.Close();
                int count = 0;
                foreach (int i in studentIDs)
                {                    
                    cmd.CommandText = "SELECT FirstName,LastName,Email,Image_Dir FROM Student WHERE StudentID = @StudentID";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@StudentID", i);
                    var readerV2 = cmd.ExecuteReader();
                    while (readerV2.Read())
                    {
                        string firstName = GetSafeString(readerV2, 0);
                        string lastName = GetSafeString(readerV2, 1);
                        string email = GetSafeString(readerV2, 2);
                        string profilePicture = GetSafeString(readerV2, 3);
                        result.Add(new StudentApplicant(firstName, lastName, i, email, profilePicture, recScore[count]));
                        count++;
                    }
                    readerV2.Close();
                }
                return result;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Funktion der laver en ny entry i application: 
        public void PostApplication(int studentID, int taskID, int recScore) // Tilføj RecommendationScore!!!!
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "INSERT INTO Application(TaskID,StudentID,RecScore,AppState) VALUES(@TaskID,@StudentID,@RecScore,@AppState)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@TaskID", taskID);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@RecScore", recScore);
                cmd.Parameters.AddWithValue("@AppState", 1);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Funktion der fjerner en application:
        public void RemoveApplication(int applicationID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "DELETE FROM Application WHERE ApplicationID = @ApplicationID";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }


        #endregion

        #region Skills
 
        private List<SkillStudent> MakeStudentSkillList(List<Skill> skills, bool verified)
        {
            List<SkillStudent> res = new List<SkillStudent>();
            foreach(Skill skill in skills)
            {
                res.Add(new SkillStudent(skill.ID, skill.Name, skill.Category, verified));
            }
            return res;
        }
        #endregion

        private string GetEducationName(int eduID)
        {
            string EducationName = string.Empty;
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT EduName FROM Education WHERE EducationID = @EducationID LIMIT 1"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@EducationID", eduID);
                var reader = cmd.ExecuteReader();
                // This While makes sure that CPU threats are not running the GetSafeString, before .Read() is executed.
                while(reader.Read())
                {
                    EducationName = GetSafeString(reader, 0);

                }
                return EducationName;

            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        public string LogInRequest(string username, string password, string table)
        {
            string ID = string.Empty;
            string column;
            try
            {
                if (table == "Student") column = "StudentID";
                else column = "SMEID";
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT " + column +" FROM " + table + " WHERE Username = @Username AND Password = @Password"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ID = GetSafeString(reader, 0);
                }
            }
            finally
            {
                if (Connection != null) Close();
            }
            return ID;
        }

        //
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

        public void CreateNewTask(TaskDetailed thisTask)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "INSERT INTO Task(SMEID,Title,Description,StartDate,Location,Application_Deadline,Completion,Hours,StateID) " +
                    "VALUES (@sme,@title,@description,@startdate,@location,@applicationdeadline,@completion,@hours,@stateID)"
                };
                cmd.Prepare();

                // Parametrene tilføjes:
                cmd.Parameters.AddWithValue("@sme", thisTask.Owner.ID);
                cmd.Parameters.AddWithValue("@title", thisTask.Title);
                cmd.Parameters.AddWithValue("@description", thisTask.Description);
                cmd.Parameters.AddWithValue("@startdate", thisTask.Startdate);
                cmd.Parameters.AddWithValue("@location", thisTask.Location);
                cmd.Parameters.AddWithValue("@applicationdeadline", thisTask.ApplicationDeadline);
                cmd.Parameters.AddWithValue("@completion", thisTask.EstCompletionDate);
                cmd.Parameters.AddWithValue("@hours", thisTask.Hours);
                cmd.Parameters.AddWithValue("@stateID", thisTask.StateID);
                // Kaldet udføres, og tasken bliver tilføjet til databasen:
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // Forbindelsen lukkes:
                if (Connection != null) Close();
            }
        }

        private List<int> StringListToIntList(List<string> strings)
        {
            List<int> res = new List<int>();
            foreach(string s in strings)
            {
                if (int.TryParse(s, out int i)) res.Add(i);
                else throw new DataErrorInDataBaseException();
            }
            return res;
        }
    }
}
