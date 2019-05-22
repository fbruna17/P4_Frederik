using System.Collections.Generic;

namespace P4Project.Backend.Classes
{
    // This class is used to initialize a detailed student, for displaying a Student Profile, or store data for a logged in student:
    public class StudentDetailed : StudentApplicant
    {
        public string Description { get; protected set; }
        public List<TaskAssigned> AssignedTasks { get; protected set; }
        public string Resume { get; protected set; }

        public StudentDetailed(string firstName, string lastName, int id, string email, string education,
            List<SkillStudent> skills, string description, string profilePicture, string resume) 
            : base(firstName, lastName, id, email, education, profilePicture, skills)
        {
            Description = description;
            Resume = resume;
        }

        // Method that gets all tasks assigned to this student:
        public void GetAssignedTasks()
        {
            SQLControl sql = new SQLControl();
            AssignedTasks = sql.FetchStudentAssignedForTasks(ID);
        }
    }
}
