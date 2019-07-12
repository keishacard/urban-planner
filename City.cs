using System;

namespace urban_planner
{
    public class City
    {
        /*Name of the city.
        The mayor of the city.
        Year the city was established.
        A collection of all of the buildings in the city.
        A method to add a building to the city.*/

        public string cityName { get; set; }

        public string Mayor { get; set; }

        public int yearEstablished { get; set; }

        public string cityBuildings { get; set; }

        // methods

        // public void ConstructCity();

        // print
        public void CityInfo()
        {
            Console.WriteLine($"{cityName}");
            Console.WriteLine("------------------");
            Console.WriteLine($"Mayor {Mayor}");
            Console.WriteLine($"Established in {yearEstablished}");
            // Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine("\n\n");
        }

    }
}