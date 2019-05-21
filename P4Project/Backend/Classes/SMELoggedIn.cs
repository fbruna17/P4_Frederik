using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    public class SMELoggedIn : SMEDetailed
    {
        private string Username { get; }
        private string Password { get; }

        public SMELoggedIn(int id, string name, string email, List<TaskSearched> tasks, string logo, 
            string description, string username, string password) 
            : base(id, name, email, tasks, logo, description)
        {
            Username = username;
            Password = password;
        }
        // Constructer der bruges når man har en SMEDetailed i forvejen:
        public SMELoggedIn(string username, string password, SMEDetailed thisSME) 
            : base(thisSME.ID, thisSME.Name, thisSME.Email, thisSME.Tasks, thisSME.Logo, thisSME.Description)
        {
            Username = username;
            Password = password;
        }

        public List<TaskSearched> GetListOfTasks(int stateID)
        {
            return Tasks.FindAll(t => t.StateID == stateID);
        }

        public SMELoggedIn UpdateSessionData()
        {
            SQLControl sql = new SQLControl();
            return new SMELoggedIn(Username, Password, sql.FetchSMEDetailedInformation(ID));
        }
    }
}
