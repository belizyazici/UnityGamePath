// See https://aka.ms/new-console-template for more information
using System;

namespace CollectionsQuestion3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();

            char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            // Create a list to store vowels
            var vowelList = new System.Collections.Generic.List<char>();

            foreach (char c in input)
            {
                if (Array.Exists(vowels, v => v == char.ToLower(c)))
                {
                    vowelList.Add(c);
                }
            }

            // Convert the list to an array
            char[] vowelArray = vowelList.ToArray();

            Console.WriteLine("Vowels in the sentence: " + string.Join(", ", vowelArray));
        }
    }
}
