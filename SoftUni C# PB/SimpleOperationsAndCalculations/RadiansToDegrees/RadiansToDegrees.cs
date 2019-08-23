using System;

namespace RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());
            var degrees = Math.Round(radians * 180 / Math.PI);

            Console.WriteLine(degrees);
        }
    }
}
