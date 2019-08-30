using System;

namespace LabAreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine();

            var resultArea = 0.0;

            if (figureType == "square")
            {
                var side = double.Parse(Console.ReadLine());
                resultArea = side * side;
            }
            else if (figureType == "rectangle")
            {
                var h = double.Parse(Console.ReadLine());
                var l = double.Parse(Console.ReadLine());
                resultArea = h * l;
            }
            else if (figureType == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                resultArea = Math.PI * radius * radius;
            }
            else if (figureType == "triangle")
            {
                var h = double.Parse(Console.ReadLine());
                var l = double.Parse(Console.ReadLine());
                resultArea = (l / 2) * h;
            }
            Console.WriteLine($"{resultArea:f3}");
        }
    }
}
