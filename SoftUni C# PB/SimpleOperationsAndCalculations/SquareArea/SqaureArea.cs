using System;

namespace SquareArea
{
    class SqaureArea
    {
        static void Main(string[] args)
        {
            var squareSide = int.Parse(Console.ReadLine());

            var area = squareSide * squareSide;

            Console.WriteLine(area);
        }
    }
}
