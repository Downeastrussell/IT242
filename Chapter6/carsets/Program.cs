using System;
using System.Collections.Generic;

namespace carsets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showroom = new HashSet<string>();
            showroom.Add("nsx");
            showroom.Add("wrx");
            showroom.Add("f150");
            showroom.Add("lambo");

            Console.WriteLine(showroom.Count);
            showroom.Add("lambo");
            Console.WriteLine(showroom.Count);

            HashSet<string> usedlot = new HashSet<string>();
            usedlot.Add("pinto");
            usedlot.Add("tesla");

            showroom.UnionWith(usedlot);

            showroom.Remove("pinto");
            Console.WriteLine("--In Showroom--");
            foreach (string x in showroom)
            {

                Console.WriteLine(x);
            };


            HashSet<string> junkyard = new HashSet<string>();
            junkyard.Add("ranger");
            junkyard.Add("avalon");
            junkyard.Add("wrangler");
            junkyard.Add("f150");
            junkyard.Add("lambo");
            junkyard.Add("rust bucket of death");

            HashSet<string> clone = new HashSet<string>(showroom);
            clone.IntersectWith(junkyard);
            Console.WriteLine("--Intersect With--");
            foreach (string x in clone)
            {

                Console.WriteLine(x);
            };

            showroom.UnionWith(junkyard);
            Console.WriteLine("--Updated Showroom after Junkyard Purchase--");
            foreach (string x in showroom)
            {

                Console.WriteLine(x);
            };

            Console.WriteLine("--Updated Showroom after removing rust bucket--");
            showroom.Remove("rust bucket of death");
            foreach (string x in showroom)
            {

                Console.WriteLine(x);
            };





        }
    }
}
