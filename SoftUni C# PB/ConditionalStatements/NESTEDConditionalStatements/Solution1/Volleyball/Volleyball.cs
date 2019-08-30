using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var weekendsInHomeTown = int.Parse(Console.ReadLine());

            var weekendsInSofia = 48 - weekendsInHomeTown;
            var notWorkingWeekends = weekendsInSofia * (3.0 / 4);
            var playingHolidays = holidays * (2.0 / 3);

            var totalGames = notWorkingWeekends + playingHolidays + weekendsInHomeTown;

            if (year == "leap")
            {
                totalGames *= 1.15;
            }
            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}
