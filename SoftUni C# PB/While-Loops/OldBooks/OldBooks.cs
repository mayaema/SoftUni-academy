using System;

namespace OldBooks
{
    class OldBooks
    {
        static void Main(string[] args)
        {
            var searchedBook = Console.ReadLine();
            var BookStoreCapacity = int.Parse(Console.ReadLine());

            var bookFounded = true;
            var counter = 0;

            while (bookFounded)
            {
                var checkBook = Console.ReadLine();
                if (checkBook == searchedBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    bookFounded = true;
                    break;
                }
                counter++;

                if (counter == BookStoreCapacity)
                {
                    bookFounded = false;
                    break;
                }
            }
            if (!bookFounded)
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }            
        }
    }
}
