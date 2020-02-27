using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner2
{
    class Employee
    {
        //Using C# classes, you need to create custom types to represent an Employee and a Company. Then you will create some employees, hire them into the company and then display a simple report showing the employee names and their titles.
        public Employee(string firstname, string lastname)
        {
            EmployeeName = firstname + " " + lastname;
            StartDate = DateTime.Now;

        }

        public string EmployeeName { get; }

        public string Title { get; set; }

        public DateTime StartDate { get; }
    }
}
