using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner5
{
    class Building
    {
        //        Private Fields
        //_designer of type string. It will hold your name.
        private string DesingnerName { get; set; }
        //_dateConstructed of type DateTime.This will hold the exact time the building was created.
        private DateTime DateConstructed { get; set; }
        //_address of type string.
        private string BuildingAddress { get; set; }
        //_owner of type string. This will store the same of the person who owns the building.
        private string BuildingOwner { get; set; }

        //        Public Properties
        //Stories typed as an integer.
        public int NumberOfStories { get; set; }
        //Width typed as a double.
        public double Width { get; set; }
        //Depth typed as a double.
        public double Depth { get; set; }
        //Volume should be read-only and should return width* depth * (3 * # of stories). Each story is 3 meters high.
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * NumberOfStories);
            }
        }

        //        Constructor
        //Define a constructor method that accepts a single string argument - address - so that you can send as a parameter when you create each instance with new Building("800 8th Street");.

        //The constructor's logic should set the _address field's value to the argument value
        public Building(string address, string designer)
        {
            BuildingAddress = address;
            DesingnerName = designer;

        }
        //        Public Methods
        //Define a Construct() method.The method's logic should set the _dateConstructed field's value to DateTime.Now.
        public void Construct()
        {
             DateConstructed = DateTime.Now;
        }
        //Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building.The method should take that string and assign it to the private _owner field.
        public void Purchase(string buyer)
        {
            BuildingOwner = buyer;
        }
        //Neither of these methods will return a value.


        //        100 Main Street
        //---------------
        //Designed by Steve Brownlee
        //Constructed on 2/1/18 7:19:08 AM
        //Owned by Bob Ross
        //16128 cubic meters of space

        public void DisplayBuildingInfo()
        {
            Console.WriteLine(BuildingAddress);
            Console.WriteLine("--------------");
            Console.WriteLine("Designed by: " + DesingnerName);
            Console.WriteLine("Date Constructed: " + DateConstructed);
            Console.WriteLine("Owned by: " + BuildingOwner);
            Console.WriteLine(Volume + " cubic meteres of space");
        }



    }
}
