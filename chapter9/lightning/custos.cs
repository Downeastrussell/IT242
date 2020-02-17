
using System;
using System.Collections.Generic;

namespace lightning
{
    class Custos
    {

        public Custos(string firstNameParam, string lastNameParam, string emailParam)
        {
            fname = firstNameParam;
            lname = lastNameParam;
            email = emailParam;
        }

        public string fname { get; set; }
        public string lname { get; set; }
        public int rewards { get; set; }
        public string email { get; set; }

        public Sandwich favSandwich { get; set; }

        public void addPoints(int points)
        {
            rewards += points;
            Console.WriteLine(rewards);
        }


        public void eatSandwich(Sandwich thingToEat)
        {
            if (thingToEat.name == favSandwich.name)
            {
                Console.WriteLine("good");
            }
            else
            {
                Console.WriteLine("bad");
            }
        }
    }



}