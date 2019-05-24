using System;
using System.Collections.Generic;

namespace P4Project.Backend.Classes
{
    // This class is used in the Recommendation algorithm to return all recommended tasks:
    public class TaskRecommend : TaskBase
    {
        public List<Skill> RequiredSkills { get; }
        public int RecommendScore { get; set; }

        public TaskRecommend(TaskBase taskBase, List<Skill> requiredSkills) : base(taskBase.ID, taskBase.SMEID, taskBase.Title, taskBase.SMEName)
        {
            RequiredSkills = requiredSkills;
            RecommendScore = 0;
        }

        // Method that returns the DataGridView to display information regarding the recommended task:
        // (Used in student Landing Page)
        public string[] MakeDataViewGrid()
        {
            string[] output = { Title, RecommendScore.ToString(), SMEName };
            return output;
        }
    }
}
