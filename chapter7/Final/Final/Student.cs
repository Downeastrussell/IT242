using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    class Student
    {
public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Assignments = new List<Exercise>();
        }

        private string FirstName { get; }
        private string LastName { get; }
        private string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Assignments { get; set; }







    }
}
