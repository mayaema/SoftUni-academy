﻿using System;

namespace LabGraterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                Console.WriteLine(firstNum);
            }
            else
            {
                Console.WriteLine(secondNum);
            }
        }
    }
}
