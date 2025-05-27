using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nowe
{
    internal class Program
    {
       static int sumowanie(int[] tab)
        {    // Metoda obliczająca sumę wszystkich elementów tablicy jednowymiarowej
            int suma = 0;
            foreach (int x in tab)
                suma += x;
            return suma;
        }
    static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3 };
            Console.Write("Suma elementow tablicy:{0}", sumowanie(tablica));
        }
    }
}
