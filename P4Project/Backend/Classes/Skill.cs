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
        public string Catagory { get; }

        public Skill(int id, string name, string catagory)
        {
            ID = id;
            Name = name;
            Catagory = catagory;
        }
    }
}
