using System;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var counterP1 = 0;
            var counterP2 = 0;
            var counterP3 = 0;
            var counterP4 = 0;
            var counterP5 = 0;


            for (int i = 0; i < n; i++)
            {
                var number = double.Parse(Console.ReadLine());

                var p1 = number < 200;
                var p2 = 200 <= number && number < 400;
                var p3 = 400 <= number && number < 600;
                var p4 = 600 <= number && number < 800;
                var p5 = 800 <= number;

                if (p1)
                {
                    counterP1++;
                }
                else if (p2)
                {
                    counterP2++;
                }
                else if (p3)
                {
                    counterP3++;
                }
                else if (p4)
                {
                    counterP4++;
                }
                else if (p5)
                {
                    counterP5++;
                }
            }
            Console.WriteLine($"{(counterP1 / n * 100):f2}%");
            Console.WriteLine($"{(counterP2 / n * 100):f2}%");
            Console.WriteLine($"{(counterP3 / n * 100):f2}%");
            Console.WriteLine($"{(counterP4 / n * 100):f2}%");
            Console.WriteLine($"{(counterP5 / n * 100):f2}%");
        }
    }
}
