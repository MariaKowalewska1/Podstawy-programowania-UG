using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą n (n>2) i wypisujący na ekranie wartość sumy 1 + 2 +…+n.Do obliczenia wartości sumy użyj pętli for. 

            int n;
            Console.WriteLine("Podaj liczbe calkowita wieksza od 2: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 2)
            {
                Console.WriteLine("Ta liczba nie jest wieksza od 2");
                return;
            }
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("Suma liczb od 1 do {0} wynosi {1}", n, suma);
            Console.ReadKey(true);


        }
    }
}
