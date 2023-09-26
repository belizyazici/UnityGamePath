// See https://aka.ms/new-console-template for more information
using System;

namespace Enum_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar); //Output: Pazar
            Console.WriteLine((int)Gunler.Cumartesi); //Output: 6

            int sicaklik = 32;

            if (sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            else if (sicaklik >= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSıcak)
                Console.WriteLine("Hadi dışarıya çıkalım.");
                   
        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30
    }
}