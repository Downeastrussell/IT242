using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace dictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();




            Dictionary<string, string> excited = new Dictionary<string, string>();

            excited.Add("word", "excited");
            excited.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excited.Add("part of speech", "adjective");
            excited.Add("example sentence", "I am excited to learn C#!");

            dictionaryOfWords.Add(excited);



            Dictionary<string, string> bitcoin = new Dictionary<string, string>();

            bitcoin.Add("word", "bitcoin");
            bitcoin.Add("definition", "majik internet monies");
            bitcoin.Add("part of speech", "noun");
            bitcoin.Add("example sentence", "I am excited to stack bitcoin sats");



            dictionaryOfWords.Add(bitcoin);

            Dictionary<string, string> computers = new Dictionary<string, string>();

            computers.Add("word", "computers");
            computers.Add("definition", "boxes for data");
            computers.Add("part of speech", "noun");
            computers.Add("example sentence", "I am excited to computer");



            dictionaryOfWords.Add(computers);
            Console.WriteLine(dictionaryOfWords);











            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
               {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few word
            // Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            // excitedWord.Add();

            // Add Dictionary to your `dictionaryOfWords` list


            // create another Dictionary and add that to the list


            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> list in dictionaryOfWords)
            {
                Console.WriteLine("------");
                foreach (KeyValuePair<string, string> word in list)
                {

                    Console.WriteLine($"{word.Key}: {word.Value} ");
                }
            }

        }
    }
}
