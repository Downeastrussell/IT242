using System;
using System.Collections.Generic;

namespace chapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // The output variable's type is `string` -- a built in type
            string output = "Nashville Software School";

            // The author variable's type is Writer -- a custom type you defined
            Writer author = new Writer("I do declare: ");
            author.Write(output);

            author.Prefix = "That's right, I said: ";
            author.Write(output);



            Automobile generic_auto = new Automobile();
            Console.WriteLine($"Automobiles go {generic_auto.Accelerate()}");

            Car stella = new Car();
            Console.WriteLine($"Cars go {stella.Accelerate()}");
            Truck ford = new Truck();
            Console.WriteLine($"Trucks go {ford.Accelerate()}");

            Box box = new Box();
            Console.WriteLine(box.GetSecret("please"));


        }
    }
}
