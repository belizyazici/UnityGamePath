// See https://aka.ms/new-console-template for more information
using System;

namespace ForLoop
{
    class Program
    {
        public static void staircase(int n)
        {
            if (0<n && n<=100){

               for (int i = 1; i <= n; i++)
               {
                   //printing spaces
                   for (int j = 1; j <= n - i; j++)
                   {
                        Console.Write(" ");
                   }

                    //printing hash symbols
                   for (int k = 1; k <= i; k++)
                   {
                       Console.Write("#");
                   }

                   //moving to the next line
                   Console.WriteLine();
               }
             
            }
            else
               Console.WriteLine("number should be between 0 and 100");
        
            
        }
        static void Main(string[] args)
        {
            
            Console.Write("Lütfen bir sayı giriniz:"); // Write aynı satırda değer girmesi için
            int sayac = int.Parse(Console.ReadLine());//ReadLine string okuduğu için
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını yazdır
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 ==1)
                    tekToplam += i;
                
                else
                    ciftToplam += i; 
            }

            Console.WriteLine("Tek toplam:" + tekToplam);
            Console.WriteLine("Çift toplam:" + ciftToplam);

            //break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                     break;
                Console.WriteLine(i);               
            }
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                     continue;
                Console.WriteLine(i);               
            }
            Console.WriteLine("*******************************");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Program.staircase(n);
        }
    }
}