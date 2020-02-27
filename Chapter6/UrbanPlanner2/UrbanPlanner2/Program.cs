using System;
using System.Collections.Generic;

namespace UrbanPlanner2
{
    class Program
    {
        static void Main(string[] args)
        {
            Building MCTC = new Building("1 Moutwest Way", "Satoshi Nakamoto")
            {
                Width = 100,
                Depth = 200,
                NumberOfStories = 4,

            };
            Building CapitalBuilding = new Building("412 8th Street", "Art Deckko")
            {
                Width = 1000,
                Depth = 250,
                NumberOfStories = 6,

            };
            Building MyHouse = new Building("1 Holler Way", "Me")
            {
                Width = 10,
                Depth = 50,
                NumberOfStories = 1,

            };
            //            Once the class is defined to your liking, refactor your code in Main() to create a new city instance and add your buildings to it.Once all buildings are in the city, refactor your code that outputs the building info to the console to be inside a foreach loop that iterate the city's building collection.
            //Construct each building.
            MCTC.Construct();
            CapitalBuilding.Construct();
            MyHouse.Construct();
            MCTC.Purchase("Russ Miller");
            CapitalBuilding.Purchase("John Nash");
            MyHouse.Purchase("Russ Miller");

            MCTC.DisplayBuildingInfo();
            CapitalBuilding.DisplayBuildingInfo();
            MyHouse.DisplayBuildingInfo();
            //Example
            //City megalopolis = new City();
            City Huntington = new City("Huntington");
            Huntington.AddBuilding(MCTC);
            Huntington.AddBuilding(MyHouse);
            Huntington.AddBuilding(CapitalBuilding);



            //foreach (Building building in megalopolis.Buildings) {
            //    Console.WriteLine(...);
            Console.WriteLine("\n ****** Loop through building list of the city created ********\n");
            foreach (Building building1 in Huntington.BuildingList)
            {
                building1.DisplayBuildingInfo();
            }

            //Create some employees
            Employee u4454565 = new Employee("Russell", "Miller")
            {
                Title = "Peon"
            };
            Employee u4454566 = new Employee("Jon", "Dough")
            {
                Title = "Secret Shopper"
            };
            Employee u4454567 = new Employee("Arya", "Start")
            {
                Title = "President CEO"
            };

            Company CoinDesk = new Company("Coin Desk");

            CoinDesk.AddEmployee(u4454565);
            CoinDesk.AddEmployee(u4454566);
            CoinDesk.AddEmployee(u4454567);


            CoinDesk.ListEmployees();


            Console.WriteLine("how to use debugger");
        }
    }
}
