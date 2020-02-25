using System;

namespace UrbanPlanner5
{
    class Program
    {
        static void Main(string[] args)
        {
            Building MCTC = new Building("1 Moutwest Way", "Satoshi Nakamoto")
            {
                Width = 100,
                Depth = 200,
                NumberOfStories = 4
            };
            Building CapitalBuilding = new Building("412 8th Street", "Art Deckko")
            {
                Width = 1000,
                Depth = 250,
                NumberOfStories = 6
            };
            Building MyHouse = new Building("1 Holler Way", "Me")
            {
                Width = 10,
                Depth = 50,
                NumberOfStories = 1
            };

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






            Console.WriteLine("");
        }
    }
}
