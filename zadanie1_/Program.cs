using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1_
{
    class Program
    {
        static void Main(string[] args)
        {//Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z przedziału [a, b].Użyj pętli while

            double a, b, i;
            Console.WriteLine("Podaj liczbe a, wieksza od 0: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b, wieksza od a: ");
            b = Convert.ToDouble(Console.ReadLine());
            i = a;
            while (i <= b)
                {
                if (i % 2 == 0) Console.Write("{0}, ", i);
                i++;
            }
            Console.ReadKey(true);

        }
    }
}
