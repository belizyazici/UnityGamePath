// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListt
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            /*
            list.Add("Ayşe");
            list.Add(2);
            list.Add(true);
            list.Add('A');
            
            
            //içindeki verilere erişim
            Console.WriteLine(list[1]);

            foreach (var item in list)
                Console.WriteLine(item);
            */    

            //AddRange - birden fazla elemanı toplu halde eklemek
            //string[] colors = {"kırmızı","sarı", "yeşil"};
            List<int> numbers = new List<int>(){1,8,3,7,9,92,5};

            //list.AddRange(colors);
            list.AddRange(numbers);

            foreach(var item in list)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("****Sort****");
            list.Sort();

            foreach(var item in list)
                Console.WriteLine(item);    

            //Binary Search - önce sıralanıp (sorting) sonra binar search yapılmalı
            Console.WriteLine("****Binary Search****");
            Console.WriteLine(list.BinarySearch(9));

            //reverse
            Console.WriteLine("****Reverse****");
            list.Reverse();

            foreach (var item in list)
                Console.WriteLine(item);

            //clear
            Console.WriteLine("****Clear****");
            list.Clear();

            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}