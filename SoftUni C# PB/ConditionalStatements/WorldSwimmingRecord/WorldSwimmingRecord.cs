using System;

namespace WorldSwimmingRecord
{
    class WorldSwimmingRecord
    {
        static void Main(string[] args)
        {
            var currentRecordInSec = double.Parse(Console.ReadLine());
            var distanceInMeters = double.Parse(Console.ReadLine());
            var timeForOneMeterInSec = double.Parse(Console.ReadLine());

            var waterRessistance = Math.Floor(distanceInMeters / 15) * 12.5;

            var ivansTime = distanceInMeters * timeForOneMeterInSec + waterRessistance;

            if (currentRecordInSec > ivansTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(ivansTime - currentRecordInSec):F2} seconds slower.");
            }
        }
    }
}
