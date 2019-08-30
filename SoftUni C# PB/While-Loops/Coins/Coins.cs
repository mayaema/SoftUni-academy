using System;

namespace Coins
{
    class Coins
    {
        static void Main(string[] args)
        {
            var coinsChange = decimal.Parse(Console.ReadLine());
            var counter = 0;

            while (coinsChange > 0.0m)
            {
                if (coinsChange >= 2.0m)
                {
                    coinsChange -= 2.0m;
                    counter++;
                }
                else if (coinsChange >= 1.0m)
                {
                    coinsChange -= 1.0m;
                    counter++;
                }
                else if (coinsChange >= 0.5m)
                {
                    coinsChange -= 0.50m;
                    counter++;
                }
                else if (coinsChange >= 0.2m)
                {
                    coinsChange -= 0.2m;
                    counter++;
                }
                else if (coinsChange >= 0.1m)
                {
                    coinsChange -= 0.1m;
                    counter++;
                }
                else if (coinsChange >= 0.05m)
                {
                    coinsChange -= 0.05m;
                    counter++;
                }
                else if (coinsChange >= 0.02m)
                {
                    coinsChange -= 0.02m;
                    counter++;
                }
                else if (coinsChange >= 0.01m)
                {
                    coinsChange -= 0.01m;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
