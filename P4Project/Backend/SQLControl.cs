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
        private string MyConnectionString = "server=mysql33.unoeuro.com;uid=blo_store_dk;pwd=3pdaxzyt;database=blo_store_dk_db_wd";
        private MySqlConnection Connection { get; set; }

        public SQLControl()
        {
            Connection = new MySqlConnection(MyConnectionString);
        }

        public void Open()
        {
            Connection.Open();
        }

        public void Close()
        {
            Connection.Close();
        }

        public void AddStudent(string firstname, string lastname, string email)
        {
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "INSERT INTO Student(Firstname,Lastname,Email) VALUES(@Firstname,@Lastname,@Email)";
                cmd.Prepare();

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

        public void RegisterSMEProfile(string companyName, string email, string password)
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
                    CommandText = "INSERT INTO SME(Name,Email,Password) VALUES(@Name,@Email,@Password)"
                };
                cmd.Prepare();

                // Parametrene tilføjes:
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


    }
}
