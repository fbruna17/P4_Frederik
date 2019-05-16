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
        private List<Skill> RequiredSkills { get; }

        // En double til at opbevare scoren fra recommendationen:
        private double RecommendScore { get; }

        // Hvis RequiredSkills allerede kendes kan man slippe for databasekaldet: Smartere når der skal ittereses gennem- / Laves mange instanser
        public TaskRecommend(int id, List<Skill> requiredSkills, string title, int smeID, string smeName) : base(id, smeID, title, smeName)
        {
            RequiredSkills = requiredSkills;
            RecommendScore = 0;
        }

        // Hvis RequiredSkills allerede kendes kan man slippe for databasekaldet: Smartere når der skal ittereses gennem- / Laves mange instanser
        public TaskRecommend(TaskBase taskBase, List<Skill> requiredSkills) : base(taskBase.ID, taskBase.SMEID, taskBase.Title, taskBase.SMEName)
        {
            RequiredSkills = requiredSkills;
            RecommendScore = 0;
        }

        public string[] MakeDataViewGrid()
        {
            string[] output = { Title, RecommendScore.ToString(), SMEName };
            return output;
        }
    }
}
