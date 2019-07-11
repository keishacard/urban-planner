using System;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Building FiveOneTwoEigth = new Building("512 8th Avenue");

            var Hogwarts = new Building("777 Forbidden Forest Way, Scottish Highlands, UK")
            {
                Stories = 17,
                Depth = 500,
                Width = 500

            };

            var DraculasCastle = new Building("Strada General Traian Moșoiu 24, Bran 507025, Romania")
            {
                Stories = 13,
                Depth = 333,
                Width = 333,
            };

            var WinchesterHouse = new Building("525 S Winchester Blvd, San Jose, CA 95128")
            {
                Stories = 7,
                Depth = 54,
                Width = 35,
            };


            Hogwarts.Construct();
            Hogwarts.Purchase("Dumbledore");
            Hogwarts.BuildinInfo();

            DraculasCastle.Construct();
            DraculasCastle.Purchase("Vlad the Impaler");
            DraculasCastle.BuildinInfo();

            WinchesterHouse.Construct();
            WinchesterHouse.Purchase("Sarah Winchester");
            WinchesterHouse.BuildinInfo();

        }
    }
}
