// See https://aka.ms/new-console-template for more information
using System;

namespace IfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi günler");
            }
            else
            {
                Console.WriteLine("İyi geceler");
            }

            //ternary if ?: 
            string sonuc = time <= 18 ? "İyi günler" : "İyi geceler";//18den küçükse ilkini yazdır değilse diğerini yazdır

            sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi günler" : "İyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}
