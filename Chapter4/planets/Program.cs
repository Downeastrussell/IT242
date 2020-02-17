using System;
using System.Collections.Generic;

namespace planets
{
    class Program
    {
        static void Main(string[] args)
        {



            List<string> planetList = new List<string>(){
                "Mercury",
                 "Mars"
                };

            planetList.Add("jupiter");
            planetList.Add("saturn");

            List<string> lastPlanets = new List<string>(){
                "yourAnus",
                 "pluto"
                };

            planetList.AddRange(lastPlanets);

            planetList.Insert(1,"earth");
            planetList.Insert(5,"venus");

            Console.WriteLine(planetList);


            string[] rockyPlanets = planetList.GetRange(0, 3).ToArray();

            Console.WriteLine(rockyPlanets);

            planetList.Remove("pluto");

            Console.WriteLine(planetList);














        }


    }
}


// Add() Jupiter and Saturn at the end of the list.
// Create another List that contains that last two planet of our solar system.
// Combine the two lists by using AddRange().
// Use Insert() to add Earth, and Venus in the correct order.
// Use Add() again to add Pluto to the end of the list.
// Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
// Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.