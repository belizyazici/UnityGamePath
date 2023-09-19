// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Dictionaryy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10, "Ayşe Yılmaz");
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Coşar");

            //dizinin elemanlarına erişim
            Console.WriteLine(kullanicilar[12]);
            foreach(var item in kullanicilar)
                Console.WriteLine(item);
            
            //Count
            Console.WriteLine(kullanicilar.Count);

            //contains
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Beliz"));

            //remove
            kullanicilar.Remove(12);
            foreach(var item in kullanicilar)
                Console.WriteLine(item.Value);

            //keys
            Console.WriteLine("***Keys***");
            foreach(var item in kullanicilar.Keys)
                Console.WriteLine(item);

            //values
            Console.WriteLine("***values***");
            foreach(var item in kullanicilar.Values)
                Console.WriteLine(item);
        }
    }
}