using System;

namespace LabToyShop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            var excursionPrice = double.Parse(Console.ReadLine());
            var puzzleCount = int.Parse(Console.ReadLine());
            var talkingDollsCount = int.Parse(Console.ReadLine());
            var tedyBearsCount = int.Parse(Console.ReadLine());
            var minionsCount = int.Parse(Console.ReadLine());
            var trucksCount = int.Parse(Console.ReadLine());

            var totalPrice = (puzzleCount * 2.6) + (talkingDollsCount * 3.0) + (tedyBearsCount * 4.1) +
                (minionsCount * 8.2) + (trucksCount * 2.0);
            var totalCount = puzzleCount + talkingDollsCount + tedyBearsCount + minionsCount + trucksCount;

            if (totalCount >= 50)
            {
                totalPrice *= 0.75;
            }
            var profit = totalPrice * 0.9;

            if (excursionPrice <= profit)
            {
                Console.WriteLine($"Yes! {Math.Abs(excursionPrice - profit):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(profit - excursionPrice):F2} lv needed.");
            }
        }
    }
}
