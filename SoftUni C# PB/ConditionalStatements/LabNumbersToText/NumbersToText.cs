using System;

namespace LabNumbersToText
{
    class NumbersToText
    {
        static void Main(string[] args)
        {
            var numberInt = int.Parse(Console.ReadLine());

            if (numberInt == 1)
            {
                Console.WriteLine("one");
            }
            else if (numberInt == 2)
            {
                Console.WriteLine("two");
            }
            else if (numberInt == 3)
            {
                Console.WriteLine("three");
            }
            else if (numberInt == 4)
            {
                Console.WriteLine("four");
            }
            else if (numberInt == 5)
            {
                Console.WriteLine("five");
            }
            else if (numberInt == 6)
            {
                Console.WriteLine("six");
            }
            else if (numberInt == 7)
            {
                Console.WriteLine("seven");
            }
            else if (numberInt == 8)
            {
                Console.WriteLine("eight");
            }
            else if (numberInt == 9)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
