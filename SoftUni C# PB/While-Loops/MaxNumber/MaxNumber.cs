using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var maxNumber = int.MinValue;
            while (n > 0)
            {
                var currNum = int.Parse(Console.ReadLine());
                if (currNum > maxNumber)
                {
                    maxNumber = currNum;
                }
                n--;
            }
            Console.WriteLine(maxNumber);
        }
    }
}
