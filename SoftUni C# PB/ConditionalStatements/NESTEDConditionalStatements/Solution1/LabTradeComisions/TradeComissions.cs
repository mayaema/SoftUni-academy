using System;

namespace LabTradeComisions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());
            var comission = 0.0;

            var error = false;
            if (0 <= sales && sales <= 500 )
            {
                if (city == "Sofia")
                {
                    comission = sales * 0.05;
                }
                else if (city == "Varna")
                {
                    comission = sales * 0.045;
                }
                else if (city == "Plovdiv")
                {
                    comission = sales * 0.055;
                }
                else
                {
                    error = true;
                }
            }
            else if (500 < sales && sales <= 1000)
            {
                if (city == "Sofia")
                {
                    comission = sales * 0.07;
                }
                else if (city == "Varna")
                {
                    comission = sales * 0.075;
                }
                else if (city == "Plovdiv")
                {
                    comission = sales * 0.08;
                }
                else
                {
                    error = true;
                }
            }
            else if (1000 < sales && sales <= 10000)
            {
                if (city == "Sofia")
                {
                    comission = sales * 0.08;
                }
                else if (city == "Varna")
                {
                    comission = sales * 0.10;
                }
                else if (city == "Plovdiv")
                {
                    comission = sales * 0.12;
                }
                else
                {
                    error = true;
                }
            }
            else if (sales > 10000)
            {
                if (city == "Sofia")
                {
                    comission = sales * 0.12;
                }
                else if (city == "Varna")
                {
                    comission = sales * 0.13;
                }
                else if (city == "Plovdiv")
                {
                    comission = sales * 0.145;
                }
                else
                {
                    error = true;
                }
            }
            else
            {
                error = true;
            }
            if (error)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{comission:f2}");
            }
        }
    }
}
