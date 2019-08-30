using System;

namespace LabSkiTrip
{
    class SkiTrip
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var typeOfRoom = Console.ReadLine();
            var gradeOfTheStay = Console.ReadLine();

            var nightsOfStay = days - 1;

            var roomForOnePersonPrice = 18.0 * nightsOfStay;
            var apartmentPrice = 25.0 * nightsOfStay;
            var presidentApartmenPrice = 35.0 * nightsOfStay;
            var totalPrice = 0.0;
            var discount = 0.0;

            if (days < 10)
            {
                if (typeOfRoom == "apartment")
                {
                   totalPrice = apartmentPrice * 0.70;
                }
                else if (typeOfRoom == "president apartment")
                {
                    totalPrice = presidentApartmenPrice * 0.90;
                }
            }
            else if (10 <= days && days <= 15)
            {
                if (typeOfRoom == "apartment")
                {
                    totalPrice = apartmentPrice * 0.65;
                }
                else if (typeOfRoom == "president apartment")
                {
                    totalPrice = presidentApartmenPrice * 0.85;
                }
            }
            else if (days > 15)
            {
                if (typeOfRoom == "apartment")
                {
                    totalPrice = apartmentPrice * 0.50;
                }
                else if (typeOfRoom == "president apartment")
                {
                    totalPrice = presidentApartmenPrice * 0.80;
                }
            }
            if (gradeOfTheStay == "positive")
            {
                totalPrice *= 1.25;
                roomForOnePersonPrice *= 1.25;
            }
            else if (gradeOfTheStay == "negative")
            {
                totalPrice *= 0.9;
                roomForOnePersonPrice *= 0.9;

            }
            if (typeOfRoom == "room for one person")
            {
                Console.WriteLine($"{roomForOnePersonPrice:F2}");
            }
            else
            {
                Console.WriteLine($"{totalPrice:F2}");
            }
        }
    }
}
