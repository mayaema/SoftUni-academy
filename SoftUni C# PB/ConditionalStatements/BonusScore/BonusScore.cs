using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            var score = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (score <= 100)
            {
                bonus += 5;
            }
            else if (score > 100 && score <= 1000)
            {
                bonus = score * 0.20;
            }
            else
            {
                bonus = score * 0.10;
            }
            if (score % 2 == 0)
            {
                bonus += 1;
            }
            if (score % 10 == 5)
            {
                bonus += 2;
            }

            var bonusScore = score + bonus;

            Console.WriteLine(bonus);
            Console.WriteLine(bonusScore);
        }
    }
}
