using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    class SMELoggedIn : SMEDetailed
    {
        private string Username { get; }
        private string Password { get; }
        public SMELoggedIn(int id, string name, string email, List<TaskSearched> tasks, byte[] logo, 
            string description, string username, string password) 
            : base(id, name, email, tasks, logo, description)
        {
            Username = username;
            Password = password;
        }
    }
}
