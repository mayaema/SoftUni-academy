using System;

namespace Salary
{
    class Salary
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var currentSalary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var openTags = Console.ReadLine();

                if (openTags == "Facebook")
                {
                    currentSalary -= 150;
                }
                else if (openTags == "Instagram")
                {
                    currentSalary -= 100;
                }
                else if (openTags == "Reddit")
                {
                    currentSalary -= 50;
                }
                if (currentSalary <= 0)
                {
                    break;
                }
            }
            if (currentSalary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{currentSalary}");
            }
        }
    }
}
