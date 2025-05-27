using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace nowe3
{
    internal class Program
    {
        static int najwieksze(int[]tab)
        {//Metoda znajdująca największy element w tablicy

            int max = tab[0];
            foreach (int x in tab)
                if (x > max) max = x;
            return max;
        }
        static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 4, 5 };
            Console.Write("Najwiekeszy wyraz z tablicy to {0}", najwieksze(tablica));
            Console.ReadKey(true);
        }
    }
}
