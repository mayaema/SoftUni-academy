using System;

namespace OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            var examTimeHour = int.Parse(Console.ReadLine());
            var examTimeMinute = int.Parse(Console.ReadLine());
            var arrivalTimeHour = int.Parse(Console.ReadLine());
            var arrivalTimeMinute = int.Parse(Console.ReadLine());

            var examTimeInMinutes = (examTimeHour * 60) + examTimeMinute;
            var arrivalTimeInMinutes = (arrivalTimeHour * 60) + arrivalTimeMinute;

            if (examTimeInMinutes == arrivalTimeInMinutes)
            {
                Console.WriteLine("On time");
            }
            else if (examTimeInMinutes < arrivalTimeInMinutes)
            {
                var lateTime = arrivalTimeInMinutes - examTimeInMinutes;
                if (lateTime >= 60)
                {
                    var lateHours = lateTime / 60;
                    var lateMin = lateTime % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{lateHours}:{lateMin:00} hours after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{lateTime} minutes after the start");
                }
            }
            else if (examTimeInMinutes > arrivalTimeInMinutes)
            {
                var earlyTime = examTimeInMinutes - arrivalTimeInMinutes;
                if (earlyTime > 30 && earlyTime < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{earlyTime:00} minutes before the start");
                }
                else if (earlyTime > 59)
                {
                    var earlyHours = earlyTime / 60;
                    var earlyMin = earlyTime % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{earlyHours}:{earlyMin:00} hours before the start");
                }
                else if (earlyTime <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{earlyTime} minutes before the start");
                }
            }
        }
    }
}
