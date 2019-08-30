using System;

namespace Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            var cakeLentgh = int.Parse(Console.ReadLine());
            var cakeHeight = int.Parse(Console.ReadLine());

            var totalPieces = cakeHeight * cakeLentgh;
            var piecesLeft = totalPieces;
            while (piecesLeft > 0)
            {
                var command = Console.ReadLine();
                if (command == "STOP")
                {
                    break;
                }
                piecesLeft -= int.Parse(command);
            }
            if (piecesLeft > 0)
            {
                Console.WriteLine($"{piecesLeft} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(piecesLeft)} pieces more.");
            }
        }
    }
}
