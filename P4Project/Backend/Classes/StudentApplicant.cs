using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    class StudentApplicant : StudentBase
    {
        public string Email { get; }

        public string Education { get; }

        public List<SkillStudent> Skills { get; }

        // public int RecommendationScore { get; }

        public StudentApplicant(string firstName, string lastName, int id, string email, string description, string education) : base(firstName, lastName, id, email, description, education)
        {
            Email = email;
            Education = education;
        }

        public StudentApplicant(string firstName, string lastName, int id, string email, string description, string education, List<SkillStudent> skills) 
            : base(firstName, lastName, id, email, description, education)
        {
            Email = email;
            Education = education;
            Skills = skills;
        }

        // public void GetRecommendation() { }

    }
}
