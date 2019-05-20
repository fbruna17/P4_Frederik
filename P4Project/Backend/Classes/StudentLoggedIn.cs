using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4Project.Backend.Recommendation;
using MySql.Data.MySqlClient;

namespace P4Project.Backend.Classes
{
    public class StudentLoggedIn : StudentDetailed
    {
        private string Username { get; }
        private string Password { get; }
        public List<TaskRecommend> RecTasks { get; }
        public List<ApplicationDetailed> Applications { get; set; }
        private RecMaker Recommend;

        public StudentLoggedIn(string firstName, string lastName, int id, string email, string education, List<SkillStudent> skills, 
            string description, string profilePicture, string resume, string username, string password)
            : base(firstName, lastName, id, email, education, skills, description, profilePicture, resume)
        {
            Username = username;
            Password = password;
            Recommend = new RecMaker(this);
            RecTasks = Recommend.RecommendTasks();
            GetApplications();
            GetAssignedTasks();
        }

        public StudentLoggedIn(string username, string password, StudentDetailed thisStudent) 
            : base(thisStudent.FirstName, thisStudent.LastName, thisStudent.ID, thisStudent.Email, thisStudent.Education, thisStudent.Skills,
                  thisStudent.Description, thisStudent.ProfilePicture, thisStudent.Resume)
        {
            Username = username;
            Password = password;
            Recommend = new RecMaker(this);
            RecTasks = Recommend.RecommendTasks();
            Applications = new List<ApplicationDetailed>();
            GetApplications();
            GetAssignedTasks();
        }

        // Gets all applications made by this student:
        public List<ApplicationDetailed> GetApplications()
        {
            SQLControl sql = new SQLControl();
            List<ApplicationBase> tempApp = sql.FetchStudentAppliedBaseInfo(ID);
            if(tempApp != null)
            {
                foreach (ApplicationBase app in tempApp)
                {
                    Applications.Add(new ApplicationDetailed(app));
                }
            }
            return Applications;
        }
        
        // Updates the session data for a logged in student:
        public StudentLoggedIn UpdateSessionData()
        {
            SQLControl sql = new SQLControl();
            return new StudentLoggedIn(Username, Password, sql.FetchStudentDetailed(ID));
        }

        // Function that removes an item from the skill list:
        public void RemoveFromSkillSet(string skillName)
        {
            Skills.RemoveAll(a => a.Name == skillName);
        }

        // Function that adds a skill to the skilllist:
        public void AddTooSkillSet(SkillStudent skill)
        {
            Skills.Add(skill);
        }

        // A function that updates the students Skillset with what is verified and what is not, is called upon LogIn:
        public void UpdateSkillSet()
        {
            // Alle de skill der er verified hentes ned som IDs:
            SQLControl sql = new SQLControl();
            List<int> eduVerified = sql.FetchEducationSkills(Education);
            List<int> taskVerified = sql.FetchAllCompletedTaskSkills(ID);
            // The Lists are merged:
            foreach (int i in eduVerified)
            {
                if (!taskVerified.Contains(i)) taskVerified.Add(i);
            }
            // Skill info is found:
            List<Skill> vskills = sql.FetchSkillInfo(taskVerified);
            List<SkillStudent> vSkills = sql.MakeStudentSkillList(vskills, true);

            // All Skills already on the list is removed to avoid duplicates, this also makes sure unverified skills gets verified:
            foreach (SkillStudent skill in vSkills)
            {
                Skills.RemoveAll(s => s.ID == skill.ID);
                //And The skill is added:
                Skills.Add(skill);
            }
            // The New Skillset is posted: 
            sql.UpdateStudentSkillSet(Skills, ID);
        }
    }
}
