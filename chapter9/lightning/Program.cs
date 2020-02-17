using System;
using System.Collections.Generic;

namespace lightning
{


    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string,string> sandwich = new Dictionary<string,string>(){
            //     {"bread", "wheat"},
            //     {"price", "1.99"}

            // };


            // sandwich.Add("numberOfCalories", "200");
            // sandwich.Add("ingredients", "pickles, lettuce, meat");

            Sandwich tuna = new Sandwich("tuna fish", 9.99, 1500);
            tuna.bread = "white";
            tuna.price = 3.99;
            tuna.name = "tuna";
            tuna.ingredients = new List<string>(){
                "tuna",
                "mayo"
            };

            Sandwich italian = new Sandwich("italian", 5.99, 2000);
            tuna.bread = "white";





            List<Sandwich> listSandwich = new List<Sandwich>(){
                italian,
                tuna
            };


            Custos russ = new Custos("russ", "miller", "r@r.com");
            russ.rewards = 200;
            russ.favSandwich = italian;


            Custos bob = new Custos("bob","Miller","rus@russ.com");
            bob.rewards = 100;
            bob.favSandwich = tuna;

            Custos jon = new Custos("jon","Miller","ru@russ.com");
            jon.rewards = 0;
            jon.favSandwich = tuna;


            tuna.getTotalCalories(4);





            List<Custos> listOfCustos = new List<Custos>(){
                russ,
                bob,
                jon
            };

            foreach(Custos x in listOfCustos){
                Console.Write($"{x.fname} {x.lname} has {x.rewards} points and his email is {x.email}");
            }

            russ.eatSandwich(tuna);
            russ.eatSandwich(italian);
            russ.addPoints(10000);






        }
    }
}
// # Lightning Exercise Four
// 1. Add a constructor to the customer class that sets the customer's first name, last name, and email.
// 3. Refactor wherever you created your instances of customers to pass data into the constructor method.