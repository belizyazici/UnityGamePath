// See https://aka.ms/new-console-template for more information
using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);
            }
            catch(Exception ex){
                Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            //finally{
            //    Console.WriteLine("İşlem tamamlandı.");
            //}
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-2000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(e);
            }
            catch(OverflowException exc)
            {
                Console.WriteLine("Çok büyük veya çok küçük bir değer girdiniz.");
                Console.WriteLine(exc);
            }
            finally{
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}