// See https://aka.ms/new-console-template for more information
using System;

namespace CollectionsQuestion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] smallestNumbers = new int[3];
            int[] largestNumbers = new int[3];
            int[] numbers = new int[20].ToArray();


            
            for (int i = 0; i < 20; i++)
            {
                int input = int.Parse(Console.ReadLine());

                numbers[i] = input;
                
            }

            Array.Sort(numbers); //in ascending order
            

            Array.Copy(numbers, 0, smallestNumbers, 0, 3);
            Array.Copy(numbers, 17, largestNumbers, 0, 3);

            Console.WriteLine("Smallest 3 numbers:");
            foreach (var item in smallestNumbers)
            {
                
                Console.WriteLine(item);
            }

            Console.WriteLine("Largest 3 numbers:");
            foreach (var item in largestNumbers)
            {
                Console.WriteLine(item);
            }
            
            

            int totalP = 0;
            int totalO = 0;

            foreach (var item in smallestNumbers)
            {
                totalP += item;
            }

            foreach (var item in largestNumbers)
            {
                totalO += item;
            }

            double smallestAverage = totalP/3;
            double largestAverage = totalO/3;

            Console.WriteLine("Average of Smallest 3 Numbers: " + smallestAverage);
            Console.WriteLine("Average of Largest 3 Numbers: " + largestAverage);
            Console.WriteLine("Total Average: " + (smallestAverage + largestAverage));

            
        }
        
        
    }
}