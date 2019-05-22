using System.Collections.Generic;
using System.Linq;

namespace P4Project.Backend.Classes
{
    // This Class hold data needed for an instance of a student who has applied for a task:
    public class StudentApplicant : StudentBase
    {
        public string Email { get; }
        public string Education { get; }
        public string ProfilePicture { get; protected set; }
        public int RecommendationScore { get; }
        public List<SkillStudent> Skills { get; }

        // Constructer for when a recommendationscore is already known (Used when SME´s look up all students who has applied for a task): 
        public StudentApplicant(string firstName, string lastName, int id, string education, int recommendationScore) : base(firstName, lastName, id)
        {
            Education = education;
            RecommendationScore = recommendationScore;
        }

        // Constructer mostly used for handling base data from a StudentDetailed:
        public StudentApplicant(string firstName, string lastName, int id, string email, string education, string profilePicture, List<SkillStudent> skills) 
            : base(firstName, lastName, id)
        {
            Email = email;
            Education = education;
            Skills = skills;
            Skills.OrderByDescending(a => a.Verified == true);
            ProfilePicture = profilePicture;
        }

        // Method that returns a string[] for DataViewGrid of a Student who has applied for a task: 
        // Used when SMEs look up student applicant for a given task.
        public string[] MakeDataViewString()
        {
            string[] output = { FirstName + " " + LastName, Education, RecommendationScore.ToString(), ID.ToString() };
            return output;
        }

    }
}
