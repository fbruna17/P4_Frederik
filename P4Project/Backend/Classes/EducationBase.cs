using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    public class EducationBase
    {
        public string Name { get; }
        public int ID { get; }
        public List<Skill> Skills { get; }

        public EducationBase(int id, string name, List<Skill> skills)
        {
            ID = id;
            Name = name;
            Skills = skills;
        }

        public EducationBase(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
