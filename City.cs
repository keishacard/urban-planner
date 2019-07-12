using System;
using System.Collections.Generic;

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

        public List<Building> BuildingList { get; set; }

        // methods
        public void ConstructCity()
        {
            BuildingList = new List<Building>();
        }

        public void AddBuilding(Building BuildingName)
        {
            BuildingList.Add(BuildingName);
        }

        // print
        public void CityInfo()
        {
            Console.WriteLine($"{cityName}");
            Console.WriteLine("------------------");
            Console.WriteLine($"Mayor {Mayor}");
            Console.WriteLine($"Established in {yearEstablished}");
            Console.WriteLine($"Buildings in this city: ");
            foreach (Building building in BuildingList)
            {
                building.BuildinInfo();
            }
            Console.WriteLine("\n\n");
        }

    }
}