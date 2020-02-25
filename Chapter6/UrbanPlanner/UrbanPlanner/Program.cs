using System;
using System.Collections.Generic;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {




            Building EastSt = new Building("123 East st")
            {
                Stories = 4,
                Width = 500,
                Depth = 200

            };

            Building ChaseBank = new Building("10th Street and 5th Ave")
            {

                Stories = 3,
                Width = 250,
                Depth = 600
            };

            Building RecCenter = new Building("Hal Greer and 3rd Ave")
            {

                Stories = 5,
                Width = 300,
                Depth = 955
            };


            // Construct each building.
            // Have business people in your city purchase each of your buildings.

            EastSt.Construct();
            EastSt.Purchase("Tonald Drump");
            ChaseBank.Construct();
            ChaseBank.Purchase("Bill Gates");
            RecCenter.Construct();
            RecCenter.Purchase("Jeff Bezos");




            // After all of the buildings have been purchased, display the following information to the console for each building.

            // 100 Main Street
            // ---------------
            // Designed by Steve Brownlee
            // Constructed on 2/1/18 7:19:08 AM
            // Owned by Bob Ross
            // 16128 cubic meters of space

            List<Building> buildingList = new List<Building>(){
                EastSt,
                ChaseBank,
                RecCenter

            };

            City Ona = new City("Ona")
            {
                Mayor = "Daniel Doom",
                YearEst = 1912
            };

            City Huntington = new City("Huntington")
            {
                Mayor = "Steve Williams",
                YearEst = 1845
            };

            Ona.AddBuilding(EastSt);
            Huntington.AddBuilding(RecCenter);
            Huntington.AddBuilding(ChaseBank);

            List<City> cityList = new List<City>();
            cityList.Add(Huntington);
            cityList.Add(Ona);

            foreach (City city in cityList)
            {
                Console.WriteLine("*******************************");
                Console.WriteLine($"******Buildings in {city.NameOfCity}*********");
                Console.WriteLine("*******************************");

                foreach (Building building in city.cityBuildingList)
                {
                    building.DisplayInfo();
                }

            }
        }
    }
}