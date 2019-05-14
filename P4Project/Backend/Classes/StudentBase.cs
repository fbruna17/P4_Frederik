using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    public abstract class StudentBase
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int ID { get; }   

        public StudentBase(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
        }

        public StudentBase(int id)
        {
            ID = id;
        }
    }
}
