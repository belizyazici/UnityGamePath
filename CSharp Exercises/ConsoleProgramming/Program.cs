// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("İsminizi giriniz:");
           string name = Console.ReadLine();

           Console.WriteLine("Soyadınızı giriniz:");
           string lastName = Console.ReadLine();

           Console.WriteLine("Merhaba " + name + " " + lastName);
        }
    }
    
}


