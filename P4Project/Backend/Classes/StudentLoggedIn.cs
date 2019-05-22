using System.Collections.Generic;
using P4Project.Backend.Recommendation;

namespace P4Project.Backend.Classes
{
    // This class is used to initiate a logged in student: 
    // It is needed to display all student related forms to a user. So It is not possible to see any studentrelated forms, without an
    // instanse of this class:
    public class StudentLoggedIn : StudentDetailed
    {
        private string Username { get; }
        private string Password { get; }
        public List<TaskRecommend> RecTasks { get; set; }
        public List<ApplicationDetailed> Applications { get; set; }
        private RecMaker Recommend;

        // The Constructer is made so an instance of a detailed Student can be used in combination with UserName and Password to make an instance of this:
        public StudentLoggedIn(string username, string password, StudentDetailed thisStudent) 
            : base(thisStudent.FirstName, thisStudent.LastName, thisStudent.ID, thisStudent.Email, thisStudent.Education, thisStudent.Skills,
                  thisStudent.Description, thisStudent.ProfilePicture, thisStudent.Resume)
        {
            Username = username;
            Password = password;
            Applications = new List<ApplicationDetailed>();
            // All applications and all assigned tasks are fetched:
            GetApplications();
            GetAssignedTasks();
            // The SkillSet is updated upen making a new instance:
            UpdateSkillSet();
            // Recommendations are made upon login:
            Recommend = new RecMaker(this);
            // The 7 best recommendations are stored in the list of recommended tasks:
            RecTasks = Recommend.RecommendTasks(false);
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
