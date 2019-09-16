using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var maxNumber = int.MinValue;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var currNumber = int.Parse(Console.ReadLine());
                sum += currNumber;
                if (currNumber > maxNumber)
                {
                    maxNumber = currNumber;
                }
            }
            sum -= maxNumber;
            if (maxNumber == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - sum)}");
            }
        }
    }
}
