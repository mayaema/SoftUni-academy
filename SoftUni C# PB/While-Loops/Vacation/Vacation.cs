using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var moneyNeeded = double.Parse(Console.ReadLine());
            var moneySaved = double.Parse(Console.ReadLine());
            var spendCounter = 0;
            var daysCounter = 0;

            while (true)
            {
                var inOrOut = Console.ReadLine();
                var amount = double.Parse(Console.ReadLine());

                daysCounter++;
                if (inOrOut == "spend")
                {
                    moneySaved -= amount;
                    if (moneySaved < 0)
                    {
                        moneySaved = 0.0;
                    }
                    spendCounter++;
                }
                if (spendCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysCounter}");
                    break;
                }
                else if (inOrOut == "save")
                {
                    moneySaved += amount;
                    spendCounter = 0;
                    if (moneySaved >= moneyNeeded)
                    {
                        Console.WriteLine($"You saved the money for {daysCounter} days.");
                        break;
                    }
                }
            }
        }
    }
}
