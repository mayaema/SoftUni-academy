using System;

namespace TailoringWorkShop
{
    class TailoringWorkshop
    {
        static void Main(string[] args)
        {
            var tablesOrderCount = int.Parse(Console.ReadLine());
            var tableLentghInMeters = double.Parse(Console.ReadLine());
            var tableWidthInMeters = double.Parse(Console.ReadLine());

            var sideKare = tableLentghInMeters / 2;
            double additionalCover = 2 * 0.30;
            var areaOfPokrivka = (tableLentghInMeters + additionalCover) * (tableWidthInMeters + additionalCover);
            var areaKare = sideKare * sideKare;

            var neededCovers = areaOfPokrivka * tablesOrderCount;
            var needeKare = areaKare * tablesOrderCount;

            var coversPriceInDolars = neededCovers * 7;
            var karePriceInDolars = needeKare * 9;
            var totalPriceInDolars = coversPriceInDolars + karePriceInDolars;

            var coversPriceInLeva = coversPriceInDolars * 1.85;
            var karePriceInLeva = karePriceInDolars * 1.85;
            var totalPriceInLeva = coversPriceInLeva + karePriceInLeva;

            Console.WriteLine($"{totalPriceInDolars:f2} USD");
            Console.WriteLine($"{totalPriceInLeva:f2} BGN");
        }
    }
}
