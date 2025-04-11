using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna, czy też równa zero
            Console.Write("Podaj liczbe calkowita n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0) Console.WriteLine("Podana liczba jest dodatnia");
            else if (n < 0) Console.WriteLine("Podana liczba jest ujemna");
            else Console.WriteLine("Podana liczba jest rowna 0");
            Console.ReadKey(true);
        }
    }
}
