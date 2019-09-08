using System;

namespace Graduation
{
    class Graduation
    {
        static void Main(string[] args)
        {
            var studentName = Console.ReadLine();
            var totalGrades = 12;
            var averageScore = 0.0;
            while (totalGrades > 0)
            {
                var grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    averageScore += grade;
                    totalGrades--;
                }
            }
            Console.WriteLine($"{studentName} graduated. Average grade: {(averageScore / 12.0):F2}");
        }
    }
}
