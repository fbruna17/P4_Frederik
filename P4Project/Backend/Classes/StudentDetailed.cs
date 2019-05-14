using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    class StudentDetailed : StudentBase
    {
        private SQLControl SQL;

        public StudentDetailed(int id) : base(id)
        {
            SQL = new SQLControl();
            GetDetailedInformation();
        }

        public void GetDetailedInformation()
        {
            SQL.
        }

    }
}
