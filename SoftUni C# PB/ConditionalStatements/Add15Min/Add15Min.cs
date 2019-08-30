using System;

namespace Add15Min
{
    class Add15Min
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            var addMin = 15;

            if ((min + addMin) > 59)
            {
                hours++;
                min -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if ((addMin + min) < 10 )
            {
                Console.WriteLine($"{hours}:0{min + 15}");
            }
            else
            {
                Console.WriteLine($"{hours}:{min + 15}");
            }
        }
    }
}
