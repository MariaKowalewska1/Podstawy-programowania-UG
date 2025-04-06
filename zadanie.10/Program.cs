using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._10
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Napisz program drukujący na ekranie kolejne liczby naturalne podzielne przez 7. Ilość liczb 
            wczytaj z klawiatury.Użyj pętli for. Oto wydruk dla ile = 6: 0, 7, 14, 21, 28, 35*/

            int n;
            Console.WriteLine("Podaj ilosc liczb podzielnych przez 7: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(i*7);
                if (i < n - 1)
                    Console.Write(",");
                else
                    Console.Write("");
            }
            Console.ReadKey(true);



            }
        }
}
