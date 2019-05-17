﻿using System;
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

        // Denne constructer tager alle de nødvendige informationer for at kunne displaye en Task for en bruger:
        public TaskDetailed(int id, SMEBase owner, string title, string location, int hours, string description, 
                               DateTime startdate, DateTime applicationDeadline, DateTime estCompletionDate, int stateID, 
                               List<Skill> requiredSkills, int assignedStudentID) 
                               : base(id, owner, title, location, hours, startdate, applicationDeadline, estCompletionDate, stateID)
        {
            // Dataene ligges i de korrekte properties:
            RequiredSkills = requiredSkills;
            Description = description;
            AssignedStudentID = assignedStudentID;
            // En funktion fra TaskBase der sætter SMENamet:
            GetSMEName();
        }
    }
}
