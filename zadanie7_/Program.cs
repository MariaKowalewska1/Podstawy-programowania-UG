using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7_
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisz program stwierdzający, czy zadana liczba n jest pierwsza. Użyj pętli while.

            int n, i;
            Console.Write("Podaj liczbe n, wieksza od 0: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Podana liczba nie jest liczba pierwsza");
                return;
            }
            i = 2;
            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Podana liczba nie jest liczba pierwsza");
                    return;

                }
                i++;
            }
            Console.WriteLine("Podana liczba jest liczba pierwsza");
            Console.ReadKey(true);
        }
    }
}