using System;

namespace LabPassGuess
{
    class PasswordGuess
    {
        static void Main(string[] args)
        {
            //s3cr3t!P@ssw0rd
            var word = Console.ReadLine();

            if (word == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
