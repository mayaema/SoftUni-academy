using System;

namespace CirclePerimeterAndFace
{
    class CirclePerimeterAndFace
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * radius * radius;
            var perimeter = 2 * Math.PI * radius;

            Console.WriteLine("{0:f2}", area);
            Console.WriteLine("{0:f2}", perimeter);
        }
    }
}
