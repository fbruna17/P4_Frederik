using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using P4Project.Exceptions;

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
        public void AddStudent(string username, string password, string firstname, string lastname, string email, byte[] img)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "INSERT INTO Student(Username,Password,Firstname,Lastname,Email,Profile_Picture) VALUES(@Username,@Password,@Firstname,@Lastname,@Email,@Profile_Picture)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
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

        
        #endregion

        #region Task-specific SQL
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
                    resString = reader.GetString(0);
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

        public List<Task> FetchTasksForSME()
        {
            var taskList = new List<Task>();
            return taskList;
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
