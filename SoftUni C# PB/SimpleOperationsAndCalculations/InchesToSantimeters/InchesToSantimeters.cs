using System;

namespace InchesToSantimeters
{
    class InchesToSantimeters
    {
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());

            var convertToSantimeters = inches * 2.54;

            Console.WriteLine($"{convertToSantimeters:f2}");
        }
    }
}
