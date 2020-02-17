using System;
using System.Collections.Generic;

namespace lightning{
     class Sandwich
    {

        public Sandwich(string nameParam, double priceParam, int caloriesParam){
            name =  nameParam;
            price = priceParam;
            _caloriesPerServing = caloriesParam;
        }

        public string name {get; set;}
        public string bread { get; set; }


        public double price { get; set; }

        private int _caloriesPerServing { get; set; }

        public void getTotalCalories(int numberOfServings){
            int totalCalories = _caloriesPerServing * numberOfServings;
            Console.WriteLine($"{numberOfServings} servings = {totalCalories} calories");
        }

        public List<String> ingredients { get; set; }

        public Sandwich favSandwich {get; set;}

        public void eatSandwich(Sandwich thingToEat){
            if(thingToEat.name==favSandwich.name){
                 Console.WriteLine("good") ;
            }
            else{
                Console.WriteLine("bad") ;
            }
        }
    }
}