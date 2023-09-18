// See https://aka.ms/new-console-template for more information
using System;

namespace HazirMetotlarString
{
    class Program
    {
        static void Main(string[] args){
            string degisken = "Dersimiz CSharp, hoşgeldiniz!";
            string degisken2 = "Csharp";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat - birleştirmek için
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //(karakter sayısı büyüklüğü)1. = 2. -> 0,1. > 2. -> 1, 1. < 2. -> -1
            Console.WriteLine(String.Compare(degisken, degisken2,true));//true dersek büyük harf küçük harf duyarlılığı kapatılmış olur

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));// C nin olduğu ilk indexi döndürür
            Console.WriteLine(degisken.IndexOf("Beliz"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));//toplam karakter sayısından büyük olmalı
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10)); //10. indexten sonrasını siler
            Console.WriteLine(degisken.Remove(5,3)); //5. indexten sonra 3 karakter siler
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));  
            Console.WriteLine(degisken.Replace(" ", "*"));    

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);    

            //Substring
            Console.WriteLine(degisken.Substring(4));//4. indexten sonuna kadar getirir
            Console.WriteLine(degisken.Substring(4, 6));//4. indexten 6 karakter getir




        }
    }
}