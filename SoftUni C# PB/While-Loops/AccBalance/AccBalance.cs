using System;

namespace AccBalance
{
    class AccBalance
    {
        static void Main(string[] args)
        {
            var numberOfIns = int.Parse(Console.ReadLine());

            var totalBalance = 0.0;
            while (numberOfIns > 0)
            {
                var accIns = double.Parse(Console.ReadLine());
                totalBalance += accIns;

                if (accIns < 0)
                {
                    totalBalance -= accIns;
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {accIns:F2}");
                numberOfIns--;
            }
            Console.WriteLine($"Total: {totalBalance:F2}");
        }
    }
}
