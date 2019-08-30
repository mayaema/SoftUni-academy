using System;

namespace LabExcellentResult
{
    class ExcellentResult
    {
        static void Main(string[] args)
        {
            var score = double.Parse(Console.ReadLine());

            if (score >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
