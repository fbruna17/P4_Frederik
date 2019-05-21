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

        public List<TaskRecommend> RecommendTasks(bool getAll)
        {
            List<TaskRecommend> resultList = new List<TaskRecommend>();

            // Bool that prevents null exceptions in case a student has 0 assigned tasks.
            bool checkAssignedTasks = false;
            if (ThisStudent.AssignedTasks != null) checkAssignedTasks = true;

            // Tasks the student has already applied for is removed:
            List<int> aTasks = SQL.FetchAllAppliedForTaskIDs(ThisStudent.ID);
            foreach(int task in aTasks)
            {
                AllTasks.RemoveAll(t => t.ID == task);
            }

            // All task valid for applications are itterated:
            foreach (TaskRecommend task in AllTasks)
            {
                if (task.RequiredSkills != null || task.RequiredSkills.Count > 0)
                {
                    // First a match in skills between all tasks and the students skills:
                    foreach (Skill skill in task.RequiredSkills)
                    {
                        if(skill.ID != 0)
                        {
                            foreach (SkillStudent sSkill in ThisStudent.Skills)
                            {   // A verified skill counts twice as much as an unverfied:
                                if (sSkill.ID == skill.ID && sSkill.Verified) task.RecommendScore += 2;
                                else if (sSkill.ID == skill.ID && !sSkill.Verified) task.RecommendScore += 1;
                            }
                        }

                    }
                }
                if (checkAssignedTasks)
                {
                    // After we check if the student has completed a task or has one ongoing for the SME owner before:
                    foreach (TaskAssigned assignedTask in ThisStudent.AssignedTasks)
                    {
                        // And if he has, the rec score is increased:
                        if (assignedTask.SMEID == task.SMEID && (assignedTask.StateID == 4 || assignedTask.StateID == 3))
                        {
                            task.RecommendScore += 3;
                            break;
                        }
                    }
                }
                // We require atleast some match for the task to be recommended, unless its a get all tasks:
                if (!getAll && task.RecommendScore > 2) resultList.Add(task);
                else if (getAll) resultList.Add(task);
            }

            // The Result list is sorted by recScore:
            resultList = resultList.OrderByDescending(t => t.RecommendScore).ToList();

            // If we are looking for specific good matches, and have found more than 7:
            if(!getAll && resultList.Count > 7) return resultList.Take(7).ToList();
            return resultList;
        }
    }
}
