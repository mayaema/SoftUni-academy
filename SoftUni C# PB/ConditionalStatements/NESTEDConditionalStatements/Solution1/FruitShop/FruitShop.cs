using System;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            var price = 0.0;
            var error = false;
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || 
                dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                if (fruit == "banana") price = 2.5;
                else if (fruit == "apple") price = 1.2;
                else if (fruit == "orange") price = 0.85;
                else if (fruit == "grapefruit") price = 1.45;
                else if (fruit == "kiwi") price = 2.7;
                else if (fruit == "pineapple") price = 5.5;
                else if (fruit == "grapes") price = 3.85;
                else
                {
                    error = true;
                }

            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (fruit == "banana") price = 2.7;
                else if (fruit == "apple") price = 1.25;
                else if (fruit == "orange") price = 0.9;
                else if (fruit == "grapefruit") price = 1.6;
                else if (fruit == "kiwi") price = 3.0;
                else if (fruit == "pineapple") price = 5.6;
                else if (fruit == "grapes") price = 4.2;
                else
                {
                    error = true;
                }
            }
            else
            {
                error = true;
            }

            var totalPrice = quantity * price;
            if (!error)
            {
                Console.WriteLine($"{totalPrice:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
