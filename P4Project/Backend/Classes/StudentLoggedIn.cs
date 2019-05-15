using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    public class StudentLoggedIn : StudentDetailed
    {
        private string Username { get; }
        private string Password { get; }

        public StudentLoggedIn(string firstName, string lastName, int id, string email, string education, List<SkillStudent> skills, 
            string description, byte[] profilePicture, string username, string password)
            : base(firstName, lastName, id, email, education, skills, description, profilePicture)
        {
            Username = username;
            Password = password;
        }

        public StudentLoggedIn(string username, string password, StudentDetailed thisStudent) 
            : base(thisStudent.FirstName, thisStudent.LastName, thisStudent.ID, thisStudent.Email, thisStudent.Education, thisStudent.Skills,
                  thisStudent.Description, thisStudent.ProfilePicture)
        {
            Username = username;
            Password = password;
        }

        // Der skal laves funktioner der håndterer edits, eller også skal properties kunne sættes public, og have verifications logik.
        // public void EditProfile() { }
    }
}
