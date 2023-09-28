// See https://aka.ms/new-console-template for more information
using System;

namespace PolymorphismSealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("******************");

            Kuslar marti = new Kuslar();
            marti.Ucma();
        }
    }

}