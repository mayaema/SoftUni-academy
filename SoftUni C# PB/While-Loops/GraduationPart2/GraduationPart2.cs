using System;

namespace GraduationPart2
{
    class GraduationPart2
    {
        static void Main(string[] args)
        {
            var studentName = Console.ReadLine();
            var counter = 1;
            var averageScore = 0.0;
            var badScores = 0;
            var isGraduated = true;
            while (counter <= 12)
            {
                var grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    averageScore += grade;
                    counter++;
                }
                else
                {
                    badScores++;
                    if (badScores >= 2)
                    {
                        isGraduated = false;
                        break;
                    }
                }
            }
            if (isGraduated)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {(averageScore / 12.0):F2}");
            }
            else
            {
                Console.WriteLine($"{studentName} has been excluded at {counter} grade");
            }
        }
    }
}
