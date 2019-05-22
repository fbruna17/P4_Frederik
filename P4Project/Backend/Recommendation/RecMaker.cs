using System.Collections.Generic;
using System.Linq;
using P4Project.Backend.Classes;

namespace P4Project.Backend.Recommendation
{
    // This Class is used as the class that calculates the recommendation of tasks to a student:
    // (The Score calculated is also shown to the SME when a student applied, so the SME can use the -
    // Reccommendation score to decide who to assign for a given task):
    public class RecMaker
    {
        private SQLControl SQL;
        private List<TaskRecommend> AllTasks;
        private StudentLoggedIn ThisStudent;

        // The constructor for when a student logs in and its recommendations are made:
        public RecMaker(StudentLoggedIn thisStudent)
        {
            SQL = new SQLControl();
            AllTasks = SQL.FetchAllTasksForRecommendation();
            ThisStudent = thisStudent;
        }

        // The constructor for when recommendations are being made on search results:
        public RecMaker(StudentLoggedIn thisStudent, List<TaskSearched> tasks)
        {
            SQL = new SQLControl();
            List<TaskRecommend> tempTasks = SQL.FetchAllTasksForRecommendation();
            AllTasks = new List<TaskRecommend>();

            // All public tasks are itterated through, and added too the list of tasks to recommend
            // if the tasks are in the search result:
            foreach (TaskRecommend task in tempTasks)
            {
                foreach(TaskSearched t in tasks)
                {
                    if(t.ID == task.ID) AllTasks.Add(task);
                }
            }
            ThisStudent = thisStudent;
        }

        // The Method that returns all the tasks with a recommendation score:
        // The boolean "getAll" is used to declare if all tasks should be returned, or only tasks with atlease some match up to 7:
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
                // If the student has already been assigned to some tasks:
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

            // Else all tasks are returned:
            return resultList;
        }
    }
}
