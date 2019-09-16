using System;

namespace VowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var sumVowels = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    sumVowels += 1;
                }
                else if (text[i] == 'e')
                {
                    sumVowels += 2;
                }
                else if (text[i] == 'i')
                {
                    sumVowels += 3;
                }
                else if (text[i] == 'o')
                {
                    sumVowels += 4;
                }
                else if (text[i] == 'u')
                {
                    sumVowels += 5;
                }
            }
            Console.WriteLine(sumVowels);
        }
    }
}
