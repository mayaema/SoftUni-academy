using System;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            var maxSeats = rows * cols;
            var result = 0.0;

            if (type == "Premiere")
            {
                result = maxSeats * 12.00;
            }
            else if (type == "Normal")
            {
                result = maxSeats * 7.50;
            }
            else
            {
                result = maxSeats * 5.00;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
