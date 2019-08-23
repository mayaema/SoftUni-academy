using System;

namespace DanceHall
{
    class DanceHall
    {
        static void Main(string[] args)
        {
            var hallLentghInMeters = double.Parse(Console.ReadLine());
            var hallWidthInMeters = double.Parse(Console.ReadLine());
            var wardrobeSide = double.Parse(Console.ReadLine());

            var hallAreaInSentiM = (hallLentghInMeters * 100) * (hallWidthInMeters * 100);
            var wardrobeAreaInSentiM = (wardrobeSide * 100) * (wardrobeSide * 100);
            var benchArea = hallAreaInSentiM / 10;

            var freeSpaceForDancers = hallAreaInSentiM - wardrobeAreaInSentiM - benchArea;

            var totalDancers = freeSpaceForDancers / (40 + 7000);

            Console.WriteLine(Math.Floor(totalDancers));
        }
    }
}
