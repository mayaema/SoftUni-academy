using System;

namespace Journey
{
    class Journey
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var destination = string.Empty;
            var accomudation = string.Empty;
            var moneySpend = 0.0;

            if (budget > 1000.0)
            {
                destination = "Europe";
                accomudation = "Hotel";
                moneySpend = budget * 0.9;
            }
            else if (budget <= 1000.0 && 100 < budget)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    accomudation = "Camp";
                    moneySpend = budget * 0.4; // to check
                }
                else if (season == "winter")
                {
                    accomudation = "Hotel";
                    moneySpend = budget * 0.8;
                }
            }
            else if (budget <= 100.0)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    accomudation = "Camp";
                    moneySpend = budget * 0.3;
                }
                else if (season == "winter")
                {
                    accomudation = "Hotel";
                    moneySpend = budget * 0.7;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomudation} - {moneySpend:f2}");
        }
    }
}
