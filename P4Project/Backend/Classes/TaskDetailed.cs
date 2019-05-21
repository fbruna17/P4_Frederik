using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Project.Backend.Classes
{
    // Denne klasse bruges til at håndterer alle detaljerne der er om en task:
    public class TaskDetailed : TaskSearched
    {
        public List<Skill> RequiredSkills { get; }
        public string Description { get; }
        public int AssignedStudentID { get; }
        public List<StudentApplicant> Applicants { get; private set; }
        public List<ApplicationBase> Applications { get; private set; }

        // Denne constructer tager alle de nødvendige informationer for at kunne displaye en Task for en bruger:
        public TaskDetailed(int id, int smeid, string title, string location, int hours, string description, 
                               DateTime startdate, DateTime applicationDeadline, DateTime estCompletionDate, int stateID, 
                               List<Skill> requiredSkills, int assignedStudentID) 
                               : base(id, smeid, title, location, hours, startdate, applicationDeadline, estCompletionDate, stateID)
        {
            // Dataene ligges i de korrekte properties:
            RequiredSkills = requiredSkills;
            Description = description;
            AssignedStudentID = assignedStudentID;
            // En funktion fra TaskBase der sætter SMENamet:
            GetSMEName();
        }
        // Funktion der henter Applicants for den givne task:
        public List<StudentApplicant> GetApplicants()
        {
            SQLControl sql = new SQLControl();
            Applicants = sql.FetchApplicantsForTask(ID);
            return Applicants;
        }

        public void GetApplications()
        {
            SQLControl sql = new SQLControl();
            Applications = sql.FetchAllApplications(ID);
        }
    }
}
