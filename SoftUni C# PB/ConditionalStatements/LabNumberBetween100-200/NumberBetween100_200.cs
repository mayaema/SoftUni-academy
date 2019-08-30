using System;

namespace LabNumberBetween100_200
{
    class NumberBetween100_200
    {
        static void Main(string[] args)
        {
            var numberToCheck = int.Parse(Console.ReadLine());

            if (numberToCheck < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (numberToCheck >= 100 && numberToCheck <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (numberToCheck > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
