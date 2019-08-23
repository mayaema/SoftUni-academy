using System;

namespace PetShop
{
    class FishTank
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var hight = double.Parse(Console.ReadLine());
            var percentWaste = double.Parse(Console.ReadLine());

            var area = length * width * hight;
            var litersInside = area * 0.001;
            var percentInLeters = percentWaste * 0.01;

            var total = litersInside * (1 - percentInLeters);

            Console.WriteLine("{0:f3}", total);
        }
    }
}
