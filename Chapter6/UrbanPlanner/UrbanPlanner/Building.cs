using System;

namespace UrbanPlanner
{


    class Building
    {
        public Building(string addressParam)
        {
            Address = addressParam;
            Designer = "Satoshi Nakamoto";
        }

        private string Designer { get; set; }
        private DateTime DateConstructed { get; set; }
        private string Address { get; set; }
        private string Owner { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public void Construct()
        {
            DateConstructed = DateTime.Now;

        }
        public void Purchase(string name)
        {
            Owner = name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(Address);
            Console.WriteLine("********************************");
            Console.WriteLine($"Designed by {Designer}");
            Console.WriteLine($"Constructed on {DateConstructed}");
            Console.WriteLine($"Owned by {Owner}");
            Console.WriteLine($"{Volume} cubic meters of space");

        }




    }

}