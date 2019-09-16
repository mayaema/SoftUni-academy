using System;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sumLeft = 0;
            var sumRight = 0;

            for (int i = 0; i < n * 2; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (i >= n)
                {
                    sumRight += number;
                }
                else if (i < n)
                {
                    sumLeft += number;
                }
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }
        }
    }
}
