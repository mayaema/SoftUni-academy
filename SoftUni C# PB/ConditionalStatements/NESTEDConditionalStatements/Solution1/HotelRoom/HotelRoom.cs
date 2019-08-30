using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var daysOfStay = int.Parse(Console.ReadLine());
            var studioPrice = 0.0;
            var apartmentPrice = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50.0;
                apartmentPrice = 65.0;
                if (daysOfStay > 14)
                {
                    studioPrice *= 0.70;                    
                }
                else if (daysOfStay > 7)
                {
                    studioPrice *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.2;
                apartmentPrice = 68.7;
                if (daysOfStay > 14)
                {
                    studioPrice *= 0.8;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76.0;
                apartmentPrice = 77.0;
            }
            if (daysOfStay > 14)
            {
                apartmentPrice *= 0.9;
            }
            var totalForStudio = studioPrice * daysOfStay;
            var totalForApartment = apartmentPrice * daysOfStay;

            Console.WriteLine($"Apartment: {totalForApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalForStudio:f2} lv.");
        }
    }
}
