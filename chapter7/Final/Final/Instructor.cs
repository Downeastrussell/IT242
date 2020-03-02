using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    class Instructor
    {
        


        private string FirstName { get; set; }
        private string LastName { get; set; }
        public Instructor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

        private string InstructorSlackHandle { get; set; }

        public Cohort InstructorCohort { get; set; }
        public string Specialty { get; set; }
        public void AssignExercise(Student student, Exercise exercise )
        {
            student.Assignments.Add(exercise);
        }



    }
}
