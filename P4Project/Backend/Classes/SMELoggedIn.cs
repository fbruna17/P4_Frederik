using System.Collections.Generic;
using System.Linq;

namespace P4Project.Backend.Classes
{
    // This Class is used to create an instance of the SME account a user logs in to:
    // Objects of this class is used for all forms an SME can visit, so its not possible to call an SME related form, without an -
    // - instance of this class.
    public class SMELoggedIn : SMEDetailed
    {
        // The Username and password are stored, but cannot be seen outside of this class:
        private string Username { get; }
        private string Password { get; }

        // The Constructer for this class:
        public SMELoggedIn(string username, string password, SMEDetailed thisSME) 
            : base(thisSME.ID, thisSME.Name, thisSME.Email, thisSME.Tasks, thisSME.Logo)
        {
            Username = username;
            Password = password;
        }

        // A Method that is used to return the list of tasks owned by this SME, based on the state of the tasks:
        public List<TaskSearched> GetListOfTasks(int stateID)
        {
            if(stateID == 1 || stateID == 2)
            {
                return Tasks.FindAll(t => t.StateID == stateID).OrderBy(t => t.ApplicationDeadline).ToList();
            }
            else return Tasks.FindAll(t => t.StateID == stateID).OrderBy(t => t.EstCompletionDate).ToList();

        }

        // A method used to update Session data for a logged in SME:
        public SMELoggedIn UpdateSessionData()
        {
            // It simply returns a new instance of the object, but saves the LogIn information:
            SQLControl sql = new SQLControl();
            return new SMELoggedIn(Username, Password, sql.FetchSMEDetailedInformation(ID));
        }
    }
}
