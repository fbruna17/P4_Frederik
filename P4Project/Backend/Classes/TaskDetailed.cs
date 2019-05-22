using System;
using System.Collections.Generic;
using System.Linq;

namespace P4Project.Backend.Classes
{
    // This class is used to store all information on a task for displaing in TaskView:
    public class TaskDetailed : TaskSearched
    {
        public List<Skill> RequiredSkills { get; }
        public string Description { get; }
        public int AssignedStudentID { get; }
        public List<StudentApplicant> Applicants { get; private set; }
        public List<ApplicationBase> Applications { get; private set; }

        // All neccesarry information is required to make an instance of this class:
        public TaskDetailed(int id, int smeid, string title, string location, int hours, string description, 
                               DateTime startdate, DateTime applicationDeadline, DateTime estCompletionDate, int stateID, 
                               List<Skill> requiredSkills, int assignedStudentID) 
                               : base(id, smeid, title, location, hours, startdate, applicationDeadline, estCompletionDate, stateID)
        {
            RequiredSkills = requiredSkills;
            Description = description;
            AssignedStudentID = assignedStudentID;
            // A Method from the superclass to fetch the SME owner Name:
            GetSMEName();
        }

        // A method to get all students who has applied for this task:
        public List<StudentApplicant> GetApplicants()
        {
            SQLControl sql = new SQLControl();
            Applicants = sql.FetchApplicantsForTask(ID).OrderByDescending(s => s.RecommendationScore).ToList();
            return Applicants;
        }

        // Gets all applications related to this task:
        public void GetApplications()
        {
            SQLControl sql = new SQLControl();
            Applications = sql.FetchAllApplications(ID);
        }
    }
}
