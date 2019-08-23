using System;

namespace RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var CalcArea = a * b;
            Console.WriteLine(CalcArea);
        }
    }
}
