// See https://aka.ms/new-console-template for more information
using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //static olmayan field lara, metotlara, özelliklere o sınıftan oluşturulan nesne aracılığyla erişilir
            //statik olanlara o sınıfın adı ile erişilir, nesne oluşturlmaz

            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "İK");

            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Deniz", "Arda", "İK");
            Calisan calisan2 = new Calisan("Beliz", "Yazıcı", "İK");

            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama sonucu: {0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma sonucu: {0}", Islemler.Cikar(400,50));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            Isim = isim;
            Soyisim = soyisim;
            Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}