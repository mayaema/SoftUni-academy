using System;

namespace CharityCampaign
{
    class CharityCampaign
    {
        static void Main(string[] args)
        {
            var campaignDays = int.Parse(Console.ReadLine());
            var bakersCount = int.Parse(Console.ReadLine());
            var cakesCount = int.Parse(Console.ReadLine());
            var wafellsCount = int.Parse(Console.ReadLine());
            var panecakesCount = int.Parse(Console.ReadLine());

            var totalCakes = cakesCount * bakersCount * campaignDays;
            var totalWafells = wafellsCount * bakersCount * campaignDays;
            var totalPanecakes = panecakesCount * bakersCount * campaignDays;

            double incomeFromCakes = totalCakes * 45d;
            double incomeFromWafells = totalWafells * 5.80d;
            double incomeFromPanecakes = totalPanecakes * 3.20d;

            var totalIncome = incomeFromCakes + incomeFromPanecakes + incomeFromWafells;
            var totalProfit = totalIncome - (totalIncome * 0.125);

            Console.WriteLine($"{totalProfit:f2}");
        }
    }
}
