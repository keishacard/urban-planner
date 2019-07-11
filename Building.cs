using System;

namespace urban_planner
{
    public class Building
    {
        // private fields
        private string _designer = "Keisha";

        private DateTime _dateConstructed;

        private string _address;

        private string _owner;
        // public properties

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public string BuildingName { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        // constructor

        public Building(string BuildingAddress)
        {

            _address = BuildingAddress;
        }

        // public methods

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string Purchaser)
        {
            _owner = Purchaser;
        }


        /* example output: 100 Main Street
        // ---------------
        // Designed by Steve Brownlee
        // Constructed on 2/1/18 7:19:08 AM
        // Owned by Bob Ross
        // 16128 cubic meters of space*/

        public void BuildinInfo()
        {
            Console.WriteLine($"{BuildingName}");
            Console.WriteLine($"{_address}");
            Console.WriteLine("------------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic feet of space");
            Console.WriteLine("");
            Console.WriteLine("");
        }


    }
}