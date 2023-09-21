// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace CollectionsQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNumbers = new ArrayList();
            ArrayList otherNumbers = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number) && number > 0)
                {
                    if (IsPrime(number))
                    {
                    primeNumbers.Add(number);
                    }
                    else
                    otherNumbers.Add(number);
                    }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    i--; // to repeat current iteration
                }
                
            }

            Console.WriteLine("Prime numbers and their count: " + primeNumbers.Count);// count sıkıntılı
            foreach (var item in primeNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nOther numbers and their count: " + otherNumbers.Count);
            foreach (var item in otherNumbers)
            {
                Console.WriteLine(item);
            }
            
            primeNumbers.Sort();
            primeNumbers.Reverse();
            otherNumbers.Sort();
            otherNumbers.Reverse();

            Console.WriteLine("Prime Numbers In Descending Order:");    
            foreach (var item in primeNumbers)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("Other Numbers In Descending Order:");   
            foreach (var item in otherNumbers)
            {
                Console.WriteLine(item);
            } 
            
            int totalP = 0;
            int totalO = 0;
            foreach (var item in primeNumbers)
            {
                totalP += (int)item;
            }
            
            Console.Write("Prime Average: " +totalP/primeNumbers.Count);
            
            foreach (var item in otherNumbers)
            {
                totalO += (int)item;
            }
            
            Console.Write("\nOther Numbers Average: " +totalO/otherNumbers.Count);


        }

        static bool IsPrime(int number)
        {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
        }
    }
}