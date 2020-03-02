using System;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create 4, or more, exercises.
            Exercise Assignment1 = new Exercise()
            {
                ExerciseName = "Hello World",
                LanguageOfExercise = "C#"
            };
            Exercise Assignment2 = new Exercise()
            {
                ExerciseName = "ForLoops",
                LanguageOfExercise = "JavaScript"
            };
            Exercise Assignment3 = new Exercise()
            {
                ExerciseName = "Conditionals",
                LanguageOfExercise = "C++"
            };
            Exercise Assignment4 = new Exercise()
            {
                ExerciseName = "Sha256 Hash Puzzle",
                LanguageOfExercise = "Bitcoin Script"
            };


            //Create 3, or more, cohorts.
            Cohort Cohort1 = new Cohort("Evening Cohort 1");
            Cohort Cohort2 = new Cohort("Morning Cohort 1");
            Cohort Cohort3 = new Cohort("Morning Cohort 2");


            //Create 4, or more, students and assign them to one of the cohorts.
            Student SJ942555555 = new Student("Steve", "Johnson");
            Student JC942555554 = new Student("Justin", "Carney");
            Student ZR942555556 = new Student("Zzzz", "Rust");
            Student AS942555557 = new Student("Ashley", "Sanders");
            Student JY942555557 = new Student("Julie", "Yeager");
            Student SC942555557 = new Student("Scott", "Captner");


            //Assign 2 students to each cohort
            Cohort1.AddStudent(SJ942555555);
            Cohort1.AddStudent(AS942555557);
            Cohort2.AddStudent(SC942555557);
            Cohort2.AddStudent(ZR942555556);
            Cohort3.AddStudent(JY942555557);
            Cohort3.AddStudent(JC942555554);


            //Create instructors
            Instructor RM942339999 = new Instructor("Russell", "Miller") { };
            Instructor KP942339998 = new Instructor("Kim", "Preece") { };
            Instructor JJ942339999 = new Instructor("Josh", "Joeseph") { };


            //Assign Instructors to cohort
            Cohort1.AddInstructor(RM942339999);
            Cohort2.AddInstructor(KP942339998);
            Cohort3.AddInstructor(JJ942339999);


            //Have Instructors assign 2 exercises to each student in their cohort
            //RM assign 2 exercises per student
            RM942339999.AssignExercise(SJ942555555, Assignment1);
            RM942339999.AssignExercise(AS942555557, Assignment1);
            RM942339999.AssignExercise(SJ942555555, Assignment2);
            RM942339999.AssignExercise(AS942555557, Assignment2);

            //KP assign 2 exercise to the 2 students added to her cohort
            KP942339998.AssignExercise(AS942555557, Assignment1);
            KP942339998.AssignExercise(AS942555557, Assignment3);
            KP942339998.AssignExercise(ZR942555556, Assignment1);
            KP942339998.AssignExercise(ZR942555556, Assignment3);

            //JJ assign's 2 exercises to the two students in his cohort(cohort3)
            JJ942339999.AssignExercise(JY942555557, Assignment2);
            JJ942339999.AssignExercise(JY942555557, Assignment2);
            JJ942339999.AssignExercise(JC942555554, Assignment3);
            JJ942339999.AssignExercise(JC942555554, Assignment3);

            Console.WriteLine("debugger, put a breakpoint here press 'play' and hoover over every student and cohort to make sure you assigned them correctly, it WILL NOT print anything to the console. This is the only way to see if your methods are working properly");

            //FOR EXTRA CREDIT:create a list of students, add all your student to the list and write a method in Student.cs that displays each all the students info, including their assignments. Create a list of cohorts, and list all students and instructors











        }
    }
}
