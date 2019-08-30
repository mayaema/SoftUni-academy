using System;

namespace ScholarShip
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            var familyIncome = double.Parse(Console.ReadLine());
            var averageScore = double.Parse(Console.ReadLine());
            var minSalary = double.Parse(Console.ReadLine());

            var socialScholarship = false;
            var highScoreScholarship = false;
            var socialScholarshipMoney = 0.0;
            var highScoreScholarshipMoney = 0.0;

            if (familyIncome < minSalary && averageScore > 4.5)
            {
                socialScholarship = true;
                socialScholarshipMoney = minSalary * 0.35;
            }
            if (averageScore >= 5.5)
            {
                highScoreScholarship = true;
                highScoreScholarshipMoney = averageScore * 25;
            }
            if (!socialScholarship && !highScoreScholarship)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScholarship && !highScoreScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarshipMoney)} BGN");
            }
            else if (highScoreScholarship && !socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(highScoreScholarshipMoney)} BGN");
            }
            else
            {
                if (socialScholarshipMoney > highScoreScholarshipMoney)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarshipMoney)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(highScoreScholarshipMoney)} BGN");
                }
            }        
        }
    }
}
