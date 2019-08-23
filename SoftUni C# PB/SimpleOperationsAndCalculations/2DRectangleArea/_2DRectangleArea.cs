using System;

namespace _2DRectangleArea
{
    class _2DRectangleArea
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var length = Math.Abs(x1 - x2);
            var width = Math.Abs(y1 - y2);

            var area = length * width;
            var perimeter = 2 * (length + width);

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");
        }
    }
}
