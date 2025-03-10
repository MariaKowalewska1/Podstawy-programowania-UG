using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie sumę kwadratów wczytanych liczb.
            int a, b;
            Console.WriteLine("Podaj pierwsza liczbe: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Suma kwadratow liczb wynosi {0}", a * a + b * b);
        }
    }
}
