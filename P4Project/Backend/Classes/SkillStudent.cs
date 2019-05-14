﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    public class SkillStudent : Skill
    {
        public bool Verified { get; }

        public SkillStudent(int id, string name, string category, bool verified) : base(id, name, category)
        {
            Verified = verified;
        }
    }
}