using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {// Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie 
         //sumę kwadratów wczytanych liczb. 
            int[] tab = new int[1000];
            int n, i, suma;
            Console.Write("Podaj liczbe wyrazow ciagu, mniejsza lub rowna 1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0;i<n;i++)
            {
                Console.Write("tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            suma = 0;
            for (i = 0; i < n; i++) suma += tab[i] * tab[i];
            Console.WriteLine("Suma kwadratow wszystkich wyrazow ciagu wynosi {0}", suma);
            Console.ReadKey(true);
        }
    }
}
