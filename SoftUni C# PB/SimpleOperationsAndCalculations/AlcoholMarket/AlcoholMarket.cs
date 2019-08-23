using System;

namespace AlcoholMarket
{
    class AlcoholMarket
    {
        static void Main(string[] args)
        {
            var wiskeyPrice = double.Parse(Console.ReadLine());
            var beerQuantity = double.Parse(Console.ReadLine());
            var wineQuantity = double.Parse(Console.ReadLine());
            var rakiqQuantity = double.Parse(Console.ReadLine());
            var wiskeyQuantity = double.Parse(Console.ReadLine());

            var rakiqPrice = wiskeyPrice / 2;
            var winePrice = rakiqPrice * 0.60;
            var beerPrice = rakiqPrice * 0.20;

            var MoneyNeededForPartyBoose = (rakiqPrice * rakiqQuantity) + (winePrice * wineQuantity) + 
                                           (beerPrice * beerQuantity) + (wiskeyPrice * wiskeyQuantity);

            Console.WriteLine($"{MoneyNeededForPartyBoose:f2}");
        }
    }
}
