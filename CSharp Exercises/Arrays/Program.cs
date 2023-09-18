// See https://aka.ms/new-console-template for more information
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

            int[] dizi;
            dizi = new int[5];

            //dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 10;

            Console.WriteLine(renkler[0]);
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);

            //döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.Write("Dizinin eleman sayısını giriniz:");
            int arLength = int.Parse(Console.ReadLine());
            int[] numArray = new int[arLength];

            for (int i = 0; i < arLength; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
                numArray[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;  
            foreach (var number in numArray)
            {
                toplam += number;
            }

            Console.WriteLine("Ortalama: " + toplam/arLength);
        }
    }
}