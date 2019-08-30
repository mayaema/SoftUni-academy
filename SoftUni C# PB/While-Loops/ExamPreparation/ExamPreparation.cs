using System;

namespace ExamPreparation
{
    class ExamPreparation
    {
        static void Main(string[] args)
        {
            var lowGrades = int.Parse(Console.ReadLine());
            var totalCounter = 0;
            var averageGrade = 0.0;
            var lowScoreCount = 0;
            var lastProblem = string.Empty;
            while (lowScoreCount < lowGrades)
            {
                var problem = Console.ReadLine();
                if (problem == "Enough")
                {
                    Console.WriteLine($"Average score: {(averageGrade / totalCounter):F2}");
                    Console.WriteLine($"Number of problems: {totalCounter}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }

                var grade = double.Parse(Console.ReadLine());
                averageGrade += grade;
                
                if (grade <= 4)
                {
                    lowScoreCount++;
                }

                totalCounter++;

                if (lowScoreCount == lowGrades)
                {
                    Console.WriteLine($"You need a break, {lowScoreCount} poor grades.");
                    break;
                }

                lastProblem = problem;
            }
        }
    }
}
