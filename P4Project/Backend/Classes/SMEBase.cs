using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project
{
    public class SMEBase
    {
        private SQLControl SQL;

        public int ID { get; }

        public string Name { get; }

        public string Email { get; }

        public List<Task> Tasks { get; }

        public SMEBase(int id, string name, string email)
        {
            ID = id;
            Name = name;
            Email = email;
            SQL = new SQLControl();
        }

        public void GetTasks()
        {

        }
    }
}
