using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4Project.Backend.Classes;

namespace P4Project.Backend.Recommendation
{
    public class RecMaker
    {
        // SQL instans:
        private SQLControl SQL;
        // Liste over alle tasks der kan recommendes:
        private List<TaskRecommend> AllTasks;
        // Denne studerende:
        private StudentLoggedIn ThisStudent;

        public RecMaker(StudentLoggedIn thisStudent)
        {
            SQL = new SQLControl();
            AllTasks = SQL.FetchAllTasksForRecommendation();
            ThisStudent = thisStudent;
        }

        public List<TaskRecommend> RecommendTasks()
        {
            return AllTasks;
        }

    }
}
