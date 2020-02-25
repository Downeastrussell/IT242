using System;

namespace chapter6LectureCode
{
    class Program
    {
        public class Writer
        {
            public Writer(string prefix)
            {
                Prefix = prefix;
            }

            public string Prefix { get; set; }

            public void Write(string message)
            {
                Console.WriteLine(Prefix + message);
            }
        }



        static void Main(string[] args)
        {


            // The output variable's type is `string` -- a built in type
            string output = "Nashville Software School";

            // The author variable's type is Writer -- a custom type you defined
            Writer author = new Writer("I do declare: ");
            author.Write(output);

            author.Prefix = "That's right, I said: ";
            author.Write(output);



            //For automobile lecture code
            Automobile generic_auto = new Automobile();
            Console.WriteLine($"Automobiles go {generic_auto.Accelerate()}");

            Car stella = new Car() { };

           
                
                
            Console.WriteLine($"Cars go {stella.Accelerate()}");

            // However, the following line of code does not compile
            //change the access modifier in Automobiles.cs so this code compiles
            Console.WriteLine(generic_auto.InjectFuel());
        }
    }
}
