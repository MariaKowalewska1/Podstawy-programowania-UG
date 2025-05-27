using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nowe2
{
    internal class Program
    {
        static void tylkoparzyste(int[]tab)
        {//Metoda wypisująca tylko liczby parzyste z tablicy
            foreach (int x in tab)
                if (x % 2 == 0)
                    Console.Write("{0}, ", x);
        }
        static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 4, 5 };
            Console.Write("Parzyste elementy tablicy: ");
            tylkoparzyste(tablica);

        }


    }
}
