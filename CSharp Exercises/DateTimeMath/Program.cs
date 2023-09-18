// See https://aka.ms/new-console-template for more information
using System;

namespace DateTimeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());// Saturday, April 24, 2022
            Console.WriteLine(DateTime.Now.ToShortDateString()); // 4/24/2022
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // 5:19:29 PM
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // 5:19 PM

            Console.WriteLine(DateTime.Now.AddDays(2)); // add 2 days
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30)); // add 30 seconds
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // 24
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); // 04 
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy")); //22
            Console.WriteLine(DateTime.Now.ToString("yyyy"));// 2022

            //Math
            Console.WriteLine(Math.Abs(-25)); // 25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); //23 - yukarıya yuvarlar
            Console.WriteLine(Math.Round(22.3)); // 22
            Console.WriteLine(Math.Floor(22.7)); //22 - aşağıya yuvarlar

            
            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Exp(9));
            Console.WriteLine(Math.Log10(10));




            


        }
    }
}