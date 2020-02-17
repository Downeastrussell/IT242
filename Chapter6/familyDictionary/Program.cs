using System;
using System.Collections.Generic;

namespace familyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Anya"},
            {"age", "18"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){
            {"name", "Kyle"},
            {"age", "34"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {

                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old!");

            }



        }
    }
}
