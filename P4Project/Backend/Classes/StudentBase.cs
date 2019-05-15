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
        public string Email { get; }
        public string Description { get; }
        public string Education { get; }


        public StudentBase(string firstName, string lastName, int id, string email, string description, string education)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            Email = email;
            Description = description;
            Education = education;
            //Gris
        }

        public StudentBase(int id)
        {
            ID = id;
        }
    }
}
