using System;

namespace CleverLily
{
    class CleverLily
    {
        static void Main(string[] args)
        {
            var lilyAge = int.Parse(Console.ReadLine());
            var washingMachinePrice = double.Parse(Console.ReadLine());
            var toysSellPrice = double.Parse(Console.ReadLine());

            var counterOddYears = 0;
            var counterEvenYears = 0;
            var moneyPresent = 0;
            for (int i = 1; i <= lilyAge; i++)
            {
                if (i % 2 == 0)
                {
                    counterEvenYears++;
                    moneyPresent += counterEvenYears * 10;
                }
                else if (i % 2 == 1)
                {
                    counterOddYears++;
                }
            }

            var moneySaved = moneyPresent - counterEvenYears;
            var moneyFromToys = counterOddYears * toysSellPrice;
            var totalSavedMoney = moneyFromToys + moneySaved;

            if (totalSavedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {Math.Abs(totalSavedMoney - washingMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(totalSavedMoney - washingMachinePrice):f2}");
            }            
        }
    }
}
