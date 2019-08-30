using System;

namespace OperationsBetweenNumbers
{
    class OperationsBetweenNumbers
    {
        static void Main(string[] args)
        {
            var leftNumber = int.Parse(Console.ReadLine());
            var rightNumber = int.Parse(Console.ReadLine());
            var operatorr = Console.ReadLine();

            var result = 0.0;

            if (operatorr == "+")
            {
                result = leftNumber + rightNumber;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{leftNumber} {operatorr} {rightNumber} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{leftNumber} {operatorr} {rightNumber} = {result} - odd");
                }
            }
            else if (operatorr == "-")
            {
                result = leftNumber - rightNumber;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{leftNumber} {operatorr} {rightNumber} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{leftNumber} {operatorr} {rightNumber} = {result} - odd");
                }
            }
            else if (operatorr == "*")
            {
                result = leftNumber * rightNumber;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{leftNumber} {operatorr} {rightNumber} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{leftNumber} {operatorr} {rightNumber} = {result} - odd");
                }
            }
            else if (operatorr == "/")
            {
                if (rightNumber == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", leftNumber);
                }
                else
                {
                    result = (double)leftNumber / (double)rightNumber;
                    Console.WriteLine($"{leftNumber} {operatorr} {rightNumber} = {result:f2}");
                }               
            }
            else if (operatorr == "%")
            {
                if (rightNumber == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", leftNumber);
                }
                else
                {
                    result = leftNumber % rightNumber;
                    Console.WriteLine($"{leftNumber} {operatorr} {rightNumber} = {result}");
                }              
            }
        }
    }
}
