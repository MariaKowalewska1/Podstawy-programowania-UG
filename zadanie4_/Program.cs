using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4_
{
    class Program
    {
        static void Main(string[] args)
        {/*Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
            posiadający n wierszy i k kolumn. Użyj pętli while.Dla n = 3 i k = 5 mamy:
            *****
            *****
            ***** */

            int n, k, i, j;
            Console.Write("Podaj ilosc wierszy prostokata: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Ilosc wierszy musi byc wieksza niz 0");
                return;
            }
            Console.Write("Podaj ilosc kolumn prostokata: ");
            k = Convert.ToInt32(Console.ReadLine());
            if (k <= 0)
            {
                Console.WriteLine("Ilosc kolumn musi byc wieksza od 0");
                return;
            }
            i = 1;
            while (i <= n)
            {
                j = 1;
                while (j <= k)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine("");
                i++;
            }
            Console.ReadKey(true);
            }
        }
    }

