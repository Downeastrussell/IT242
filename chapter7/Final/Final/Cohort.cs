using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    class Cohort
    {
 

        public Cohort(string cohortName)
        {
            CohortName = cohortName;
            Students = new List<Student>();            
            Instructors = new List<Instructor>();
        }
        public string CohortName { get; set; }

        private List<Student> Students { get; set; }

        public void AddStudent(Student newStudent)
        {
            newStudent.Cohort = this;
            Students.Add(newStudent);
        }
        private List<Instructor> Instructors { get; set; }

        public void AddInstructor(Instructor instructor)
        {
            instructor.InstructorCohort = this;
            Instructors.Add(instructor);
        }

    }
}
