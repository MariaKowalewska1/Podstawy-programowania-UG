using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący z klawiatury liczbę całkowitą i wypisujący na ekranie sześcian wczytanej liczby
            Double a;
            Console.WriteLine("Podaj liczbe calkowita: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Szescian tej liczby wynosi {0}", a * a * a);

        }
    }
}
