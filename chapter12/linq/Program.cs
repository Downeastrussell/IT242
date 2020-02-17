using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        /*
            Start with a collection that is of type IEnumerable, which
            List is and initialize it with some values. This is the
            class sizes for a selection of NSS cohorts.
        */
        List<int> cohortStudentCount = new List<int>()
        {
            25, 12, 28, 22, 11, 25, 27, 24, 19
        };

        /*
            Now we need to determine which cohorts fell within the range
            of acceptable size - between 20 and 26 students. Also, sort
            the new enumerable collection in ascending order.
        */
        IEnumerable<int> idealSizes = from count in cohortStudentCount
                                      where count < 27 && count > 19
                                      orderby count ascending
                                      select count;

        // Display each number that was the acceptable size
        foreach (int c in idealSizes)
        {
            Console.WriteLine($"{c}");
        }

        int total = 0;
        int numberOfCohorts = cohortStudentCount.Count;

        foreach (int x in cohortStudentCount)
        {
            total += x;


        }
        int avg = total / numberOfCohorts;
        Console.WriteLine($"{avg} average size");

        foreach (int x in cohortStudentCount)
        {
            total += x;

        }
        Console.WriteLine($"{total} total number graduated");

        Console.WriteLine($"{cohortStudentCount.Min()} is smallest");
        Console.WriteLine($"{cohortStudentCount.Max()} is largest");

        Console.WriteLine(cohortStudentCount.Average());


        List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

        string L = "L";
        IEnumerable<string> LFruits = from fruit in fruits
                                      where fruit.StartsWith(L)
                                      select fruit;

        foreach (string x in LFruits)
        {
            Console.WriteLine(x);
        }


        // Which of the following numbers are multiples of 4 or 6
        List<int> numbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

        IEnumerable<int> fourSixMultiples = numbers.Where(x => x % 4 == 0 || x % 6 == 0);
        foreach (int x in fourSixMultiples)
        {
            Console.WriteLine(x);
        }

        // Order these student names alphabetically, in descending order (Z to A)
        List<string> names = new List<string>()
        {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
        };

        IEnumerable<string> descend = from n in names
                                      orderby n descending
                                      select n;
        foreach (string x in descend)
        {
            Console.WriteLine(x);
        }

        // Build a collection of these numbers sorted in ascending order
        List<int> numbers1 = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

        IEnumerable<int> orderedNumbers = from x in numbers1
                                          orderby x ascending
                                          select x;
        foreach (int x in orderedNumbers)
        {
            Console.WriteLine(x);
        }

        int sum = numbers1.Count();
        Console.WriteLine(sum);

        // How much money have we made?
        List<double> purchases = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };
        // What is our most expensive product?
        List<double> prices = new List<double>()
        {
            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };

        double total1 = purchases.Sum();
        double biggest = purchases.Max();
        Console.WriteLine(total1);
        Console.WriteLine(biggest);


        /*
        Store each number in the following List until a perfect square
        is detected.

        Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
        */
        List<int> wheresSquaredo = new List<int>()
        {
            66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
        };

        // Console.WriteLine(Math.Sqrt(4));
        foreach(int x in wheresSquaredo){
            if(((Math.Sqrt(x))% 1 == 0) ){
                //precision sucks in c#!!!!
                Console.WriteLine(x);
            }
        }






    }



}

