﻿// See https://aka.ms/new-console-template for more information
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 2; 
            string degisken = null;
            string Degisken = null;
            Console.WriteLine(deger);

            String degisken1 = " ";
 
            byte b = 5; //0 - 255  1 byte
            sbyte c = 5; //-128 - 127  1 byte

            short s = 5; // 2 byte
            ushort us = 5; //2 byte

            Int16 i16 = 2; // 2 byte
            int i = 2; // 4 byte
            Int32 i32 = 2; // 4 byte
            Int64 i64 = 2; // 8 byte

            uint ui = 2; // 4 byte
            long l = 4; //8 byte
            ulong ul = 4; //8 byte

            float f = 5; //4 byte
            double d = 5; //8 byte
            decimal de = 5; //16 byte
            
            char ch = '2';// 2 byte
            string str = "hello"; //sınırsız

            bool bl = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3; // tüm değişken türleri aslında birer objedir

            //string ifadeler

            string str1 = string.Empty;
            str1 = "Beliz Yazıcı";
            string ad = "Beliz";
            string soyad = "Yazıcı";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //boolean

            bool b3 = 10>2;

            //değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);//çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);//çıktısı 40

            int int22 = int20 + int.Parse(str20); //çıktısı 40

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");//zamanı bu şekilde formatla ve getir demek
            Console.WriteLine(datetime);//çıktısı 05.09.2023

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");//saati istersen
            Console.WriteLine(hour);//çıktısı 16:04
 
            


        }
    }
}