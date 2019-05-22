using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using P4Project.Exceptions;
using P4Project.Backend.Classes;
using System.Data;

namespace P4Project
{
    // This Class handles ALL call to the database:
    class SQLControl
    {
        // The Connection, and the connection string is defined in this class, as this class is the only class that makes calls to the Database:
        private string MyConnectionString = "server=mysql33.unoeuro.com;uid=blo_store_dk;pwd=3pdaxzyt;database=blo_store_dk_db_wd";
        private MySqlConnection Connection { get; set; }

        // A simple Constructor that initiates the Connection based on the connection string:
        public SQLControl()
        {
            Connection = new MySqlConnection(MyConnectionString);
        }

        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! UNIVERSAL FUNCTIONS !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // Functions that are used in must database calls:

        #region Universal SQL

        // a New Open() Function is made, that ensures that a new connection is opened:
        public void Open()
        {
            if(Connection.State != ConnectionState.Open)
            {
                Connection.Close();
                Connection.Open();
            }
        }

        // Simple Close:
        public void Close()
        {
            Connection.Close();
        }

        // A function that safely retrieves a string from the reader, and returns an empty string if the entry in the database is null to prevent exceptions:
        private string GetSafeString(MySqlDataReader reader, int index)
        {
            if (!reader.IsDBNull(index)) return reader.GetString(index);
            return string.Empty;
        }

        // A function much like the one above, just with ints:
        private int GetSafeInt(MySqlDataReader reader, int index)
        {
            if (!reader.IsDBNull(index)) return reader.GetInt32(index);
            return 0;
        }

        // A function like the one above, however its used when the result should never be == null. If it is it throws an exception to inform the user
        // That there is a fatal error in the database (The exception should never be thrown):
        private int GetSafeIntMustNotBeNull(MySqlDataReader reader, int index)
        {
            if (!reader.IsDBNull(index)) return reader.GetInt32(index);
            throw new DataErrorInDataBaseException();
        }

        // A function that makes a string list into an int list:
        // Used for making the list of skills, as theese are string of ID´s in the format "01,23,12" in the database:
        private List<int> StringListToIntList(List<string> strings)
        {
            List<int> res = new List<int>();
            foreach (string s in strings)
            {
                if(s == null || s == string.Empty || s == " " || s == "") { }
                else if (int.TryParse(s, out int i)) res.Add(i);
                else throw new DataErrorInDataBaseException();
            }
            return res;
        }

        // Function that makes a list of skills into a list of skills for students, and sets if they are verified or not:
        public List<SkillStudent> MakeStudentSkillList(List<Skill> skills, bool verified)
        {
            List<SkillStudent> res = new List<SkillStudent>();
            foreach (Skill skill in skills)
            {
                res.Add(new SkillStudent(skill.ID, skill.Name, verified));
            }
            return res;
        }

        // Funktion that makes the string of SkillIDs for database Post:
        private string MakeSkillIDString(List<Skill> skills)
        {
            string result = string.Empty;
            foreach(Skill skill in skills)
            {
                result = result + skill.ID + ',';
            }
            if (result.Length == 0) return result;
            return result.Remove(result.Length - 1);
        }

        #endregion

        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! FETCH FUNCTIONS: !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // In this region are all the functions that Fetch data from the database:

        #region Fetch Functions:

        // .............................................. GENEREL FETCH FUNCTIONS .............................................
        // Funktions used to fetch information for more than one type of user/object:

        #region Generel Fetch:

        // A function that retrieves Information based on Username and password (Handles login requests):
        // Works for both SMEs and Student, as the table name is a parameter:
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
                    CommandText = "SELECT " + column + " FROM " + table + " WHERE Username = @Username AND Password = @Password LIMIT 1"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
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

        #endregion

        // .............................................. SME SPECIFIC FETCH FUNCTIONS .............................................
        // Functions that are used too retrive SME details from the database:

        #region SME-specific Fetch:

        // A function for fetching all details of a specifik SME based on its ID:
        public SMEDetailed FetchSMEDetailedInformation(int smeID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT Name,Email,Image_Dir FROM SME WHERE SMEID = @SMEID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@SMEID", smeID);

                string name = string.Empty;
                string email = string.Empty;
                string logo = string.Empty;

                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    name = GetSafeString(reader, 0);
                    email = GetSafeString(reader, 1);
                    logo = GetSafeString(reader, 2);
                }
                // Reader is closed:
                reader.Close();
                // A temporary storing of the data fetched:
                var tempSME = new SMEBase(smeID, name, email);

                // All tasks related to the SME is fetched:
                List<TaskSearched> tasks = FetchAllTasksForSME(tempSME);
                var SME = new SMEDetailed(smeID, name, email, tasks, logo);
                return SME;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // A function that fetches an SME Name based on the ID. Is used in TaskBase:
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

        // Function that retrieves all tasks made by a specific SME:
        // Used when making a detailed SME instance:
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
                    taskList.Add(new TaskSearched(taskID, owner.ID, title, location, hours, startDate, applicationDeadline, estCompletion, stateID));
                }
                reader.Close();
                return taskList;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }
        #endregion

        // .............................................. STUDENT SPECIFIC FETCH FUNCTIONS .............................................
        // Functions that are used too retrive Student details from the database:

        #region Student-specific Fetch:

        // Function that gets all information on a specific student from the database needed to make an instance of the StudentDetailed Class:
        public StudentDetailed FetchStudentDetailed(int id)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT FirstName,LastName,Email,Description,Education,Image_Dir,Unverified_SkillSet,Verified_SkillSet,Pdf_Dir FROM Student WHERE StudentID = @StudentID LIMIT 1"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@StudentID", id);

                // All variables are declared:
                #region Variable initialising:
                string firstname = string.Empty;
                string lastname = string.Empty;
                string email = string.Empty;
                string description = string.Empty;
                string education = string.Empty;
                string profilepicture = string.Empty;
                List<string> suvSkills = new List<string>();
                List<string> svSkills = new List<string>();
                string resume = string.Empty;
                #endregion

                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    firstname = GetSafeString(reader, 0);
                    lastname = GetSafeString(reader, 1);
                    email = GetSafeString(reader, 2);
                    description = GetSafeString(reader, 3);
                    education = GetSafeString(reader, 4);
                    profilepicture = GetSafeString(reader, 5);
                    suvSkills = GetSafeString(reader, 6).Split(',').ToList();
                    svSkills = GetSafeString(reader, 7).Split(',').ToList();
                    resume = GetSafeString(reader, 8);
                }
                // Reader is closed:
                reader.Close();
                // Making of the skill lists:
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

                // The new student instance is made and returned:
                var student = new StudentDetailed(firstname, lastname, id, email, education, skills, description, profilepicture, resume);
                return student;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Function used to fetch all tasks a student has applied for based on StudentID:
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
                    CommandText = "SELECT ApplicationID,TaskID,RecScore,AppState FROM Application WHERE StudentID = @StudentID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@StudentID", studentID);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Each line read should initialize a new application instance and add it to the result list:
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

        // Function that fetch all tasks a given student is applied for:
        public List<TaskAssigned> FetchStudentAssignedForTasks(int studentID)
        {
            try
            {
                // The result variable is declared:
                List<TaskAssigned> result = new List<TaskAssigned>();
                // Variables are declared:
                #region Variable Declaration:
                int taskID = 0;
                int smeID = 0;
                string title = string.Empty;
                DateTime estCompletion = DateTime.Now;
                int stateID = 0;
                #endregion

                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT TaskID,SMEID,Title,Completion,StateID FROM Task WHERE Assigned_Student = @Assigned_Student"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Assigned_Student", studentID);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    taskID = GetSafeIntMustNotBeNull(reader, 0);
                    smeID = GetSafeIntMustNotBeNull(reader, 1);
                    title = GetSafeString(reader, 2);
                    estCompletion = reader.GetDateTime(3);
                    stateID = GetSafeInt(reader, 4);
                    result.Add(new TaskAssigned(new TaskBase(taskID, smeID, title), estCompletion, stateID));
                }
                reader.Close();
                // SMEName is fethced for each task:
                foreach (TaskAssigned task in result)
                {
                    task.GetSMEName();
                }
                return result;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Function that fetches all educations from the database (WithoutSkillSet):
        // Used when a student wants to edit their education:
        public List<EducationBase> FetchALLEducations()
        {
            try
            {
                var result = new List<EducationBase>();
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT * FROM Education"
                };
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = GetSafeIntMustNotBeNull(reader, 0);
                    string name = GetSafeString(reader, 1);
                    result.Add(new EducationBase(id, name));
                }
                reader.Close();
                return result;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Function that fetches the skill set of an education based on the name:
        public List<int> FetchEducationSkills(string name)
        {
            try
            {
                var result = new List<string>();
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT Skill_ID FROM Education WHERE EduName = @EduName"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@EduName", name);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = GetSafeString(reader, 0).Split(',').ToList(); ;
                }
                reader.Close();
                return StringListToIntList(result);
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Funktion returning all skills that can be verified on a student by completed tasks:
        public List<int> FetchAllCompletedTaskSkills(int studentID)
        {
            try
            {
                List<int> result = new List<int>();
                List<string> temp = new List<string>();
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT Required_Skill FROM Task WHERE Assigned_Student = @Assigned_Student AND StateID = @StateID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Assigned_Student", studentID);
                cmd.Parameters.AddWithValue("@StateID", 4);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    temp.Add(GetSafeString(reader, 0));
                }
                reader.Close();
                // The int list is made:
                foreach(string skillstring in temp)
                {
                    List<int> skillint = StringListToIntList(skillstring.Split(',').ToList());
                    foreach(int i in skillint)
                    {
                        if (!result.Contains(i))
                        {
                            result.Add(i);
                        }
                    }
                }
                return result;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Function that returns the name of a student assigned to a given task:
        // Should only be called on a task that is In Progress or Completed state, so we know we dont get a Null Reference exception:
        public string FetchAssignedStudentName(int taskID)
        {
            try
            {
                int studID = 0;
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT Assigned_Student FROM Task WHERE TaskID = @TaskID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    studID = GetSafeIntMustNotBeNull(reader, 0);
                }
                reader.Close();
                // The Name of the Student is fetched:
                string name = string.Empty;

                cmd.CommandText = "SELECT FirstName FROM Student WHERE StudentID = @StudentID";
                cmd.Prepare();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@StudentID", studID);
                var readerV2 = cmd.ExecuteReader();
                while (readerV2.Read())
                {
                    name = GetSafeString(readerV2, 0);
                }
                return name;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }
        #endregion

        // .............................................. TASK SPECIFIC FETCH FUNCTIONS .............................................
        // Functions that are used to fetch Task information:

        #region Task-specific Fetch:

        // Function that fetches detailed information on a given task based on the TaskID:
        public TaskDetailed FetchTaskDetailed(int taskID)
        {
            try
            {
                // The result variable is declared:
                TaskDetailed result;
                // First the list of required skills is fetched:
                List<int> reqSkillIDs = FetchRequiredSkills(taskID);
                List<Skill> reqSkills = FetchSkillInfo(reqSkillIDs);

                // Variables are declared:
                #region Variable Declaration:
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
                #endregion

                // Connection is opened:
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT SMEID,Title,Location,Hours,StartDate,Application_Deadline,Completion,StateID,Description,Assigned_Student FROM Task WHERE TaskID = @TaskID LIMIT 1"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);

                // The Reader is declared:
                var reader = cmd.ExecuteReader();
                while (reader.Read())
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
                // The Results are initialised and returned:
                return result = new TaskDetailed(taskID, smeID, title, location, hours, description, startDate, applicationDeadline, estCompletion, stateID, reqSkills, assignedStudent);
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Function that fetches all required skills for a given task:
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
                while (reader.Read())
                {
                    resString = GetSafeString(reader, 0);
                }

            }
            finally
            {
                if (Connection != null) Close();
            }
            // The string from the call above is split at each ',' :
            string[] tempres = resString.Split(',');
            foreach (string s in tempres)
            {   // There should only be ints in the strings, so they are parsed, and added to the result list:
                if (s == "" && s == string.Empty) { }
                else if (int.TryParse(s, out int i)) resList.Add(i);
                else throw new DataErrorInDataBaseException();
            }
            return resList;
        }

        // Fetches all Public Classes and returns a list of tasks that can be used to make recommendations:
        public List<TaskRecommend> FetchAllTasksForRecommendation()
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT TaskID,Title,SMEID,Required_Skill,Application_Deadline FROM Task WHERE StateID = @StateID AND Application_Deadline >= @Now"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@StateID", 2);
                cmd.Parameters.AddWithValue("@Now", DateTime.Now.Date);
                var reader = cmd.ExecuteReader();
                // A temp list is initialized to store the temp data:
                var tempTaskList = new List<TaskBase>();
                var applicationDeadlineList = new List<DateTime>();
                // This list will contain ALL recquired skills for each task! Each element in the list will be the combined string of skill IDs:
                List<string> recSkill = new List<string>();

                while (reader.Read())
                {
                    int taskID = GetSafeIntMustNotBeNull(reader, 0);
                    string title = GetSafeString(reader, 1);
                    int smeID = GetSafeIntMustNotBeNull(reader, 2);
                    recSkill.Add(GetSafeString(reader, 3));
                    applicationDeadlineList.Add(reader.GetDateTime(4));
                    // The data that has been read, is added too the temp list:
                    tempTaskList.Add(new TaskBase(taskID, smeID, title));
                }
                reader.Close();
                // The result list is initialized:
                List<TaskRecommend> resultList = new List<TaskRecommend>();
                // The list of TaskBase will now be paired with the list of required skills:
                int i = 0;
                foreach (TaskBase task in tempTaskList)
                {
                    // The SMEName is found for each task:
                    task.GetSMEName();

                    List<int> tRecSkillIDs = new List<int>();
                    List<string> tRecSkill = recSkill[i].Split(',').ToList();
                    foreach (string skillID in tRecSkill)
                    {
                        if (skillID == "" && skillID == string.Empty) { } // If there is no required skills, nothing should be done :
                        else if (int.TryParse(skillID, out int ID)) tRecSkillIDs.Add(ID);
                        else throw new DataErrorInDataBaseException("TryParse on skillID: " + skillID + i.ToString());
                    }
                    // A list of skills is made based on the list of Skill IDs:
                    List<Skill> skills = FetchSkillInfo(tRecSkillIDs);
                    // The task instance is made and added to the resultlist with the Application deadline:
                    resultList.Add(new TaskRecommend(task, skills, applicationDeadlineList[i]));
                    i++;
                }
                return resultList;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Function used to search for public tasks (Used when a student uses the Search function to find tasks):
        public List<TaskSearched> SearchTasks(string Query, int i)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    // The search type is found, based on which radiobutton is marked when searching:
                    CommandText = SearchType(i)
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@stateid", 2);
                cmd.Parameters.AddWithValue("@query", "%" + Query + "%");

                var reader = cmd.ExecuteReader();

                var TaskList = new List<TaskSearched>();

                while (reader.Read())
                {
                    int taskID = reader.GetInt32(0);
                    int smeID = reader.GetInt32(1);
                    string Title = reader.GetString(2);
                    string Location = reader.GetString(3);
                    int Hours = reader.GetInt32(4);
                    DateTime ApplicationDeadline = reader.GetDateTime(5);
                    DateTime StartDate = reader.GetDateTime(6);
                    DateTime EstCompletionDate = reader.GetDateTime(7);
                    TaskList.Add(new TaskSearched(taskID, smeID, Title, Location, Hours, ApplicationDeadline, StartDate, EstCompletionDate));
                }
                reader.Close();
                return TaskList;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // A function that returns the SQL command for the function above:
        private string SearchType(int i)
        {
            string Command = "";
            switch (i)
            {
                // Title:
                case 1:
                    Command = "SELECT TaskID,SMEID,Title,Location,Hours,StartDate,Application_Deadline,Completion FROM Task WHERE StateID = @stateid AND Title LIKE @query";
                    break;
                // SMEName:
                case 2:
                    Command = "SELECT Task.TaskID,Task.SMEID,Task.Title,Task.Location,Task.Hours,Task.StartDate,Task.Application_Deadline,Task.Completion FROM Task,SME " +
                        "WHERE Task.StateID = @stateid AND Task.SMEID = SME.SMEID AND SME.Name LIKE @query";
                    break;
                // Name of required skill:
                case 3:
                    Command = "SELECT Task.TaskID,Task.SMEID,Task.Title,Task.Location,Task.Hours,Task.StartDate,Task.Application_Deadline,Task.Completion " +
                        "FROM Task,Skill WHERE Task.StateID = @stateid AND find_in_set(Skill.SkillID, Task.Required_Skill)>0 AND Skill.SkillName LIKE @query";
                    break;
            }
            return Command;
        }

        // A function that fetches all student that have applied for a given task, and returns to total list of students:
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
                    CommandText = "SELECT StudentID,RecScore FROM Application WHERE TaskID = @TaskID"
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

                // Now that all IDs and RecScores have been found, the Student IDs is used to find more detailed information on all the students:
                int count = 0;
                foreach (int i in studentIDs)
                {
                    cmd.CommandText = "SELECT FirstName,LastName,Education FROM Student WHERE StudentID = @StudentID";
                    cmd.Prepare();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@StudentID", i);
                    var readerV2 = cmd.ExecuteReader();
                    while (readerV2.Read())
                    {
                        string firstName = GetSafeString(readerV2, 0);
                        string lastName = GetSafeString(readerV2, 1);
                        string education = GetSafeString(readerV2, 2);
                        result.Add(new StudentApplicant(firstName, lastName, i, education, recScore[count]));
                        count++;
                    }
                    readerV2.Close();
                }
                // The list of StudentApplicants is returned:
                return result;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // A function that returns all the applications (In pending state) to a given task (Used on TaskDetailed): 
        public List<ApplicationBase> FetchAllApplications(int taskID)
        {
            try
            {
                // ResList is initialized:
                List<ApplicationBase> resList = new List<ApplicationBase>();
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT ApplicationID,StudentID,RecScore,AppState FROM Application WHERE TaskID = @TaskID AND AppState = @AppState"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);
                cmd.Parameters.AddWithValue("@AppState", 1);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Each line read should initialize a new application instance and add it to the result list:
                    resList.Add(new ApplicationBase(GetSafeIntMustNotBeNull(reader, 0), GetSafeIntMustNotBeNull(reader, 1),
                        taskID, GetSafeInt(reader, 2), GetSafeIntMustNotBeNull(reader, 3)));
                }
                return resList;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Counts the amount of applications for a given task (Used on SME landing to display if there are pending applications on the SMEs Task):
        public int FetchAmountOfApplications(int taskID)
        {
            try
            {
                int i = 0;
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT ApplicationID FROM Application WHERE TaskID = @TaskID AND AppState = @AppState"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);
                cmd.Parameters.AddWithValue("@AppState", 1);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {  // every line that is read simply increments the result:
                    i++;
                }
                return i;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }
        #endregion

        // .............................................. SKILL SPECIFIC FETCH FUNCTIONS .............................................
        // Functions that are used to fetch Skill information:

        #region Skill-specific Fetch:
        // A function that retrieves all current skills defined in the database:
        // Used when making a new task, or when a student wants to update his or hers skills set:
        public List<Skill> FetchALLSkills()
        {
            try
            {
                var result = new List<Skill>();
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT * FROM Skill"
                };
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = GetSafeIntMustNotBeNull(reader, 0);
                    string name = GetSafeString(reader, 1);
                    result.Add(new Skill(id, name));
                }
                reader.Close();
                return result;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Function that retrieves skillnames based on a list of SkillIDs.
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
                        CommandText = "SELECT SkillName FROM Skill WHERE SkillID = @SkillID LIMIT 1"
                    };
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@SkillID", skillID);
                    var reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        string skillName = GetSafeString(reader, 0);
                        resList.Add(new Skill(skillID, skillName));
                    }
                    reader.Close();
                }
                return resList;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Retrieves a single skill based on name:
        public Skill FetchSkillInfoBasedOnName(string skillName)
        {
            try
            {
                Skill result = new Skill(0, "");
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "SELECT * FROM Skill WHERE SkillName = @SkillName LIMIT 1"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@SkillName", skillName);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = GetSafeIntMustNotBeNull(reader, 0);
                    result = new Skill(id, skillName);
                }
                reader.Close();

                return result;
            }
            finally
            {
                if (Connection != null) Close();
            }

        }
        #endregion

        // .............................................. APPLICATION SPECIFIC FETCH FUNCTIONS .............................................
        // Functions that are used to fetch Application information:

        #region Application-specific Fetch:
        // Fetched the Name of the state a for an application, based on the StateID:
        // This could simply be done in a switch to spare the Databasecall. However, is made to show that the databasetables
        //  - can be used as such, in situation where an application might have 20+ different states. 
        // This however does not seem to be something that would be relevant for a system like this.
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
                if (res == string.Empty) throw new DataErrorInDataBaseException("state retrieving.");
                else return res;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Fethces the Title of the relevant task of an pplication:
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
                if (res == string.Empty) throw new DataErrorInDataBaseException("Fetch TaskTitle for Application");
                else return res;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Fetches the name of the SME owner of a task that has been applied for:
        public string FetchApplicationSMEName(int taskID)
        {
            try
            {
                Open();
                // First SME is fetched:
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

                // The Name of The SME is found:
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
                if (res == string.Empty) throw new DataErrorInDataBaseException("Fetching SMEOwner for Application");
                else return res;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Fetches the Name of the student who has applied:
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
                if (res == " ") throw new DataErrorInDataBaseException("Fetching studentname for Application");
                else return res;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Function that returns the ID list of all tasks a student has applied for:
        // Usedn when making recommendations to remove all tasks a student has already applied for from the recommendation result:
        public List<int> FetchAllAppliedForTaskIDs(int studentID)
        {
            try
            {
                List<int> taskIDs = new List<int>();
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
                    taskIDs.Add(GetSafeIntMustNotBeNull(reader, 0));
                }
                return taskIDs;
            }
            finally
            {
                if (Connection != null) Close();
            }
        }
        #endregion

        // End of Fetch Functions:
        #endregion

        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! POST FUNCTIONS:  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // This Region Contains all Post, Update and Delete functions:

        #region Post/Update/Delete Functions:

        // .............................................. SME SPECIFIC POST FUNCTIONS .............................................
        // Functions that POSTS/UPDATES or DELETES on the SME table:

        #region SME-specific Post/Update/Delete

        // A function that Inserts a new SME entry in the database, based on the user registering a new SME profile:
        public void RegisterSMEProfile(string img_SME, string companyName, string email, string password, string username)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "INSERT INTO SME(Name,Email,Password,Image_Dir,Username) VALUES(@Name,@Email,@Password,@Image_Dir,@Username)"
                };
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Image_Dir", img_SME);
                cmd.Parameters.AddWithValue("@Name", companyName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }
        #endregion

        // .............................................. STUDENT SPECIFIC POST FUNCTIONS .............................................
        // Functions that POSTS/UPDATES or DELETES on the Student table:

        #region Student-specific Post/Update/Delete

        // A function that Inserts a new Student entry in the database, based on the user registering a new Student profile:
        public void RegisterStudentProfile(string username, string password, string firstname, string lastname, string email, string img)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "INSERT INTO Student(Username,Password,Firstname,Lastname,Email,Image_Dir) VALUES(@Username,@Password,@Firstname,@Lastname,@Email,@Image_Dir)"
                };
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

        // This Function is called when a student submits profile editing:
        public void UpdateStudentProfile(StudentDetailed thisStudent)
        {
            try
            {
                List<Skill> verifiedSkillList = new List<Skill>();
                List<Skill> unverifiedSkillList = new List<Skill>();
                foreach (SkillStudent skill in thisStudent.Skills)
                {
                    if (skill.Verified) verifiedSkillList.Add(new Skill(skill.ID, skill.Name));
                    else unverifiedSkillList.Add(new Skill(skill.ID, skill.Name));
                }
                string verifiedSkills = MakeSkillIDString(verifiedSkillList);
                string unverifiedSkills = MakeSkillIDString(unverifiedSkillList);

                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "UPDATE Student SET Description = @Description, Email = @Email, Education = @Education, " +
                    "Verified_SkillSet = @Verified_SkillSet, Unverified_SkillSet = @Unverified_SkillSet, Image_Dir = @Image_Dir, Pdf_Dir = @Pdf_Dir " +
                    "WHERE StudentID = @StudentID"
                };
                cmd.Prepare();

                // The parameters are added:
                cmd.Parameters.AddWithValue("@StudentID", thisStudent.ID);
                cmd.Parameters.AddWithValue("@Description", thisStudent.Description);
                cmd.Parameters.AddWithValue("@Email", thisStudent.Email);
                cmd.Parameters.AddWithValue("@Education", thisStudent.Education);
                cmd.Parameters.AddWithValue("@Verified_SkillSet", verifiedSkills);
                cmd.Parameters.AddWithValue("@Unverified_SkillSet", unverifiedSkills);
                cmd.Parameters.AddWithValue("@Image_Dir", thisStudent.ProfilePicture);
                cmd.Parameters.AddWithValue("@Pdf_Dir", thisStudent.Resume);
                // The call is executed:
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // This Function updates a students skill set:
        public void UpdateStudentSkillSet(List<SkillStudent> skills, int studentID)
        {
            try
            {
                // The list is splitted in verified and unverified:
                List<Skill> verifiedSkillList = new List<Skill>();
                List<Skill> unverifiedSkillList = new List<Skill>();
                foreach (SkillStudent skill in skills)
                {
                    if (skill.Verified) verifiedSkillList.Add(new Skill(skill.ID, skill.Name));
                    else unverifiedSkillList.Add(new Skill(skill.ID, skill.Name));
                }
                string verifiedSkills = MakeSkillIDString(verifiedSkillList);
                string unverifiedSkills = MakeSkillIDString(unverifiedSkillList);

                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "UPDATE Student SET Verified_SkillSet = @Verified_SkillSet, Unverified_SkillSet = @Unverified_SkillSet WHERE StudentID = @StudentID"
                };
                cmd.Prepare();

                // The parameters are added:
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@Verified_SkillSet", verifiedSkills);
                cmd.Parameters.AddWithValue("@Unverified_SkillSet", unverifiedSkills);
                // The call is executed:
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }
        #endregion

        // .............................................. TASK SPECIFIC POST FUNCTIONS .............................................
        // Functions that POSTS/UPDATES or DELETES on the Task table:

        #region Task-specific Post/Update/Delete

        // Function that creates a new Task entry in the database
        public void CreateNewTask(TaskDetailed thisTask)
        {
            try
            {
                // Skill list is made:
                string reqSkills = MakeSkillIDString(thisTask.RequiredSkills);
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "INSERT INTO Task(SMEID,Title,Description,StartDate,Location,Application_Deadline,Completion,Hours,StateID,Required_Skill) " +
                    "VALUES (@sme,@title,@description,@startdate,@location,@applicationdeadline,@completion,@hours,@stateID,@Required_Skill)"
                };
                cmd.Prepare();

                // The parameters are added:
                cmd.Parameters.AddWithValue("@sme", thisTask.SMEID);
                cmd.Parameters.AddWithValue("@title", thisTask.Title);
                cmd.Parameters.AddWithValue("@description", thisTask.Description);
                cmd.Parameters.AddWithValue("@startdate", thisTask.Startdate);
                cmd.Parameters.AddWithValue("@location", thisTask.Location);
                cmd.Parameters.AddWithValue("@applicationdeadline", thisTask.ApplicationDeadline);
                cmd.Parameters.AddWithValue("@completion", thisTask.EstCompletionDate);
                cmd.Parameters.AddWithValue("@hours", thisTask.Hours);
                cmd.Parameters.AddWithValue("@stateID", thisTask.StateID);
                cmd.Parameters.AddWithValue("@Required_Skill", reqSkills);
                // The call is executed:
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Function that Updates a row in the Task table. Called after Edit Task:
        public void UpdateTask(TaskDetailed thisTask)
        {
            try
            {
                // Skill list is made:
                string reqSkills = MakeSkillIDString(thisTask.RequiredSkills);
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "UPDATE Task SET SMEID = @sme, Title = @title, Description = @description, StartDate = @startdate, Location = @location, " +
                    "Application_Deadline = @applicationdeadline, Completion = @completion, Hours = @hours, StateID = @stateID, Required_Skill = @Required_Skill" +
                    " WHERE TaskID = @TaskID"
                };
                cmd.Prepare();

                // The parameters are added:
                cmd.Parameters.AddWithValue("@TaskID", thisTask.ID);
                cmd.Parameters.AddWithValue("@sme", thisTask.SMEID);
                cmd.Parameters.AddWithValue("@title", thisTask.Title);
                cmd.Parameters.AddWithValue("@description", thisTask.Description);
                cmd.Parameters.AddWithValue("@startdate", thisTask.Startdate);
                cmd.Parameters.AddWithValue("@location", thisTask.Location);
                cmd.Parameters.AddWithValue("@applicationdeadline", thisTask.ApplicationDeadline);
                cmd.Parameters.AddWithValue("@completion", thisTask.EstCompletionDate);
                cmd.Parameters.AddWithValue("@hours", thisTask.Hours);
                cmd.Parameters.AddWithValue("@stateID", thisTask.StateID);
                cmd.Parameters.AddWithValue("@Required_Skill", reqSkills);
                // The call is executed:
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Function that assigns a student to a given task:
        public void AssignStudentToTask(int studentID, int taskID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "UPDATE Task SET Assigned_Student = @Assigned_Student, StateID = @StateID WHERE TaskID = @TaskID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);
                cmd.Parameters.AddWithValue("@Assigned_Student", studentID);
                cmd.Parameters.AddWithValue("@StateID", 3);
                cmd.ExecuteNonQuery();
                // The application is updated:
                ConfirmApplication(studentID, taskID);
                // All other students applications are rejected:
                RejectALLApplicationsExceptAssigned(taskID, studentID);
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // A function that changes state of a task. ( Only used to change between Private and Public! ) 
        public void AutoTaskStateChange(int TaskID, int NewState)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "UPDATE Task SET StateID = @StateID WHERE TaskID = @TaskID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@StateID", NewState);
                cmd.Parameters.AddWithValue("@TaskID", TaskID);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Function that marks a task as completed:
        public void CompleteTask(int taskID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "UPDATE Task SET StateID = @StateID WHERE TaskID = @TaskID"
                };
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@TaskID", taskID);
                cmd.Parameters.AddWithValue("@StateID", 4);
                cmd.ExecuteNonQuery();
                // All related applications are deleted from the database:
                RemoveALLApplications(taskID);
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // Deletes a task, can only be called when an SME owner is viewing a task in private state:
        public void DeleteTask(int taskID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "DELETE FROM Task WHERE TaskID = @TaskID";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@TaskID", taskID);
                cmd.ExecuteNonQuery();

                RemoveALLApplications(taskID);
            }
            finally
            {
                if (Connection != null) Close();
            }
        }
        #endregion


        // .............................................. APPLICATION SPECIFIC POST FUNCTIONS .............................................
        // Functions that POSTS/UPDATES or DELETES on the Application table:
        #region Application-specific Post/Update/Delete

        // Function that makes a new entry in the application table:
        public void PostApplication(int studentID, int taskID, int recScore)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "INSERT INTO Application(TaskID,StudentID,RecScore,AppState) VALUES(@TaskID,@StudentID,@RecScore,@AppState)"
                };
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

        // Function that removes an application from the database based on Application ID:
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

        // Removing ALL applications from a task once it is completed:
        public void RemoveALLApplications(int taskID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "DELETE FROM Application WHERE TaskID = @TaskID";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@TaskID", taskID);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // When a student is assigned to a task, all other applicants gets their application rejected:
        public void RejectALLApplicationsExceptAssigned(int taskID, int studID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "UPDATE Application SET AppState = @AppState WHERE StudentID <> @StudentID AND TaskID = @TaskID"
                };
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@StudentID", studID);
                cmd.Parameters.AddWithValue("@AppState", 2);
                cmd.Parameters.AddWithValue("@TaskID", taskID);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // A function that changes the state of an application to rejected:
        public void RejectApplication(int studentID, int taskID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "UPDATE Application SET AppState = @AppState WHERE StudentID = @StudentID AND TaskID = @TaskID"
                };
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@AppState", 2);
                cmd.Parameters.AddWithValue("@TaskID", taskID);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }

        // A function that changes the state to Accepted on a given application:
        public void ConfirmApplication(int studentID, int taskID)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Connection,
                    CommandText = "UPDATE Application SET AppState = @AppState WHERE StudentID = @StudentID AND TaskID = @TaskID"
                };
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@AppState", 3);
                cmd.Parameters.AddWithValue("@TaskID", taskID);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (Connection != null) Close();
            }
        }
        #endregion

        // End of Post Functions:
        #endregion
    }
}