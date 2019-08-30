using System;

namespace LabInvalidNumber
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (!(number == 0 || (number >= 100 && number <= 200)))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
