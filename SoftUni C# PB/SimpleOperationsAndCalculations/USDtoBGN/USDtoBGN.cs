using System;

namespace USDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            var fixedCourse = 1.79549;

            var usdToBgn = usd * fixedCourse;
            //Console.WriteLine($"{usdToBgn:f2}");
            Console.WriteLine(Math.Round(usdToBgn, 2));
        }
    }
}
