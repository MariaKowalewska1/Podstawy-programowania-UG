using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to liczba parzysta, czy też nieparzysta
            Console.Write("Podaj liczbe calkowita: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0) Console.WriteLine("Podana liczba jest parzysta");
            else Console.WriteLine("Podana liczba jest nieparzysta");
            Console.ReadKey(true);



        }
    }
}
