using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4Project.Backend.Recommendation;

namespace P4Project.Backend.Classes
{
    public class StudentLoggedIn : StudentDetailed
    {
        private string Username { get; }
        private string Password { get; }
        public List<TaskRecommend> RecTasks { get; }
        private RecMaker Recommend;

        public StudentLoggedIn(string firstName, string lastName, int id, string email, string education, List<SkillStudent> skills, 
            string description, string profilePicture, string username, string password)
            : base(firstName, lastName, id, email, education, skills, description, profilePicture)
        {
            Username = username;
            Password = password;
            Recommend = new RecMaker(this);
            RecTasks = Recommend.RecommendTasks();
        }

        public StudentLoggedIn(string username, string password, StudentDetailed thisStudent) 
            : base(thisStudent.FirstName, thisStudent.LastName, thisStudent.ID, thisStudent.Email, thisStudent.Education, thisStudent.Skills,
                  thisStudent.Description, thisStudent.ProfilePicture)
        {
            Username = username;
            Password = password;
            Recommend = new RecMaker(this);
            RecTasks = Recommend.RecommendTasks();
        }

        
    }
}
