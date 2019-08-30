using System;

namespace GodzillaVSKong
{
    class GodzillaVSKong
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var statistiCount = int.Parse(Console.ReadLine());
            var costumePriceForPerson = double.Parse(Console.ReadLine());

            var decorExpensses = budget * 0.10;
            var costumeExpensses = statistiCount * costumePriceForPerson;

            if (statistiCount > 150)
            {
                costumeExpensses *= 0.90;
            }

            var totalExpensses = decorExpensses + costumeExpensses;

            if (budget >= totalExpensses)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalExpensses:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - totalExpensses):f2} leva more.");
            }           
        }
    }
}
