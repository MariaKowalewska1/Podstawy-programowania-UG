using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_kolo3
{
    internal class Program
    {
        static void scalenie(int[] tab1, int[] tab2)
        {//napisz metode ktora zwraca dwie scalone tablice jednowymiarowe
            foreach (int x in tab1)
                Console.Write("{0}, ", x);
            foreach (int x in tab2)
                Console.Write("{0}, ", x);
        }
        static void Main(string[] args)
        {
            int[] tablica1 = { 1, 2, 3, 4 };
            int[] tablica2 = { 5, 6, 7, 8 };
            Console.Write("Elementy obu tablic: ");
            scalenie(tablica1, tablica2);

        }
    }
}