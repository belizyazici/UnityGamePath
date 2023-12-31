﻿// See https://aka.ms/new-console-template for more information
using System;

namespace theStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı  :{0}", dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct(3,4);// küçük veriler için struct kullanımı performans açısından avantajlıdır
            //Dikdortgen_Struct dikdortgen_struct; böyle de olabilir fakat ilk değerlerini kendisi atayamaz
            //böyle atamak gerekir
            //dikdortgen.KisaKenar = 3;
            //dikdortgen.UzunKenar = 4;
            

            Console.WriteLine("Class Alan Hesabı  :{0}", dikdortgen_struct.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}