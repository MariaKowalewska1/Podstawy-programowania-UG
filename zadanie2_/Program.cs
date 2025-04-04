using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dany jest wzór ciągu a(n)=2n-1. Napisz program wczytujący liczbę całkowitą dodatnią n wypisujący na ekranie kolejne wyrazy ciągu: a(1), a(2), …, a(n).Użyj pętli while.
            double n, i, an;
            Console.WriteLine("Podaj liczbe calkowita dodatnia n: ");
            n = Convert.ToDouble(Console.ReadLine());
            i = 1;
            while (i <= n)
            {
                an = 2 * i - 1;
                Console.WriteLine("a({0})={1}", i, an);
                i++;
            }
            Console.ReadKey(true);

        }
    }
}
