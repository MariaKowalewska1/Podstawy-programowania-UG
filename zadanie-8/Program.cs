using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb naturalnych i wypisujący na ekranie 
         //wszystkie parzyste liczby w kolejności niemalejącej. Do wypisywania elementów tablicy użyj
         //pętli foreach.
         //Wskazówka: Posortuj wczytane liczby, a następnie z tablicy wypisz tylko liczby parzyste
         
            
            int i, j, x, n;
            Console.Write("Podaj ilosc wyrazow ciagu, mniejsza lub rowna 1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
                for (j = i + 1; j < n; j++)
                {
                    if (tab[i] > tab[j])
                    {
                        x = tab[i];
                        tab[i] = tab[j];
                        tab[j] = x;
                    }
                }
            Console.Write("Posortowane i parzyste wyrazy ciagu: ");
            foreach (int liczba in tab)
            {
                if (liczba % 2 == 0)
                    Console.Write("{0}, ", liczba);
            }
            Console.ReadKey(true);
        }
    }
}
