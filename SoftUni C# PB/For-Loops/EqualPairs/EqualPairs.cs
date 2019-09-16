using System;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var currsumOfTwo = 0;
            var prevSum = 0;
            var maxDiff = 0;
            var currDiff = 0;

            for (int i = 0; i < n; i++)
            {
                var firstNumber = int.Parse(Console.ReadLine());
                var secondNumber = int.Parse(Console.ReadLine());
                
                currsumOfTwo = firstNumber + secondNumber;
                maxDiff = currsumOfTwo - prevSum;

                prevSum = currsumOfTwo;
            }
            if (n == 1)
            {                
                Console.WriteLine($"Yes, value={currsumOfTwo}");
            }
            else if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={currsumOfTwo}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(maxDiff)}");
            }
        }
    }
}
