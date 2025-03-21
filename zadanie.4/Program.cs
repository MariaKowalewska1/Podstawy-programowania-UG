using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt posiadający n wierszy i k kolumn. Użyj pętli for
            Double n, k;
            Console.WriteLine("Podaj liczbe naturalna n: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe naturalna k: ");
            k = Convert.ToDouble(Console.ReadLine());
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= k; j++) 
                Console.Write("*");
                Console.WriteLine(" ");
            }
            Console.ReadKey(true);
        }
    }
}
