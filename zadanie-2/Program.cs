﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący wczytane liczby w odwrotnej kolejności na ekranie.

            int[] tab = new int[1000];
            int i, n;
            Console.WriteLine("Podaj liczbe elementow ciagu, mniejsza od 1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i<n; i++)
            {
                Console.WriteLine("Podaj tab[{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elementy tablicy: ");
            for (i = n-1; i>=0; i--)
            {
                Console.Write("{0}, ", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
