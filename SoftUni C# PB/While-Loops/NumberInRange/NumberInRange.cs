using System;

namespace NumberInRange
{
    class NumberInRange
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var number = int.Parse(Console.ReadLine());
                var inRange = number >= 1 && number <= 100;
                if (inRange)
                {
                    Console.WriteLine($"The number is: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
