using System;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Building FiveOneTwoEigth = new Building("512 8th Avenue");

            var Hogwarts = new Building("777 Scottish Highlands Way")
            {
                BuildingName = "Hogwarts",
                Stories = 17,
                Depth = 500,
                Width = 500

            };

            var DraculasCastle = new Building("666 Strada Romania")
            {
                BuildingName = "Dracula's Castle",
                Stories = 13,
                Depth = 333,
                Width = 333,
            };

            var WinchesterHouse = new Building("525 S Winchester Blvd")
            {
                BuildingName = "Winchester House",
                Stories = 7,
                Depth = 54,
                Width = 35,
            };

            var AmityvilleHouse = new Building("112 Ocean Ave")
            {
                BuildingName = "Amityville House",
                Stories = 3,
                Depth = 25,
                Width = 35,
            };

            var ThreeBroomsticks = new Building("3 Hogsmeade Lane")
            {
                BuildingName = "The Three Broomsticks Pub",
                Stories = 2,
                Depth = 20,
                Width = 13,
            };

            var Honeydukes = new Building("12 Hogsmeade Lane")
            {
                BuildingName = "Honeydukes Sweets Shoppe",
                Stories = 2,
                Depth = 22,
                Width = 22,
            };

            var Gingerbread = new Building("9 Gretel Ave")
            {
                BuildingName = "Gingerbread House",
                Stories = 1,
                Depth = 13,
                Width = 13,
            };


            Hogwarts.Construct();
            Hogwarts.Purchase("Albus Dumbledore");
            Hogwarts.BuildinInfo();

            DraculasCastle.Construct();
            DraculasCastle.Purchase("Vlad the Impaler");
            DraculasCastle.BuildinInfo();

            WinchesterHouse.Construct();
            WinchesterHouse.Purchase("Sarah Winchester");
            WinchesterHouse.BuildinInfo();

            AmityvilleHouse.Construct();
            AmityvilleHouse.Purchase("Kathleen Lutz");
            AmityvilleHouse.BuildinInfo();

            ThreeBroomsticks.Construct();
            ThreeBroomsticks.Purchase("Madam Rosemerta");
            ThreeBroomsticks.BuildinInfo();

            Honeydukes.Construct();
            Honeydukes.Purchase("Ambrosius Flume");
            Honeydukes.BuildinInfo();

            Gingerbread.Construct();
            Gingerbread.Purchase("Wilhelm Grimm");
            Gingerbread.BuildinInfo();

            // CITY STUFF

            /*Name of the city.
           The mayor of the city.
           Year the city was established.
           A collection of all of the buildings in the city.
           A method to add a building to the city.*/

            var Hogsmeade = new City()
            {
                cityName = "Hogsmeade",
                Mayor = "Aberforth Dumbledore",
                yearEstablished = 1612,
                // cityBuildings = 22,
            };

            var AmericaCity = new City()
            {
                cityName = "Ghostville",
                Mayor = "Lorraine Warren",
                yearEstablished = 1884,
                // cityBuildings = 22,
            };

            var OldworldCity = new City()
            {
                cityName = "Oldenburg",
                Mayor = "Baba Yaga",
                yearEstablished = 666,
                // cityBuildings = 22,
            };


            Hogsmeade.CityInfo();
            AmericaCity.CityInfo();
            OldworldCity.CityInfo();

        }
    }
}
