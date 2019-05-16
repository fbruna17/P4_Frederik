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

        // public int RecommendationScore { get; }

        public StudentApplicant(string firstName, string lastName, int id, string email, string education, string profilePicture) : base(firstName, lastName, id)
        {
            Email = email;
            Education = education;
            ProfilePicture = profilePicture;
        }

        public StudentApplicant(string firstName, string lastName, int id, string email, string education, string profilePicture, List<SkillStudent> skills) 
            : base(firstName, lastName, id)
        {
            Email = email;
            Education = education;
            Skills = skills;
            ProfilePicture = profilePicture;
        }

        // public void GetRecommendation() { }

    }
}
