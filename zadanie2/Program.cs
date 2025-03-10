using System;
using System.Collections.Generic;
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
            Double a;
            Console.WriteLine("Podaj liczbe: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Liczba jest dodatnia");
            else if (a < 0)
                Console.WriteLine("Liczba jet ujemna");
            else
                Console.WriteLine("liczba jest rowna 0");
        }
    }
}
