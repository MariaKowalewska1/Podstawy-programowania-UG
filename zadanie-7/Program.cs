using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie 
         //najmniejszą i największą wczytaną liczbę.

            int[] tab = new int[1000];
            int n, min, max, i;
            Console.Write("Podaj ilosc wyrazow ciagu, mniejsza lub rowna 1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0;i<n;i++)
            {
                Console.Write("tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            min = tab[0];
            max = tab[0];
            for (i=1;i<n;i++)
            {
                if (tab[i] < min) min = tab[i];
                if (tab[i] > max) max = tab[i];
            }
            Console.WriteLine("Najmniejszy wyraz ciagu: {0}", min);
            Console.WriteLine("Najwiekszy wyraz ciagu: {0}", max);
            
        }
    }
}
