using System;

namespace FishingBoat
{
    class FishingBoat
    {
        static void Main(string[] args)
        {
            var budget = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var groupCount = int.Parse(Console.ReadLine());

            var boatRent = 0.0;

            //check season
            if (season == "Spring")
            {
                boatRent = 3000.0;                
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatRent = 4200.0;
            }
            else if (season == "Winter")
            {
                boatRent = 2600.0;
            }
            // Check discounts for groups
            if (groupCount >= 12)
            {
                boatRent *= 0.75;
            }
            else if (groupCount >= 7)
            {
                boatRent *= 0.85;
            }
            else if (groupCount <= 6)
            {
                boatRent *= 0.90;
            }
            //check if additional disscount
            if ((groupCount % 2 == 0) && season != "Autumn")
            {
                boatRent *= 0.95;
            }

            if (budget >= boatRent)
            {
                Console.WriteLine($"Yes! You have {(budget - boatRent):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - boatRent):f2} leva.");
            }
        }
    }
}
