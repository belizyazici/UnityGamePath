// See https://aka.ms/new-console-template for more information
using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            

            bool sonuc = int.TryParse(sayi, out int outSayi);//TryParse boolean döndürür
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız");

            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Method Overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Beliz", "Yazıcı");

            //metot imzası
            //metot adı + parametre sayısı + parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam) //out return gibi de kullanılabilir
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
 
    }
}