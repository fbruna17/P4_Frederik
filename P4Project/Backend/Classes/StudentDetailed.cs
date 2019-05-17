﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    public class StudentDetailed : StudentApplicant
    {
       // public List<TaskBase> CompletedTasks { get; protected set; }
        public string Description { get; protected set; }
        // public *** Resumé { get; protected set; }

        public StudentDetailed(string firstName, string lastName, int id, string email, string education,
            List<SkillStudent> skills, string description, string profilePicture) 
            : base(firstName, lastName, id, email, education, profilePicture, skills)
        {
            Description = description;
        }

    }
}
