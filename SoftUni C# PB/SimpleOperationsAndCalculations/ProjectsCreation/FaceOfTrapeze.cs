using System;

namespace ProjectsCreation
{
    class FaceOfTrapeze
    {
        static void Main(string[] args)
        {
            var side1 = double.Parse(Console.ReadLine());
            var side2 = double.Parse(Console.ReadLine());
            var hight = double.Parse(Console.ReadLine());

            var face = (side1 + side2) * (hight / 2);

            Console.WriteLine("{0:f2}", face);
        }
    }
}
