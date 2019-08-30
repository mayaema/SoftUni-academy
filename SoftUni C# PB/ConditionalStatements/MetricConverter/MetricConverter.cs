using System;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var inputMetric = Console.ReadLine();
            var outputMetric = Console.ReadLine();

            if (inputMetric == "mm")
            {
                value /= 1000;
            }
            else if (inputMetric == "cm")
            {
                value /= 100;
            }
            if (outputMetric == "mm")
            {
                value *= 1000;
            }
            else if (outputMetric == "cm")
            {
                value *= 100;
            }
            Console.WriteLine($"{value:f3}");
        }
    }
}
