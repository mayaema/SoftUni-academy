using System;

namespace NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            var typeOfFlowers = Console.ReadLine();
            var flowersCount = int.Parse(Console.ReadLine());
            var budget = int.Parse(Console.ReadLine());
            var price = 0.0;
            var totalPrice = 0.0;

            if (typeOfFlowers == "Roses")
            {
                price = 5.00;
                if (flowersCount > 80)
                {
                    price *= 0.90;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                price = 3.80;
                if (flowersCount > 90)
                {
                    price *= 0.85;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                price = 2.8;
                if (flowersCount > 80)
                {
                    price *= 0.85;

                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                price = 3.0;
                if (flowersCount < 120)
                {
                    price *= 1.15;
                }
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                price = 2.5;
                if (flowersCount < 80)
                {
                    price *= 1.20;

                }
            }
            totalPrice = price * flowersCount;
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount}" +
                                  $" {typeOfFlowers} and {(budget - totalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalPrice - budget):f2} leva more.");
            }
        }
    }
}
