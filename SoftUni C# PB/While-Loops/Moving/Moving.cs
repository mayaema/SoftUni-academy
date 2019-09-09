using System;

namespace Moving
{
    class Moving
    {
        static void Main(string[] args)
        {
            var roomWidth = int.Parse(Console.ReadLine());
            var roomLength = int.Parse(Console.ReadLine());
            var roomHight = int.Parse(Console.ReadLine());
            var roomFreeSpace = roomHight * roomLength * roomWidth;
            var done = true;
            var spaceNeeded = 0;
            var boxes = 0;
            while (done)
            {
                var command = Console.ReadLine();
                if (command == "Done")
                {
                    done = false;
                    Console.WriteLine($"{roomFreeSpace} Cubic meters left.");
                    break;
                }
                roomFreeSpace -= int.Parse(command);
                if (roomFreeSpace < 0)
                {
                    spaceNeeded = roomFreeSpace * -1;
                    Console.WriteLine($"No more free space! You need {spaceNeeded} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
