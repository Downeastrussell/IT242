using System;
using System.Collections.Generic;

namespace UrbanPlanner
{

    class City
    {

        public City(string cityName)
        {
            NameOfCity = cityName;
        }

        // Now you need to create a type to represent your city. Here are the requirements for the class. You determine if/when to use fields, properties, a constructor, and methods.

        // Name of the city.
        // The mayor of the city.
        // Year the city was established.
        // A collection of all of the buildings in the city.
        // A method to add a building to the city.
        public string NameOfCity { get; }
        public string Mayor { get; set; }
        public int YearEst { get; set; }
        public List<Building> cityBuildingList = new List<Building>
        {

        };
        public void AddBuilding(Building buildingName)
        {
            cityBuildingList.Add(buildingName);
        }
    }

}