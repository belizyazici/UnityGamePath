// See https://aka.ms/new-console-template for more information
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);//referans: a ve b nin değerlerini vermek yerine bellekteki yerlerini işaret etmek
            //böylece kopyaların yerine orijinal değerleri değişmiş oldu
            //ref olarak metoda verilen değişkenin mutlaka bir başlangıç değeri olmak zorundadır
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));
        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}