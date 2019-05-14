using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    public class Skill
    {
        private int ID { get; }
        public string Name { get; }
        public string Category { get; }

        public Skill(int id, string name, string category)
        {
            ID = id;
            Name = name;
            Category = category;
        }
    }
}
