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
            Console.Write("Podaj liczbe wierszy n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe kolumn k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 2; j <= k; j++)//XDDDD czemu 2
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey(true);
        }
    }
}
