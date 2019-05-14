using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    class StudentLoggedIn : StudentDetailed
    {
        private string Username { get; }
        private string Password { get; }

        public StudentLoggedIn(string firstName, string lastName, int id, string email, string education,
            List<SkillStudent> skills, List<TaskBase> completedTasks, string description, byte[] profilePicture)
            : base(firstName, lastName, id, email, education, skills, completedTasks, description, profilePicture)
        {

        }

        public StudentLoggedIn(string firstName, string lastName, int id, string email, string education, List<SkillStudent> skills,
            List<TaskBase> completedTasks, string description, byte[] profilePicture, string username, string password)
            : base(firstName, lastName, id, email, education, skills, completedTasks, description, profilePicture)
        {
            Username = username;
            Password = password;
        }

        // Der skal laves funktioner der håndterer edits, eller også skal properties kunne sættes public, og have verifications logik.
        // public void EditProfile() { }
    }
}
