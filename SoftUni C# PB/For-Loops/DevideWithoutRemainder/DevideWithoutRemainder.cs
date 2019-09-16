using System;

namespace DevideWithoutRemainder
{
    class DevideWithoutRemainder
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var noRemainderFor4Counter = 0;
            var noRemainderFor2Counter = 0;
            var noRemainderFor3Counter = 0;
            for (int i = 0; i < n; i++)
            {
                var number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    noRemainderFor2Counter++;
                }
                if (number % 3 == 0)
                {
                    noRemainderFor3Counter++;
                }
                if (number % 4 == 0)
                {
                    noRemainderFor4Counter++;
                }
            }
            Console.WriteLine($"{(noRemainderFor2Counter / n * 100):f2}%");
            Console.WriteLine($"{(noRemainderFor3Counter / n * 100):f2}%");
            Console.WriteLine($"{(noRemainderFor4Counter / n * 100):f2}%");
        }
    }
}
