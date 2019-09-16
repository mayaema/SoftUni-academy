using System;

namespace NumberSequence
{
    class NumberSequence
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var min = int.MaxValue;
            var max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
