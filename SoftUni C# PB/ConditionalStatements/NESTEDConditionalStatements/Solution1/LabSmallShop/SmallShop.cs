using System;

namespace LabSmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            var price = 0.0;

            switch (product)
            {
                case "coffee":
                    if (city == "Sofia")
                    {
                        price = quantity * 0.5;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = quantity * 0.4;
                    }
                    else
                    {
                        price = quantity * 0.45;
                    }
                    break;
                case "water":
                    if (city == "Sofia")
                    {
                        price = quantity * 0.8;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = quantity * 0.7;
                    }
                    else
                    {
                        price = quantity * 0.7;
                    }
                    break;
                case "beer":
                    if (city == "Sofia")
                    {
                        price = quantity * 1.2;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = quantity * 1.15;
                    }
                    else
                    {
                        price = quantity * 1.1;
                    }
                    break;
                case "sweets":
                    if (city == "Sofia")
                    {
                        price = quantity * 1.45;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = quantity * 1.3;
                    }
                    else
                    {
                        price = quantity * 1.35;
                    }
                    break;
                case"peanuts":
                    if (city == "Sofia")
                    {
                        price = quantity * 1.6;
                    }
                    else if (city == "Plovdiv")
                    {
                        price = quantity * 1.5;
                    }
                    else
                    {
                        price = quantity * 1.55;
                    }
                    break;
            }
            Console.WriteLine(price);
        }
    }
}
