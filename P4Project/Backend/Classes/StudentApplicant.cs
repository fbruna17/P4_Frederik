using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    public class StudentApplicant : StudentBase
    {
        public string Email { get; }

        public string Education { get; }

        public List<SkillStudent> Skills { get; }

        public string ProfilePicture { get; protected set; }

        public int RecommendationScore { get; }

        // Constructer der tager recommendation score med: 
        public StudentApplicant(string firstName, string lastName, int id, string education, int recommendationScore) : base(firstName, lastName, id)
        {
            Education = education;
            RecommendationScore = recommendationScore;
        }

        public StudentApplicant(string firstName, string lastName, int id, string email, string education, string profilePicture, List<SkillStudent> skills) 
            : base(firstName, lastName, id)
        {
            Email = email;
            Education = education;
            Skills = skills;
            Skills.OrderByDescending(a => a.Verified == true);
            ProfilePicture = profilePicture;
        }

        public string[] MakeDataViewString()
        {
            string[] output = { FirstName + " " + LastName, Education, RecommendationScore.ToString(), ID.ToString() };
            return output;
        }

    }
}
