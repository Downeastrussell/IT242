using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner2
{
    class City
    {
        //        Now you need to create a type to represent your city.Here are the requirements for the class. You determine if/when to use fields, properties, a constructor, and methods.


        //a constructor for making Cities
        public City(string cityName)
        {
            NameOfCity = cityName;
        }
            //Name of the city.
        public string NameOfCity { get; }
            //The mayor of the city.
        public string MayorName { get; set; }
            //Year the city was established.
        public DateTime YearEstablished { get; set; }
        //A collection of all of the buildings in the city.
        public List<Building> BuildingList = new List<Building>()
        {

        };
            //A method to add a building to the city.
        public void AddBuilding(Building newBuilding)
        {
            BuildingList.Add(newBuilding);
        }







        






            
          








    }
}
