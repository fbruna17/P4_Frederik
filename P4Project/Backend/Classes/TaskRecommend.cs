using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    // Denne klasse bruges til recommendation algoritmen, og indeholder blot en liste af SkillIDs:
    public class TaskRecommend : TaskBase
    {
        // Listen over required skills der hentes fra databasen:
        private List<int> RequiredSkills { get; }

        // En double til at opbevare scoren fra recommendationen:
        private double RecommendScore { get; }

        // SQL instans:
        private SQLControl SQL;

        public TaskRecommend(int id) : base(id)
        {
            SQL = new SQLControl();
            // Denne klasse finder selv de required skills der er, ud fra ID´et. !!! SKAL MULIGVIS ÆNDRES SENERE !!!
            RequiredSkills = SQL.FetchRequiredSkills(ID);
        }
        // Hvis RequiredSkills allerede kendes kan man slippe for databasekaldet: Smartere når der skal ittereses gennem- / Laves mange instanser
        public TaskRecommend(int id, List<int> requiredSkills) : base(id)
        {
            RequiredSkills = requiredSkills;
        }
    }
}
