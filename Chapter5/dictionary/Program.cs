using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    Create a dictionary with key value pairs to
                    represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>(){
                {"bitcoin", "magic internet money"},
                {"shitcoins", "non magic scam money"},
                {"satoshi", "me muhahaha  ;)"}
            };

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");

            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */

            Console.WriteLine(wordsAndDefinitions["bitcoin"]);
            Console.WriteLine(wordsAndDefinitions["satoshi"]);

            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"{word.Key} is defined as {word.Value}");
            }
        }
    }
}
