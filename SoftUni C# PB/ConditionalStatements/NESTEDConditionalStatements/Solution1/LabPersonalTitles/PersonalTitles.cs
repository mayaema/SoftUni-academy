using System;

namespace LabPersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gendre = Console.ReadLine();

            if (age >= 16)
            {
                if (gendre == "f")
                {
                    Console.WriteLine("Ms.");
                }
                else if (gendre == "m")
                {
                    Console.WriteLine("Mr.");
                }
            }
            else if (age < 16)
            {
                if (gendre == "f")
                {
                    Console.WriteLine("Miss");
                }
                else if (gendre == "m")
                {
                    Console.WriteLine("Master");
                }
            }
        }
    }
}
