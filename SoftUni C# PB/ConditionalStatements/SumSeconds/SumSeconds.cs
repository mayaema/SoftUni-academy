using System;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            var secondsFirstContestant = int.Parse(Console.ReadLine());
            var secondsSecondContestant = int.Parse(Console.ReadLine());
            var secondsTirdContestant = int.Parse(Console.ReadLine());

            var totalSeconds = secondsFirstContestant + secondsSecondContestant + secondsTirdContestant;
            var min = totalSeconds / 60;
            var sec = totalSeconds % 60;

            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
