// See https://aka.ms/new-console-template for more information
using System;

namespace AlgorithHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Q - 1****");
            //q-1
            Console.WriteLine("Please enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter {0} number(s): ", n);

            int[] evenArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int n2 = Convert.ToInt32(Console.ReadLine());

                if (n2 % 2 == 0)
                {
                    evenArray[i] = n2;
                }
                  
            }

            Console.WriteLine("Even numbers: ");
            foreach (var number in evenArray)
            {
                if (number != 0)
                {
                    Console.Write(number+ " ");
                }
            }

            
            Console.WriteLine("\n****Q - 2****");
            //q-2
            Console.WriteLine("Please enter a positive number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            

            while (n1 <= 0)
            {
                Console.WriteLine("Please enter a positive number: ");
                n1 = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Please enter one more positive number: ");
            int m = Convert.ToInt32(Console.ReadLine());

            while (m <= 0)
            {
                Console.WriteLine("Please enter a positive number: ");
                m = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please enter {0} number(s): ", n1);

            int[] numbers = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                int n3 = Convert.ToInt32(Console.ReadLine());

                if (n3 == m || n3 % m == 0)
                {
                    numbers[i] = n3;
                }
                  
            }

            foreach (var number in numbers)
            {
                if (number != 0)
                {
                    Console.Write(number+ " ");
                }
            }
            
            
            Console.WriteLine("\n****Q - 3****");
            //q-3
            Console.WriteLine("Please enter a positive number: ");
            int n4 = Convert.ToInt32(Console.ReadLine());

            while (n4 <= 0)
            {
                Console.WriteLine("Please enter a positive number: ");
                n4 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please enter {0} word(s): ", n4);

            string[] words = new string[n4];

            for (int i = 0; i < n4; i++)
            {
                string word = Console.ReadLine();
                words[i] = word;

                  
            }
            
            Console.WriteLine("Sorted words:");

            for (int i = n4-1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
            
            
            Console.WriteLine("\n****Q - 4****");
            //q-4
            Console.WriteLine("Write a sentence: ");
            string sentence = Console.ReadLine();

            string[] words1 = sentence.Split(' ');

            int wordCount = words1.Length;
            Console.WriteLine("Word count: " + wordCount);   

            int letterCount = 0;

            foreach (char letter in sentence)
            {
                if(char.IsLetter(letter))
                    letterCount++;
            }   
            Console.WriteLine("Letter count: " + letterCount); 
            
        }
        
    }
}
