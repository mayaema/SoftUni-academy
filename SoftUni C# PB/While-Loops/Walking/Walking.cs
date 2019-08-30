using System;

namespace Walking
{
    class Walking
    {
        static void Main(string[] args)
        {
            var goal = 10000;
            var totalSteps = 0;

            while (totalSteps < goal)
            {
                var stepsTakenString = Console.ReadLine();
                if (stepsTakenString == "Going home")
                {
                    stepsTakenString = Console.ReadLine();
                    totalSteps += int.Parse(stepsTakenString);
                    break;
                }
                totalSteps += int.Parse(stepsTakenString);
            }
            if (totalSteps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
            }
        }
    }
}
