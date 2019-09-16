using System;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var evenSum = 0.0;
            var evenMax = double.MinValue;
            var evenMin = double.MaxValue;

            

            for (int i = 1; i <= n; i++)
            {
                var currNum = double.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    oddSum += currNum;
                    if (currNum > oddMax)
                    {
                        oddMax = currNum;
                    }
                    if (currNum < oddMin)
                    {
                        oddMin = currNum;
                    }
                }
                else if (i % 2 == 0)
                {
                    evenSum += currNum;
                    if (currNum > evenMax)
                    {
                        evenMax = currNum;
                    }
                    if (currNum < evenMin)
                    {
                        evenMin = currNum;
                    }
                }                
            }            
            //OddSum=-5.00,OddMin = -5.00,OddMax = -5.00,EvenSum = 0.00,EvenMin = No,EvenMax = No
            if (n == 0)
            {
                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (n == 1)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
