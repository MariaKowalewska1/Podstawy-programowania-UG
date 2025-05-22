using System;
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
            Console.Write("Podaj ilosc elementow tablicy, mniejsza lub rowna 1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0;i<n;i++)
            {
                Console.Write("tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elementy tablicy: ");
            for (i=n-1;i>=0;i--)
      //nieoze byc i=n bo tablice maja o 1 mniej miejsce niz n , dla n=3, tablica ma takie wyrazy: tab[0],tab[1],tab[2], wiec jesli i bedzie sie zaczynalo od n to da n wyrazowi wartosc 0
            {
                Console.WriteLine("{0}, ", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
