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

            int n, i, an;
            Console.Write("Podaj liczbe wyrazow ciagu: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Liczba musi byc dodatnia i calkowita");
                return;
            }
            i = 0;
            while (++i <= n)
            {
                an = 2 * i - 1;
                Console.Write("a({0}) = {1}, ", i, an);
                
               
            }
            Console.ReadKey(true);
        }
    }
}
