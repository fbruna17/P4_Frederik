using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project
{
    public class SMEBase
    {
        public int ID { get; }

        public string Name { get; }

        public string Email { get; }

        public SMEBase(int id, string name, string email)
        {
            ID = id;
            Name = name;
            Email = email;
        }

        public void GetTasks()
        {

        }
    }
}
