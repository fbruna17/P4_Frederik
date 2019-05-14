using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project
{
    public class StudentBase
    {
        private SQLControl SQL;

        public int ID { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string Email { get; }

        public StudentBase(int id, string fname, string lname, string email)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
            Email = email;
            SQL = new SQLControl();
        }
    }
}
