using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    class TaskBase
    {
        public int ID { get; }
        public int SMEID { get; }

        public TaskBase(int id)
        {
            ID = id;
        }

        public TaskBase(int id, int smeID)
        {
            ID = id;
            SMEID = smeID;
        }
    }
}
