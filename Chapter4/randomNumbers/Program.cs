using System;
using System.Collections.Generic;

namespace randomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //how yo create a list of random numbers with built-in RNG functions
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            // to solve
            foreach(int x in numbers){
                Console.WriteLine(x+" is the random number generated");
            }


            for (int i = 0; i < numbers.Count; i++)
            {

                if(numbers.Contains(i)){
                    Console.WriteLine($"{i} is in the list");
                }else{
                    Console.WriteLine($"{i} is not in the list");
                }



            }
        }
    }
}
