// See https://aka.ms/new-console-template for more information
using System;

namespace WhileForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp yazdır
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1 ;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine(toplam/sayi); 

            //a dan z ye kadar tüm harfleri yazdır
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }
               
            string[] cars = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }   
        }
    }
}