using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner2
{
    class Company
    {
        public Company(string name)
        {
            CompanyName = name;
            DateFounded = DateTime.Now;
        }
        public DateTime DateFounded { get; }
        public string CompanyName { get; }

        public List<Employee> employeeList = new List<Employee> { };

        public void AddEmployee(Employee newHire)
        {
            employeeList.Add(newHire);
        }

        public void ListEmployees()
        {
            foreach (Employee employee in employeeList) { 
            Console.WriteLine("************************************");
            Console.WriteLine($"{employee.EmployeeName}");
            Console.WriteLine($"{employee.Title}");
            Console.WriteLine("\n");
  
        }}

    }


    }

