using System;
using System.Collections.Generic;

namespace fiddleChapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary's are collections of a key/value pairs - just strongly typed. They can be of any type(int, string, bool, custom, etc).

            //////////////////////////////////////
            ////How to make a dictionary in C#///
            ////////////////////////////////////
            //makes a dictionary named 'toysSold' and adds key value pairs at the sane time, you can also make an empty dictionary and use nameOfDictionary.Add(Key, Value)
            Dictionary<int, int> numbers = new Dictionary<int, int>() {
                    {3, 344},
                    {4, 763},
                    {5, 551},
                    {30, 200}
                };

            /////////////////////////////////////////////////////////////////////////////////////////
            ////how to use .Add(Key, Value) to add KeyValuePairs to the dictionary named "toysSold"///
            //////////////////////////////////////////////////////////////////////////////////////////
            //  "GI Joe" = Key   and   430 = Value || together they make a KeyValuePair
            numbers.Add(31, 430);
            //access and print this newly added Value(430) to the console by using the key of "GI Joe"
            Console.WriteLine(numbers[30]);

        }
    }
}
