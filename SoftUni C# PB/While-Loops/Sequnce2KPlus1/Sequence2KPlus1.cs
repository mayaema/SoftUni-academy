using System;

namespace Sequnce2KPlus1
{
    class Sequence2KPlus1
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var currNum = 1;

            while (currNum <= number)
            {
                Console.WriteLine(currNum);
                currNum = currNum * 2 + 1;
            }
        }
    }
}
