using System;

namespace SummerOutfit
{
    class SummerOutfit
    {
        static void Main(string[] args)
        {
            var degrees = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            var outfit = "";
            var shoes = "";

            if (time == "Morning")
            {
                if (degrees >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degrees > 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees >= 10)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
            }
            else if (time == "Afternoon")
            {
                if (degrees >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (degrees > 18)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degrees >= 10)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
