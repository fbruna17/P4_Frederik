using System.Collections.Generic;

namespace P4Project.Backend.Classes
{
    // This Class is used as a struct to keep information about an education on run time:
    public class EducationBase
    {
        public string Name { get; }
        public int ID { get; }

        // The constructer:
        public EducationBase(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
